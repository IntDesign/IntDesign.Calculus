using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class LoginSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<LoginMutation>(
                "login",
                resolve: _ => new { });
        }
    }
}