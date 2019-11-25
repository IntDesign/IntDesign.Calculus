using Calculus.Core.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialInformation
{
    public class MaterialInformationFilterRequestType : InputObjectGraphType<MaterialInformationFilter>
    {
        public MaterialInformationFilterRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}