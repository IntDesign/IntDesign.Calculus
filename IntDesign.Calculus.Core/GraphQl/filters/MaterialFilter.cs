using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models;
using Calculus.Core.Tools;

namespace Calculus.Core.GraphQl.filters
{
    public class MaterialFilter: ISearchTermFilter<IQueryable<Material>>
    {
        
        public string SearchTerm { get; set; }
        public List<Guid> Ids { get; } = new List<Guid>();
        public List<string> Names { get; } = new List<string>();
        public MaterialFilter()
        {
        }

        public MaterialFilter(string searchTerm = null, List<Guid> ids = null, List<string> names = null)
        {
            SearchTerm = searchTerm;
            Ids = ids;
            Names = names;
        }
        public IQueryable<Material> Filter(IQueryable<Material> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filterQuery = Guid.TryParse(SearchTerm, out var materialId)
                    ? filterQuery.Where(t => t.Id == materialId)
                    : filterQuery.Where(t => t.MaterialName == SearchTerm);
            }

            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Any(v => v == t.Id));
            }

            if (Names.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Names.Any(v => t.MaterialName.Contains(v)));
            }

            return filterQuery;
        }
    }
}