using System;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class MaterialExpenditure : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid MaterialId { get; set; }
        public float TotalPrice { get; set; }
        public float TotalKilograms { get; set; }
        public float TotalPackets { get; set; }
        public Material Material { get; set; }
    }
}