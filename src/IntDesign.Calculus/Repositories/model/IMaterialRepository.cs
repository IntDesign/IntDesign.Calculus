using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IMaterialRepository
    {
        Task<Material> AddMaterial(Material material);
        Task<Material> RemoveMaterial(Guid materialId);

        Task<Tuple<int, List<Material>>> SearchAsync(MaterialFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}