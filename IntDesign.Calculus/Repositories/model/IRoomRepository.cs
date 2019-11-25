using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IRoomRepository
    {
        Task<Room> AddRoom(Room room);
        Task<Room> RemoveRoom(Guid roomId);
        Task<Room> UpdateRoomValues(Guid roomId);
        Task<Tuple<int, List<Room>>> SearchAsync(RoomFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}