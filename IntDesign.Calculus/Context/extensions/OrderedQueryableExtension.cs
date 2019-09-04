using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Calculus.Core.Models.GraphQl;

namespace Calculus.Context.extensions
{
    public static class OrderedQueryableExtension
    {
        public static IQueryable<TSource> OrderBy<TSource>(
            this IQueryable<TSource> query, string propertyName, OrderDirection direction)
        {
            var entityType = typeof(TSource);

            //Create x=>x.PropName
            var propertyInfo = entityType.GetProperty(propertyName,
                BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance);
            var arg = Expression.Parameter(entityType, "x");
            var property = Expression.Property(arg, propertyName);
            var selector = Expression.Lambda(property, arg);

            var actionName = direction.Equals(OrderDirection.Asc)
                ? "OrderBy"
                : "OrderByDescending";
            var enumerableType = typeof(Queryable);

            var method = enumerableType.GetMethods()
                .Where(m => m.Name == actionName && m.IsGenericMethodDefinition)
                .Single(m =>
                {
                    var parameters = m.GetParameters().ToList();
                    return parameters.Count == 2;
                });

            if (null == propertyInfo)
                return query;

            var genericMethod = method
                .MakeGenericMethod(entityType, propertyInfo.PropertyType);

            var newQuery = (IOrderedQueryable<TSource>) genericMethod
                .Invoke(genericMethod, new object[] {query, selector});
            return newQuery;
        }
    }
}