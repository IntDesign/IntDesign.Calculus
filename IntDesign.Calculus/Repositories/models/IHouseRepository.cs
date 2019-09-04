using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;

namespace Calculus.Repositories.models
{
    public interface IHouseRepository
    {
        Task<House> AddHouse(House house);
        Task<House> RemoveHouse(Guid id);

        Task<Tuple<int, List<House>>> SearchAsync(HouseFiltering filtering, PagedRequest pagination,
            OrderedRequest ordering);
    }
}