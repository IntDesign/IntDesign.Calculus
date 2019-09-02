using System;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.GraphQl.filters;

namespace Calculus.Core.Models.MaterialModels
{
    public class Material : IIdentifier
    {
        public Guid Id { get; set; }

        public string MaterialName { get; set; }
        
        public MaterialType MaterialType { get; set; }
        
        public float PricePerPacket { get; set; }
        
        public Provider Provider { get; set; }

        public MaterialInformation MaterialInformation { get; set; } = null;

        public MaterialExpenditure MaterialExpenditure { get; set; } = null;
    }
}