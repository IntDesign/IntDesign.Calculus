using System;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.MainModels
{
    public class RoomWallObject : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public RoomObjectType Type { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }

        public int Number { get; set; }
        public Room Room { get; set; }
    }
}