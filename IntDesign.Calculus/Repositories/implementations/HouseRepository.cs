using System;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.models;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementations
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
            m_context.Houses.Remove(await m_context.Houses.Where(t => t.Id == id).FirstOrDefaultAsync());
            return house;
        }

        public async Task<ListResult<House>> SearchAsync(HouseFiltering filtering)
        {
            var query = filtering.Filter(m_context.Houses.AsQueryable());
            var result = await query.ToListAsync();
            return new ListResult<House>
            {
                Items = result,
                TotalCount = result.Count
            };
        }
    }
}