using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class UserQueryType : ObjectGraphType<User>
    {
        public UserQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("User ID");
            Field(t => t.Username, false, typeof(StringGraphType)).Description("User ID");
            Field(t => t.Email, false, typeof(StringGraphType)).Description("User ID");
            Field(t => t.IsWorker, false, typeof(StringGraphType)).Description("User ID");
        }
    }
}