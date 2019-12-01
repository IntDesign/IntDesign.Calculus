using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models;
using Calculus.Core.Tools;

namespace Calculus.Core.GraphQl.filters
{
    public class RoomFilter : ISearchTermFilter<IQueryable<Room>>
    {
        public string SearchTerm { get; set; }
        public List<Guid> Ids { get; set; } = new List<Guid>();

        public RoomFilter()
        {
        }
        
        public RoomFilter(string searchTerm = null, List<Guid> ids = null)
        {
            if (ids != null) Ids = ids;
            SearchTerm = searchTerm;
        }

        public IQueryable<Room> Filter(IQueryable<Room> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filterQuery = Guid.TryParse(SearchTerm, out var roomId)
                    ? filterQuery.Where(t => t.Id == roomId)
                    : filterQuery.Where(t => CheckContains(t));
            }

            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Any(v => v == t.Id));
            }
            return filterQuery;
        }
        
        private bool CheckContains(Room room) => room.HouseId.ToString().Contains(SearchTerm);
    }
}