using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IMaterialExpenditureRepository
    {
        Task<MaterialExpenditure> AddMaterialExpenditure(MaterialExpenditure expenditure);
        
        Task<MaterialExpenditure> UpdateMaterialExpenditureValues(Guid id);
        Task<MaterialExpenditure> RemoveMaterialExpenditure(Guid id);

        Task<Tuple<int, List<MaterialExpenditure>>> SearchAsync(MaterialExpenditureFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}