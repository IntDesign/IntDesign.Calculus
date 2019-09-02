using System.Collections.Generic;
using Calculus.GraphQL.schemas.models;
using GraphQL.Types;


namespace Calculus.GraphQL.queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IEnumerable<ISchemaGroup> queries)
        {
            Name = "Query";
            foreach (var query in queries) query.SetGroup(this);
        }
    }
}