using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.SecondaryModels;

namespace Calculus.Repositories.model
{
    public interface IMaterialExpenditureRepository
    {
        Task<MaterialExpenditure> AddMaterialExpenditure(MaterialExpenditure expenditure);
        
        Task<MaterialExpenditure> UpdateMaterialExpenditureValues(Guid id);
        Task<MaterialExpenditure> RemoveHouse(Guid id);

        Task<Tuple<int, List<MaterialExpenditure>>> SearchAsync(MaterialExpenditureFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}