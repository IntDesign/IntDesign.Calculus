using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.Repositories.model;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementation
{
    public class RoomJobRepository : IRoomJobRepository
    {
        private readonly DataContext m_context;
        public RoomJobRepository(DataContext context) => m_context = context;

        public async Task<RoomJob> AddJob(RoomJob job)
        {
            job.Id = Guid.NewGuid();
            await m_context.RoomJobs.AddAsync(job);
            await m_context.SaveChangesAsync();
            return job;
        }

        public async Task<RoomJob> RemoveJob(Guid jobId)
        {
            var job = await m_context.RoomJobs.Where(t => t.Id == jobId).FirstOrDefaultAsync();
            m_context.Remove(job);
            await m_context.SaveChangesAsync();
            return job;
        }

        public async Task<Tuple<int, List<RoomJob>>> SearchAsync(RoomJobFilter filter, PagedRequest pagination,
            OrderedRequest ordering) =>
            await filter.Filter(m_context.RoomJobs.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(RoomJob.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);
    }
}