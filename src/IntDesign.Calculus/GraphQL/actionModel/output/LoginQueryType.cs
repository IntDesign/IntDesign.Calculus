using Calculus.Core.Requests.Login;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class LoginQueryType : ObjectGraphType<LoginResponse>
    {
        public LoginQueryType()
        {
            Field(t => t.UserId, false, typeof(StringGraphType)).Description("User ID");
            Field(t => t.IsSuccessful, false, typeof(BooleanGraphType)).Description("User ID");
            Field(t => t.Error, false, typeof(StringGraphType)).Description("Fail Reason");
        }
    }
}