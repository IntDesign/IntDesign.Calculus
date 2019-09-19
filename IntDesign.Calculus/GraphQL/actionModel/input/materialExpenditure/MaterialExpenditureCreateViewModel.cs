using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialExpenditure
{
    public class MaterialExpenditureCreateViewModel : InputObjectGraphType<MaterialExpenditure>
    {
        public MaterialExpenditureCreateViewModel()
        {
            Field(t => t.MaterialId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material Expenditure Material Id");
        }
    }
}