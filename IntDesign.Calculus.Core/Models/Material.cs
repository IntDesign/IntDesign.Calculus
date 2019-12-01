using System;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class Material : IIdentifier
    {
        public Guid Id { get; set; }
        public string MaterialName { get; set; }
        public Guid RoomJobId { get; set; }
        public RoomJob RoomJob { get; set; }
        public MaterialInformation MaterialInformation { get; set; } = null;
    }
}