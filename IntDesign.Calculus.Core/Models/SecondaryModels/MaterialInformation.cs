using System;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class MaterialInformation : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }
        public float AppliedLayers { get; set; }
        public float ConsumptionX { get; set; }
        public float ComsumptionZ { get; set; }
        public float UnitCover { get; set; }
        public Material Material { get; set; }
    }
}