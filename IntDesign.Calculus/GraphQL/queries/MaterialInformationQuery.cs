using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.materialInformation;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class MaterialInformationQuery : ObjectGraphType
    {
        public MaterialInformationQuery(IMaterialInformationRepository repository)
        {
            FieldAsync<ListMaterialInformationQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<MaterialInformationFilterRequestType> {Name = "filter", DefaultValue = new MaterialFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<MaterialInformationFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, info) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<MaterialInformation>
                    {
                        TotalCount = count,
                        Items = info
                    };
                }
            );
        }
    }
}