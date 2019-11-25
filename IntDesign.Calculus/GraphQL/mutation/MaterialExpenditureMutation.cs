using System;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.materialExpenditure;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class MaterialExpenditureMutation : ObjectGraphType
    {
        public MaterialExpenditureMutation(IMaterialExpenditureRepository repository)
        {
            FieldAsync<MaterialExpenditureQueryType>(
                "addExpenditure",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<MaterialExpenditureCreateViewModel>>
                {
                    Name = "materialExpenditure"
                }),
                resolve: async context =>
                {
                    var expenditure = context.GetArgument<MaterialExpenditure>("materialExpenditure");
                    return await context.TryAsyncResolve(
                        async _ => await repository.AddMaterialExpenditure(expenditure));
                }
            );
            FieldAsync<MaterialExpenditureQueryType>(
                "updateExpenditureValues",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return await context.TryAsyncResolve(
                        async _ => await repository.UpdateMaterialExpenditureValues(id));
                }
            );
        }
    }
}