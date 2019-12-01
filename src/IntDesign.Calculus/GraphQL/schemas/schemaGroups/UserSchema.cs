using Calculus.Core.Models;
using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class UserSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<UserQueries>(
                "users",
                resolve: _ => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<UserMutation>(
                "users",
                resolve: _ => new { });
        }
    }
}