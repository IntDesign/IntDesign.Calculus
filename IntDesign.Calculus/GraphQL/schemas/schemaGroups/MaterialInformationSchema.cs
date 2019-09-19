using Calculus.Core.Models.SecondaryModels;
using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class MaterialInformationSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<MaterialInformationQuery>(
                name: "materialInfo",
                resolve: _ => new { }
            );
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<MaterialInformationQuery>(
                "materialInfo",
                resolve: _ => new { }
            );
        }
    }
}