using System;
using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models;
using Calculus.Core.Tools;

namespace Calculus.Core.GraphQl.filters
{
    public class UserFilter : ISearchTermFilter<IQueryable<User>>
    {
        public string SearchTerm { get; set; }
        public List<Guid> Ids { get; set; } = new List<Guid>();
        public List<string> Names { get; set; } = new List<string>();

        public UserFilter()
        {
            
        }
        
        public UserFilter(string searchTerm = null, List<Guid> ids = null, List<string> names = null)
        {
            if (ids != null) Ids = ids;
            if (names != null) Names = names;
            SearchTerm = searchTerm;
        }
        
        public IQueryable<User> Filter(IQueryable<User> filterQuery)
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filterQuery = Guid.TryParse(SearchTerm, out var userId)
                    ? filterQuery.Where(t => t.Id == userId)
                    : filterQuery.Where(t => CheckContains(t));
            }

            if (Ids.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Ids.Any(v => v == t.Id));
            }

            if (Names.Count > 0)
            {
                filterQuery = filterQuery.Where(t => Names.Any(v => t.Username.Contains(v)));
            }

            return filterQuery;
        }

        private bool CheckContains(User user)
        {
            return user.Email.Contains(SearchTerm) ||
                   user.Username.Contains(SearchTerm);
        }
    }
}