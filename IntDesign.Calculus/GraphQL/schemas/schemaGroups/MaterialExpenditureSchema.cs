using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using Calculus.GraphQL.schemas.models;

namespace Calculus.GraphQL.schemas.schemaGroups
{
    public class MaterialExpenditureSchema : ISchemaGroup
    {
        public void SetGroup(RootQuery query)
        {
            query.Field<MaterialExpenditureQueries>(
                "expenditures",
                resolve: _ => new { });
        }

        public void SetGroup(RootMutation mutation)
        {
            mutation.Field<MaterialExpenditureMutation>(
                "expenditures",
                resolve: _ => new { });
        }
    }
}