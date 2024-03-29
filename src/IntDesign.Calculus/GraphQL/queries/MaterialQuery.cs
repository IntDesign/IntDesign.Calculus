using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.material;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class MaterialQuery : ObjectGraphType
    {
        public MaterialQuery(IMaterialRepository repository)
        {
            FieldAsync<ListMaterialQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<MaterialFilterRequestType> {Name = "filter", DefaultValue = new MaterialFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<MaterialFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, materials) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<Material>
                    {
                        TotalCount = count,
                        Items = materials
                    };
                }
            );
        }
    }
}