using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculus.Context;
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
            return expenditure;
        }

        public async Task<MaterialExpenditure> UpdateMaterialExpenditureValues(Guid id)
        {
            var expenditure = await m_context.MaterialExpenditures.Where(t => t.Id == id).FirstOrDefaultAsync();
            SetExpenditureValues(expenditure);
            m_context.MaterialExpenditures.Update(expenditure);
            return expenditure;
        }

        public async Task<MaterialExpenditure> RemoveHouse(Guid id)
        {
            var expenditure = await m_context.MaterialExpenditures.Where(t => t.Id == id).FirstOrDefaultAsync();
            m_context.Remove(expenditure);
            await m_context.SaveChangesAsync();
            return expenditure;
        }

        public Task<Tuple<int, List<MaterialExpenditure>>> SearchAsync(MaterialExpenditureFilter filter,
            PagedRequest pagination, OrderedRequest ordering)
        {
            throw new NotImplementedException();
        }

        private void SetExpenditureValues(MaterialExpenditure expenditure)
        {
            m_context.MaterialExpenditures.Include(t => t.Material)
                .ThenInclude(t => t.MaterialInformation);
        }
    }
}