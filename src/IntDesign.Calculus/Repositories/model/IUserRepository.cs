using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;

namespace Calculus.Repositories.model
{
    public interface IUserRepository
    {
        Task<User> AddUser(User user);
        Task<User> RemoveUser(Guid id);

        Task<Tuple<int, List<User>>> SearchAsync(UserFilter filter, PagedRequest pagination,
            OrderedRequest ordering);
    }
}