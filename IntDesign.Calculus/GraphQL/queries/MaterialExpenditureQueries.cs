using System;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.SecondaryModels;
using Calculus.GraphQL.actionModel.input.materialExpenditure;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class MaterialExpenditureQueries : ObjectGraphType
    {
        public MaterialExpenditureQueries(IMaterialExpenditureRepository repository)
        {
            FieldAsync<ListMaterialExpenditureQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<MaterialExpenditureFilterRequestType> {Name = "filter", DefaultValue = new MaterialFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<MaterialExpenditureFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, materialExpenditures) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<MaterialExpenditure>
                    {
                        TotalCount = count,
                        Items = materialExpenditures
                    };
                }
            );
        }
    }
}