using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models.SecondaryModels;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.GraphQl.filters
{
    public class MaterialExpenditureFilter : ISearchTermFilter<IQueryable<MaterialExpenditure>>
    {
        public string SearchTerm { get; set; }
        public List<Guid> Ids { get; set; } = new List<Guid>();
        
        public MaterialExpenditureFilter()
        {
            
        }

        public MaterialExpenditureFilter(string searchTerm = null, List<Guid> ids = null)
        {
            SearchTerm = searchTerm;
            Ids = ids;
        }
        
        public IQueryable<MaterialExpenditure> Filter(IQueryable<MaterialExpenditure> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filterQuery = Guid.TryParse(SearchTerm, out var materialId)
                    ? filterQuery.Where(t => t.Id == materialId)
                    : filterQuery;
            }
            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Any(v => v == t.Id));
            }
            
            return filterQuery;
        }
    }
}