using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models;
using Calculus.Core.Tools;

namespace Calculus.Core.GraphQl.filters
{
    public class RoomJobFilter : ISearchTermFilter<IQueryable<RoomJob>>
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();

        public RoomJobFilter()
        {
        }

        public RoomJobFilter(string searchTerm = null, List<Guid> ids = null)
        {
            if (ids != null) Ids = ids;
            SearchTerm = searchTerm;
        }

        public string SearchTerm { get; set; }

        public IQueryable<RoomJob> Filter(IQueryable<RoomJob> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
                return Guid.TryParse(SearchTerm, out var roomId)
                    ? filterQuery.Where(t => t.Id == roomId)
                    : filterQuery.Where(t => CheckContains(t));
            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Contains(t.Id));
            }

            return filterQuery;
        }
        
        private bool CheckContains(RoomJob job) =>
            job.Type.ToString() == SearchTerm ||
            job.RoomId.ToString() == SearchTerm;
    }
}