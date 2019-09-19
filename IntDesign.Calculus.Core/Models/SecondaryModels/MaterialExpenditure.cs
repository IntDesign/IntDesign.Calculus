using System;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class MaterialExpenditure : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid MaterialInformationId { get; set; }
        public double? TotalPrice { get; set; }
        public double? TotalQuantity { get; set; }
        public double? TotalPackets { get; set; }
        public MaterialInformation MaterialInformation { get; set; }
    }
}