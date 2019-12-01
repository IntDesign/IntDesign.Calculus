using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class MaterialInformationQueryType : ObjectGraphType<MaterialInformation>
    {
        public MaterialInformationQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType))
                .Description("Material Information ID");
            Field(t => t.ProviderId, false, typeof(StringGraphType))
                .Description("Material Information Provider Id");
            Field(t => t.MaterialId, false, typeof(StringGraphType))
                .Description("Material Information Material Id");
            Field(t => t.ConsumptionX, false, typeof(FloatGraphType))
                .Description("Material Information Consumption X");
            Field(t => t.ConsumptionZ, false, typeof(FloatGraphType))
                .Description("Material Information Consumption Z");
            Field(t => t.AppliedLayers, false, typeof(FloatGraphType))
                .Description("Material Information Applied Layers");
            Field(t => t.UnitCover, false, typeof(FloatGraphType))
                .Description("Material Information Unit Cover -> n");
            Field(t => t.PricePerUnit, false, typeof(FloatGraphType))
                .Description("Price for an unit");
            Field(t => t.ProductQuantity, false, typeof(FloatGraphType))
                .Description("Product Quantity");
        }
    }
}