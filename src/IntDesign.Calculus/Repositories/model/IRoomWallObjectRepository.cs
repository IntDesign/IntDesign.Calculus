using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IRoomWallObjectRepository
    {
        Task<RoomWallObject> AddWallObject(RoomWallObject wallObject);
        Task<RoomWallObject> RemoveWallObject(Guid roomWallObjectId);

        Task<Tuple<int, List<RoomWallObject>>> SearchAsync(RoomWallObjectFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}