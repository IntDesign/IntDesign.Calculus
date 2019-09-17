using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class RoomSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<RoomQueries>(
                "room",
                resolve: context => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<RoomMutation>(
                "room",
                resolve: context => new { });
        }
    }
}