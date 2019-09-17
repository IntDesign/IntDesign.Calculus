using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MainModels;
using Calculus.Repositories.models;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementations
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
        }
    }
}