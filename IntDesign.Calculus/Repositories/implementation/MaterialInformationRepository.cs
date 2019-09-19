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
    public class MaterialInformationRepository : IMaterialInformationRepository
    {
        private readonly MainContext m_context;

        public MaterialInformationRepository(MainContext context) => m_context = context;

        public async Task<MaterialInformation> AddMaterialInfo(MaterialInformation materialnfo)
        {
            materialnfo.Id = Guid.NewGuid();
            materialnfo.UnitCover = materialnfo.ConsumptionZ * materialnfo.ProductQuantity / materialnfo.ConsumptionX;
            await m_context.MaterialInformation.AddAsync(materialnfo);
            await m_context.SaveChangesAsync();
            return materialnfo;
        }

        public async Task<MaterialInformation> RemoveMaterial(Guid materialInfoId)
        {
            var info = await m_context.MaterialInformation.Where(t => t.Id == materialInfoId).FirstOrDefaultAsync();
            m_context.MaterialInformation.Remove(info);
            await m_context.SaveChangesAsync();
            return info;
        }

        public async Task<Tuple<int, List<MaterialInformation>>> SearchAsync(MaterialInformationFilter filter,
            PagedRequest pagination, OrderedRequest ordering) =>
            await filter.Filter(m_context.MaterialInformation.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(MaterialInformation.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);
    }
}