using Calculus.Core.Requests.Login;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.login
{
    public class LoginCreateViewModel : InputObjectGraphType<LoginRequest>
    {
        public LoginCreateViewModel()
        {
            Field(t => t.Account, false, typeof(NonNullGraphType<StringGraphType>));
            Field(t => t.Password, false, typeof(NonNullGraphType<StringGraphType>));
        }
    }
}