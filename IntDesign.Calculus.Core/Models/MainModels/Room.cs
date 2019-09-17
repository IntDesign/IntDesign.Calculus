using System;
using System.Collections.Generic;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.MainModels
{
    public class Room : IIdentifier
    {
        public Guid Id { get; set; }
        public float Lenght { get; set; }
        public float Pc { get; set; }
        public float Atv { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Asp { get; set; }
        public float EmptyAsp { get; set; }
        public float Afm { get; set; }
        public float SpecialAfm { get; set; }
        public Guid HouseId { get; set; }
        public House House { get; set; }
        public RoomJob RoomJob { get; set; }
        public List<RoomWallObject> RoomObjects { get; set; }
    }
}