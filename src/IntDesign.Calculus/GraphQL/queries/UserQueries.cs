using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.user;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class UserQueries : ObjectGraphType
    {
        public UserQueries(IUserRepository repository)
        {
            FieldAsync<ListUsersQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<UserFilteredRequestType>
                        {Name = "filter", DefaultValue = new UserFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<UserFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, users) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<User>
                    {
                        TotalCount = count,
                        Items = users
                    };
                });
        }
    }
}