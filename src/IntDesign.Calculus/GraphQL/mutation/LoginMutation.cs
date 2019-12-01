using Calculus.Core.Requests.Login;
using Calculus.GraphQL.actionModel.input.login;
using Calculus.GraphQL.actionModel.output;
using Calculus.Handlers.models;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class LoginMutation : ObjectGraphType
    {
        public LoginMutation(ILoginHandler handler)
        {
            FieldAsync<LoginQueryType>(
                "sendLogin",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<LoginCreateViewModel>>
                {
                    Name = "request"
                }),
                resolve: async context =>
                {
                    var house = context.GetArgument<LoginRequest>("request");
                    return await context.TryAsyncResolve(async _ => await handler.ProcessRequest(house));
                }
            );
        }
    }
}