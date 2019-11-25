using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IRoomJobRepository
    {
        Task<RoomJob> AddJob(RoomJob job);
        Task<RoomJob> RemoveJob(Guid jobId);

        Task<Tuple<int, List<RoomJob>>> SearchAsync(RoomJobFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}