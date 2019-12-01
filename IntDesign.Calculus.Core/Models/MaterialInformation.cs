using System;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class MaterialInformation : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }
        public double? AppliedLayers { get; set; }
        public double? ConsumptionX { get; set; } = 1;
        public double? ConsumptionZ { get; set; }
        public double? UnitCover { get; set; }
        public double? ProductQuantity { get; set; }
        public double? PricePerUnit { get; set; }
        public Guid? ProviderId { get; set; }
        public Material Material { get; set; }
        public Provider Provider { get; set; }
        public MaterialExpenditure MaterialExpenditure { get; set; }
    }
}