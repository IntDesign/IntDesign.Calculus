using System;
using Calculus.Core.Models.MainModels;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.SecondaryModels
{
    public class Material : IIdentifier
    {
        public Guid Id { get; set; }
        public string MaterialName { get; set; }
        public Guid RoomJobId { get; set; }
        public RoomJob RoomJob { get; set; }
        public MaterialInformation MaterialInformation { get; set; } = null;
        public MaterialExpenditure MaterialExpenditure { get; set; } = null;
    }
}