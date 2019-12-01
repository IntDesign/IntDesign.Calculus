using System;
using System.Collections.Generic;
using Calculus.Core.Enums;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class Room : IIdentifier
    {
        public Guid Id { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Pc { get; set; }
        public double Atv { get; set; }
        public double Asp { get; set; }
        public double EmptyAsp { get; set; }
        public double? Afm { get; set; }
        public double? SpecialAfm { get; set; }
        public double? CustomLenght { get; set; }
        public double? CustomWidth { get; set; }
        public double? CustomHeightOne { get; set; }
        public double? CustomHeightTwo { get; set; }
        
        public double? WallRealCoefficient { get; set; }
        
        public double? TilesParquetCoefficient { get; set; }
        
        public double? SpecialTilesParquetCoefficient { get; set; }
        public RoomType Type { get; set; }
        public Guid HouseId { get; set; }
        public House House { get; set; }
        public List<RoomJob> RoomJobs { get; set; }
        public List<RoomWallObject> RoomObjects { get; set; }
    }
}