using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;

namespace Calculus.GraphQL.schemas.models
{
    public interface ISchemaGroup
    {
        void SetGroup(RootQuery query);

        void SetGroup(RootMutation mutation);
    }
}