using Calculus.Core.Models.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.material
{
    public class MaterialFilterRequestType : InputObjectGraphType<MaterialFilter>
    {
        public MaterialFilterRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
            Field(t => t.Names, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}