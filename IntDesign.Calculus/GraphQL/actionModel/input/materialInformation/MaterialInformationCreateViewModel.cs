using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialInformation
{
    public class MaterialInformationCreateViewModel : InputObjectGraphType<MaterialInformation>
    {
        public MaterialInformationCreateViewModel()
        {
            Field(t => t.MaterialId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material Info Material Id");
            Field(t => t.ProviderId, true, typeof(StringGraphType))
                .Description("Material Info Provider Id");
            Field(t => t.AppliedLayers, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Info Applied Layers");
            Field(t => t.PricePerUnit, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Price for a Unit");
            Field(t => t.ProductQuantity, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Product Quantity");
            Field(t => t.ConsumptionZ, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Z");
        }
    }
}