using System;
using System.Collections.Generic;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class User : IIdentifier
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsWorker { get; set; }
        public List<House> Houses { get; set; }
    }
}