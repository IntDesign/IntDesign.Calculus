using Calculus.Core.Models.SecondaryModels;
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
            Field(t => t.ConsumptionX, false, typeof(StringGraphType))
                .Description("Material Information Consumption X");
            Field(t => t.ConsumptionZ, false, typeof(StringGraphType))
                .Description("Material Information Consumption Z");
            Field(t => t.AppliedLayers, false, typeof(StringGraphType))
                .Description("Material Information Applied Layers");
            Field(t => t.UnitCover, false, typeof(StringGraphType))
                .Description("Material Information Unit Cover");
        }
    }
}