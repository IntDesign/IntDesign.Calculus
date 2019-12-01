using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

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