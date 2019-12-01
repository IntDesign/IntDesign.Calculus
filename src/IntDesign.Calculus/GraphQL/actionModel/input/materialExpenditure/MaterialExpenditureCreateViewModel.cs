using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialExpenditure
{
    public class MaterialExpenditureCreateViewModel : InputObjectGraphType<MaterialExpenditure>
    {
        public MaterialExpenditureCreateViewModel()
        {
            Field(t => t.MaterialInformationId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material Expenditure Material Information Id");
        }
    }
}