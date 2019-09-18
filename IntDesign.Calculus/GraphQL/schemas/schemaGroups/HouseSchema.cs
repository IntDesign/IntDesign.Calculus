using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class HouseSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<HouseQueries>(
                "house",
                resolve: _ => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<HouseMutation>(
                "house",
                resolve: _ => new { });
        }
    }
}