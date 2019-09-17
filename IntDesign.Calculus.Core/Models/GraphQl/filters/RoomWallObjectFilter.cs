using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models.MainModels;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.GraphQl.filters
{
    public class RoomWallObjectFilter : ISearchTermFilter<IQueryable<RoomWallObject>>
    {
        public List<Guid> Ids { get; } = new List<Guid>();
        public string SearchTerm { get; set; }

        public RoomWallObjectFilter()
        {
        }

        public RoomWallObjectFilter(string searchTerm = null, List<Guid> ids = null)
        {
            SearchTerm = searchTerm;
            Ids = ids;
        }

        public IQueryable<RoomWallObject> Filter(IQueryable<RoomWallObject> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
                return Guid.TryParse(SearchTerm, out var roomId)
                    ? filterQuery.Where(t => t.Id == roomId)
                    : filterQuery.Where(t => t.Type.ToString() == SearchTerm);
            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Contains(t.Id));
            }

            return filterQuery;
        }
    }
}