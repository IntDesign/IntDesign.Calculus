using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.material;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class MaterialMutation : ObjectGraphType
    {
        public MaterialMutation(IMaterialRepository repository)
        {
            FieldAsync<MaterialQueryType>(
                "addMaterial",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<MaterialCreateViewModel>>
                {
                    Name = "material"
                }),
                resolve: async context =>
                {
                    var material = context.GetArgument<Material>("material");
                    return await context.TryAsyncResolve(async _ => await repository.AddMaterial(material));
                }
            );
        }
    }
}