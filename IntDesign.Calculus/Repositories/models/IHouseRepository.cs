using System;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;
using Calculus.GraphQL.helpers;

namespace Calculus.Repositories.models
{
    public interface IHouseRepository
    {
        Task<House> AddHouse(House house);
        Task<House> RemoveHouse(Guid id);

        Task<ListResult<House>> SearchAsync(HouseFiltering filtering);
    }
}