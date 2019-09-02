using System.Collections.Generic;
using System.Linq;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;
using Calculus.GraphQL.actionModels.inputs.house;
using Calculus.GraphQL.actionModels.types;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.models;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class HouseQueries : ObjectGraphType
    {
        public HouseQueries(IHouseRepository houseRepository)
        {
            FieldAsync<ListHouseQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<HouseFilteredRequestType>
                    {
                        Name = "filter",
                        DefaultValue = new HouseFiltering()
                    }),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<HouseFiltering>("filter");
                    return await houseRepository.SearchAsync(filtering);
                }
            );
        }
    }
}