using Calculus.Core.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.user
{
    public class UserFilteredRequestType : InputObjectGraphType<UserFilter>
    {
        public UserFilteredRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
            Field(t => t.Names, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}