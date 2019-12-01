using System;

namespace Calculus.Core.Requests.Login
{
    public class LoginResponse
    {
        public Guid? UserId { get; set; } = null;
        public bool IsSuccessful { get; set; }
        public string Error { get; set; }
    }
}