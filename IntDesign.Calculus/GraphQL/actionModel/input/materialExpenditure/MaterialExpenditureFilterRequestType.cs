using Calculus.Core.Models.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialExpenditure
{
    public class MaterialExpenditureFilterRequestType : InputObjectGraphType<MaterialExpenditureFilter>
    {
        public MaterialExpenditureFilterRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}