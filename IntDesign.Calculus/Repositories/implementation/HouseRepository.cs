using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.MainModels;
using Calculus.Repositories.model;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementation
{
    public class HouseRepository : IHouseRepository
    {
        private readonly MainContext m_context;

        public HouseRepository(MainContext context) => m_context = context;

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
            m_context.Houses.Remove(house);
            await m_context.SaveChangesAsync();
            return house;
        }

        public async Task<Tuple<int, List<House>>> SearchAsync(HouseFilter filter, PagedRequest pagination,
            OrderedRequest ordering) =>
            await filter.Filter(m_context.Houses.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(House.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);
    }
}