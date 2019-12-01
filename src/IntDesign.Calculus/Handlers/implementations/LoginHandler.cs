using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Calculus.Context;
using Calculus.Core.Requests.Login;
using Calculus.Handlers.models;
using Microsoft.EntityFrameworkCore;

namespace Calculus.Handlers.implementations
{
    public class LoginHandler : ILoginHandler
    {
        private DataContext m_DataContext;

        public LoginHandler(DataContext dataContext)
        {
            m_DataContext = dataContext;
        }

        public async Task<LoginResponse> ProcessRequest(LoginRequest request)
        {
            var user = await m_DataContext.Users.FirstOrDefaultAsync(t =>
                t.Username == request.Account || t.Email == request.Account);
            return user == null || user.Password != ComputeSha(request.Password)
                ? new LoginResponse
                {
                    Error =
                        "Could not connect. Make sure you are connected to the internet and your credentials are correct",
                    IsSuccessful = false,
                    UserId = null
                }
                : new LoginResponse
                {
                    Error = "",
                    IsSuccessful = true,
                    UserId = user.Id
                };
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
    }
}