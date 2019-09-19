using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.SecondaryModels;
using Calculus.Repositories.model;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementation
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly MainContext m_context;

        public MaterialRepository(MainContext context) => m_context = context;

        public async Task<Material> AddMaterial(Material material)
        {
            material.Id = Guid.NewGuid();
            await m_context.Materials.AddAsync(material);
            await m_context.SaveChangesAsync();
            return material;
        }

        public async Task<Material> RemoveMaterial(Guid materialId)
        {
            var material = await m_context.Materials.Where(t => t.Id == materialId).FirstOrDefaultAsync();
            m_context.Materials.Remove(material);
            await m_context.SaveChangesAsync();
            return material;
        }

        public async Task<Tuple<int, List<Material>>> SearchAsync(MaterialFilter filter, PagedRequest pagination,
            OrderedRequest ordering) =>
            await filter.Filter(m_context.Materials.AsQueryable())
                .WithOrdering(
                    ordering,
                    new OrderedRequest
                    {
                        OrderBy = nameof(Material.Id),
                        OrderDirection = OrderDirection.Asc
                    })
                .WithPaginationAsync(pagination);
    }
}