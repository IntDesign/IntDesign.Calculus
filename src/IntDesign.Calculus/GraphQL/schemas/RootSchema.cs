using Calculus.GraphQL.mutation;
using Calculus.GraphQL.queries;
using GraphQL;
using GraphQL.Types;

namespace Calculus.GraphQL.schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<RootQuery>();
            Mutation = resolver.Resolve<RootMutation>();
        }
    }
}