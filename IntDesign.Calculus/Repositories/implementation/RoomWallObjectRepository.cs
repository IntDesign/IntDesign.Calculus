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
    public class RoomWallObjectRepository : IRoomWallObjectRepository
    {
        private readonly MainContext m_context;
        public RoomWallObjectRepository(MainContext mainContext) => m_context = mainContext;

        public async Task<RoomWallObject> AddWallObject(RoomWallObject wallObject)
        {
            wallObject.Id = Guid.NewGuid();
            wallObject.Area = wallObject.Lenght * wallObject.Width;
            await m_context.RoomWallObjects.AddAsync(wallObject);
            await m_context.SaveChangesAsync();
            return wallObject;
        }

        public async Task<RoomWallObject> RemoveWallObject(Guid roomWallObjectId)
        {
            var wallObject = await m_context.RoomWallObjects.Where(t => t.Id == roomWallObjectId).FirstOrDefaultAsync();
            m_context.RoomWallObjects.Remove(wallObject);
            await m_context.SaveChangesAsync();
            return wallObject;
        }

        public async Task<Tuple<int, List<RoomWallObject>>> SearchAsync(RoomWallObjectFilter filter,
            PagedRequest pagination, OrderedRequest ordering) =>
            await filter.Filter(m_context.RoomWallObjects.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(RoomWallObject.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);
    }
}