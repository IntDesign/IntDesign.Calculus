using Calculus.Core.Models.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModels.inputs.house
{
    public class HouseFilteredRequestType : InputObjectGraphType<HouseFilter>
    {
        public HouseFilteredRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
            Field(t => t.Names, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}