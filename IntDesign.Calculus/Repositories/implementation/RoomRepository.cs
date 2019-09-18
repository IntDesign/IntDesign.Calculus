using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.MainModels;
using Calculus.Repositories.model;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementation
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MainContext m_context;

        public RoomRepository(MainContext mainContext) => m_context = mainContext;

        public async Task<Room> AddRoom(Room room)
        {
            room.Id = Guid.NewGuid();
            SetStandAloneValues(room);
            await m_context.Rooms.AddAsync(room);
            await m_context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> RemoveRoom(Guid roomId)
        {
            var room = await m_context.Rooms.Where(t => t.Id == roomId).FirstOrDefaultAsync();
            m_context.Rooms.Remove(room);
            await m_context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> UpdateRoomValues(Guid roomId)
        {
            var room = await m_context.Rooms.Include(t => t.RoomObjects)
                .Where(t => t.Id == roomId)
                .FirstOrDefaultAsync();

            SetStandAloneValues(room);
            SetNestedValues(room);
            m_context.Rooms.Update(room);
            await m_context.SaveChangesAsync();
            return room;
        }

        public async Task<Tuple<int, List<Room>>> SearchAsync(RoomFilter filter, PagedRequest pagination,
            OrderedRequest ordering) =>
            await filter.Filter(m_context.Rooms.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(Room.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);

        private static void SetStandAloneValues(Room room)
        {
            room.Atv = room.Lenght * room.Width;
            room.Asp = (room.Lenght * room.Height + room.Width * room.Height) * 2;
            room.Pc = (room.Lenght + room.Width) * 2;
            if (room.CustomHeightOne == null || room.CustomHeightTwo == null || room.CustomLenght == null ||
                room.CustomWidth == null) return;
            room.Afm = (room.CustomHeightOne * room.Lenght + room.CustomHeightTwo * room.Width) -
                       (room.CustomHeightOne * room.CustomLenght + room.CustomHeightTwo * room.CustomWidth);
            room.SpecialAfm = room.CustomHeightOne * room.CustomLenght + room.CustomHeightTwo * room.CustomWidth;
        }

        private static void SetNestedValues(Room room)
        {
            room.EmptyAsp = room.Asp - room.RoomObjects.Sum(roomObject => roomObject.Area * roomObject.Number);
            if (room.Afm == null)
                room.WallRealCoefficient = room.EmptyAsp;
            else room.WallRealCoefficient = room.EmptyAsp - room.Afm;

            if (room.CustomLenght == null || room.CustomWidth == null)
            {
                room.TilesParquetCoefficient = room.Atv;
                room.SpecialTilesParquetCoefficient = 0;
            }
            else
            {
                room.TilesParquetCoefficient = room.Atv - room.CustomLenght * room.CustomWidth;
                room.SpecialTilesParquetCoefficient = room.CustomLenght * room.CustomWidth;
            }
        }
    }
}