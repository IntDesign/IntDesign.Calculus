using Calculus.Context;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.user;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.implementation;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class UserMutation : ObjectGraphType
    {
        
        public UserMutation(IUserRepository repository)
        {
            FieldAsync<UserQueryType>(
                "addUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserCreateViewModel>>
                {
                    Name = "user"
                }),
                resolve: async context =>
                {
                    var user = context.GetArgument<User>("user");
                    return await context.TryAsyncResolve(async _ => await repository.AddUser(user));
                }
            );
        }
    }
}