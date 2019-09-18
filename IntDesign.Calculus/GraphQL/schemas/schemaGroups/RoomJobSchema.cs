using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class RoomJobSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<RoomJobQueries>(
                "roomJob",
                resolve: _ => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<RoomJobMutation>(
                "roomJob",
                resolve: _ => new { });
        }
    }
}