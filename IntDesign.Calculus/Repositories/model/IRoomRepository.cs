using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MainModels;

namespace Calculus.Repositories.model
{
    public interface IRoomRepository
    {
        Task<Room> AddRoom(Room room);
        Task<Room> RemoveRoom(Guid roomId);
        Task UpdateRoomValues(Guid roomId);
        Task<Tuple<int, List<Room>>> SearchAsync(RoomFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}