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
        public float Lenght { get; set; }
        public float Width { get; set; }
        public float Area { get; set; }
        public Room Room { get; set; }
    }
}