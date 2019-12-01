using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class MaterialSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<MaterialQuery>(
                "material",
                resolve: _ => new { }
            );
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<MaterialMutation>(
                "material",
                resolve: _ => new { }
            );
        }
    }
}