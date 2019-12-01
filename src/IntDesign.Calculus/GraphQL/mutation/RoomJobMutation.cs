using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.roomJob;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class RoomJobMutation : ObjectGraphType
    {
        public RoomJobMutation(IRoomJobRepository repository)
        {
            FieldAsync<RoomJobQueryType>(
                "addJob",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoomJobCreateViewModel>>
                {
                    Name = "job"
                }),
                resolve: async context =>
                {
                    var job = context.GetArgument<RoomJob>("job");
                    return await context.TryAsyncResolve(async _ => await repository.AddJob(job));
                }
            );
        }
    }
}