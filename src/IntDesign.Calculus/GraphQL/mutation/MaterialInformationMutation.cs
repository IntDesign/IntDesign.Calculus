using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.materialInformation;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class MaterialInformationMutation : ObjectGraphType
    {
        public MaterialInformationMutation(IMaterialInformationRepository repository)
        {
            FieldAsync<MaterialInformationQueryType>(
                "addMaterialInfo",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<MaterialInformationCreateViewModel>>
                {
                    Name = "materialInfo"
                }),
                resolve: async context =>
                {
                    var material = context.GetArgument<MaterialInformation>("materialInfo");
                    return await context.TryAsyncResolve(async _ => await repository.AddMaterialInfo(material));
                }
            );
        }
    }
}