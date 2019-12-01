using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Context.extensions;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.Repositories.model;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Repositories.implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext m_context;

        public UserRepository(DataContext context)
        {
            m_context = context;
        }

        public async Task<User> AddUser(User user)
        {
            user.Id = Guid.NewGuid();
            user.Password = ComputeSha(user.Password);
            await m_context.Users.AddAsync(user);
            await m_context.SaveChangesAsync();
            return user;
        }

        public async Task<User> RemoveUser(Guid id)
        {
            var user = await m_context.Users.FirstOrDefaultAsync(t => t.Id == id);
            m_context.Users.Remove(user);
            await m_context.SaveChangesAsync();
            return user;
        }

        private static string ComputeSha(string value)
        {
            using (var sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));
                var builder = new StringBuilder();
                
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public async Task<Tuple<int, List<User>>> SearchAsync(UserFilter filter, PagedRequest pagination,
            OrderedRequest ordering)
            =>
                await filter.Filter(m_context.Users.AsQueryable())
                    .WithOrdering(ordering, new OrderedRequest
                    {
                        OrderBy = nameof(User.Id),
                        OrderDirection = OrderDirection.Asc
                    })
                    .WithPaginationAsync(pagination);
    }
}