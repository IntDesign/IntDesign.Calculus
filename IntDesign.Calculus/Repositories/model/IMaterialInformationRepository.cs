using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.SecondaryModels;

namespace Calculus.Repositories.model
{
    public interface IMaterialInformationRepository
    {
        Task<MaterialInformation> AddMaterialInfo(MaterialInformation materialnfo);
        Task<MaterialInformation> RemoveMaterial(Guid materialInfoId);

        Task<Tuple<int, List<MaterialInformation>>> SearchAsync(MaterialInformationFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}