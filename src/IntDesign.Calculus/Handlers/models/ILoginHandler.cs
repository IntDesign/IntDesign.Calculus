using System.Threading.Tasks;
using Calculus.Core.Requests.Login;

namespace Calculus.Handlers.models
{
    public interface ILoginHandler
    {
        Task<LoginResponse> ProcessRequest(LoginRequest request);
    }
}