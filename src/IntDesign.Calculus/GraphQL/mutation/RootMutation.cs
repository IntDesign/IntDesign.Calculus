using System.Collections.Generic;
using Calculus.GraphQL.schemas.models;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation(IEnumerable<ISchemaGroup> mutations)
        {
            Name = "Mutations";
            foreach (var mutation in mutations) mutation.SetGroup(this);
        }
    }
}