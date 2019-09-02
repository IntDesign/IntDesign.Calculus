using System;
using Calculus.Core.Models.GraphQl.filters;

namespace Calculus.Core.Models.MaterialModels
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