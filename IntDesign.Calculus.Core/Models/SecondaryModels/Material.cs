using System;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class Material : IIdentifier
    {
        public Guid Id { get; set; }

        public string MaterialName { get; set; }
        
        public MaterialType Type { get; set; }
        
        public float PricePerPacket { get; set; }
        
        public Provider Provider { get; set; }

        public MaterialInformation MaterialInformation { get; set; } = null;

        public MaterialExpenditure MaterialExpenditure { get; set; } = null;
    }
}