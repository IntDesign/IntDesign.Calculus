using System;
using System.Collections.Generic;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class Provider : IIdentifier
    {
        public Guid Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderEmail { get; set; }
        public string ProviderPhone { get; set; }
        public List<MaterialInformation> MaterialInformations { get; set; }
    }
}