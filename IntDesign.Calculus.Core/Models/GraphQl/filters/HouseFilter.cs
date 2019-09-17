using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models.MainModels;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.GraphQl.filters
{
    public class HouseFilter : ISearchTermFilter<IQueryable<House>>
    {
        public List<Guid> Ids { get; } = new List<Guid>();
        public List<string> Names { get; } = new List<string>();

        public HouseFilter()
        {
        }

        public HouseFilter(string searchTerm = null, List<Guid> ids = null, List<string> names = null)
        {
            if (ids != null) Ids = ids;
            if (names != null) Names = names;
            SearchTerm = searchTerm;
        }

        public string SearchTerm { get; set; }

        public IQueryable<House> Filter(IQueryable<House> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filterQuery = Guid.TryParse(SearchTerm, out var houseId)
                    ? filterQuery.Where(t => t.Id == houseId)
                    : filterQuery.Where(t => CheckContains(t));
            }

            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Any(v => v == t.Id));
            }

            if (Names.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Names.Any(v => t.OwnerName.Contains(v)));
            }

            return filterQuery;
        }

        private bool CheckContains(House house)
        {
            return house.OwnerName.Contains(SearchTerm) ||
                   house.HouseAddress.Contains(SearchTerm) ||
                   house.OwnerPhone.Contains(SearchTerm) ||
                   !string.IsNullOrEmpty(house.OwnerEmail) && house.OwnerEmail.Contains(SearchTerm);
        }
    }
}