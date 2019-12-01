using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.user
{
    public class UserCreateViewModel : InputObjectGraphType<User>
    {
        public UserCreateViewModel()
        {
            Field(t => t.Username, false, typeof(NonNullGraphType<StringGraphType>));
            Field(t => t.Password, false, typeof(NonNullGraphType<StringGraphType>));
            Field(t => t.Email, false, typeof(NonNullGraphType<StringGraphType>));
        }       
    }
}