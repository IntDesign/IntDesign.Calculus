using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class RoomWallObjectSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<RoomWallObjectQueries>(
                "wallObject",
                resolve: _ => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<RoomWallObjectMutation>
            (
                "wallObject",
                resolve: _ => new { });
        }
    }
}