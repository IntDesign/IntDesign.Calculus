using System.Linq;

namespace Calculus.Core.Tools
{
    public interface ISearchTermFilter<T> where T : IQueryable<IIdentifier>
    {
        string SearchTerm { get; set; }
        
        T Filter(T filterQuery);
    }
}