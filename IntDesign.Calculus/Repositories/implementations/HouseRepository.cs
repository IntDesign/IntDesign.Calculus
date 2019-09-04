using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;
using Calculus.Repositories.models;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementations
{
    public class HouseRepository : IHouseRepository
    {
        private readonly MainContext m_context;

        public HouseRepository(MainContext context)
        {
            m_context = context;
        }

        public async Task<House> AddHouse(House house)
        {
            house.Id = new Guid();
            await m_context.Houses.AddAsync(house);
            await m_context.SaveChangesAsync();
            return house;
        }

        public async Task<House> RemoveHouse(Guid id)
        {
            var house = await m_context.Houses.Where(t => t.Id == id).FirstOrDefaultAsync();
            m_context.Houses.Remove(await m_context.Houses.Where(t => t.Id == id).FirstOrDefaultAsync());
            return house;
        }

        public async Task<Tuple<int, List<House>>> SearchAsync(HouseFiltering filtering, PagedRequest pagination,
            OrderedRequest ordering)
        {
            return await filtering.Filter(m_context.Houses.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(House.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);
        }
    }
}