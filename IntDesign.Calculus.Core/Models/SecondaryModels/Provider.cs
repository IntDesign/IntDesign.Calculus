using System;
using System.Collections.Generic;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
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