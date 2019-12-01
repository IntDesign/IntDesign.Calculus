using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IHouseRepository
    {
        Task<House> AddHouse(House house);
        Task<House> RemoveHouse(Guid id);

        Task<Tuple<int, List<House>>> SearchAsync(HouseFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}