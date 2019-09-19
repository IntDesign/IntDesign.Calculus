using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class MaterialExpenditureQueryType : ObjectGraphType<MaterialExpenditure>
    {
        public MaterialExpenditureQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType))
                .Description("Material Expenditure Information ID");
            Field(t => t.TotalPrice, false, typeof(FloatGraphType))
                .Description("Material Expenditure Information ID");
            Field(t => t.TotalKilograms, false, typeof(FloatGraphType))
                .Description("Material Expenditure Information ID");
            Field(t => t.TotalPackets, false, typeof(FloatGraphType))
                .Description("Material Expenditure Information ID");
            Field(t => t.PricePerPacket, false, typeof(FloatGraphType))
                .Description("Material Expenditure Information ID");
        }
    }
}