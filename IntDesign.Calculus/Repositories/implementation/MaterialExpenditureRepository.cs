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
    public class MaterialExpenditureRepository : IMaterialExpenditureRepository
    {
        private readonly MainContext m_context;
        public MaterialExpenditureRepository(MainContext context) => m_context = context;

        public async Task<MaterialExpenditure> AddMaterialExpenditure(MaterialExpenditure expenditure)
        {
            expenditure.Id = Guid.NewGuid();
            await m_context.AddAsync(expenditure);
            await m_context.SaveChangesAsync();
            await UpdateMaterialExpenditureValues(expenditure.Id);
            return expenditure;
        }

        public async Task<MaterialExpenditure> UpdateMaterialExpenditureValues(Guid id)
        {
            var expenditure = await m_context.MaterialExpenditures
                .Include(t => t.MaterialInformation)
                .ThenInclude(t => t.Material)
                .ThenInclude(t => t.RoomJob)
                .ThenInclude(t => t.Room)
                .Where(t => t.Id == id).FirstOrDefaultAsync();
            SetExpenditureValues(expenditure);
            m_context.MaterialExpenditures.Update(expenditure);
            await m_context.SaveChangesAsync();
            return expenditure;
        }

        public async Task<MaterialExpenditure> RemoveMaterialExpenditure(Guid id)
        {
            var expenditure = await m_context.MaterialExpenditures.Where(t => t.Id == id).FirstOrDefaultAsync();
            m_context.Remove(expenditure);
            await m_context.SaveChangesAsync();
            return expenditure;
        }

        public async Task<Tuple<int, List<MaterialExpenditure>>> SearchAsync(MaterialExpenditureFilter filter,
            PagedRequest pagination, OrderedRequest ordering) =>
            await filter.Filter(m_context.MaterialExpenditures.AsQueryable())
                .WithOrdering(ordering, new OrderedRequest
                {
                    OrderBy = nameof(MaterialExpenditure.Id),
                    OrderDirection = OrderDirection.Asc
                })
                .WithPaginationAsync(pagination);

        private static void SetExpenditureValues(MaterialExpenditure expenditure)
        {
            expenditure.TotalPrice =
                (expenditure.MaterialInformation.Material.RoomJob.Room.WallRealCoefficient +
                 expenditure.MaterialInformation.Material.RoomJob.Room.Atv) /
                expenditure.MaterialInformation.UnitCover *
                expenditure.MaterialInformation.PricePerUnit
                * expenditure.MaterialInformation.AppliedLayers;
            //todo: add coefficient to db
            expenditure.TotalPrice += 0.1F * expenditure.TotalPrice;
            expenditure.TotalQuantity = expenditure.TotalPrice * expenditure.MaterialInformation.ProductQuantity /
                                        expenditure.MaterialInformation.PricePerUnit;
            expenditure.TotalPackets = expenditure.TotalQuantity / expenditure.MaterialInformation.ProductQuantity;
        }
    }
}