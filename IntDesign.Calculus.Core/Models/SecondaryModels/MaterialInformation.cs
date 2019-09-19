using System;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class MaterialInformation : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }
        public double AppliedLayers { get; set; }
        public double ConsumptionX { get; set; }
        public double ConsumptionZ { get; set; }
        public double UnitCover { get; set; }
        public Guid ProviderId { get; set; }
        public Material Material { get; set; }
        public Provider Provider { get; set; }
    }
}