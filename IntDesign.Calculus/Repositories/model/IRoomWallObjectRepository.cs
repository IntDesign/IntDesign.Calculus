using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MainModels;

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