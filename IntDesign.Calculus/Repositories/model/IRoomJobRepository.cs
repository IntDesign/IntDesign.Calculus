using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.MainModels;

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