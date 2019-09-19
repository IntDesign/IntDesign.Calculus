using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class MaterialExpenditureQueryType : ObjectGraphType<MaterialExpenditure>
    {
        public MaterialExpenditureQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType))
                .Description("Material Expenditure ID");
            Field(t => t.TotalPrice, false, typeof(FloatGraphType))
                .Description("Material Expenditure total price");
            Field(t => t.TotalQuantity, false, typeof(FloatGraphType))
                .Description("Material Expenditure total kilograms needed");
            Field(t => t.TotalPackets, false, typeof(FloatGraphType))
                .Description("Material Expenditure total packets needed");
            Field(t => t.MaterialInformationId, false, typeof(FloatGraphType))
                .Description("Material Expenditure Material Information ID");
        }
    }
}