using System;
using System.Collections.Generic;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.MainModels
{
    public class Room : IIdentifier
    {
        public Guid Id { get; set; }
        public float Lenght { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Pc { get; set; }
        public float Atv { get; set; }
        public float Asp { get; set; }
        public float EmptyAsp { get; set; }
        public float? Afm { get; set; }
        public float? SpecialAfm { get; set; }
        public float? CustomLenght { get; set; }
        public float? CustomWidth { get; set; }
        public float? CustomHeightOne { get; set; }
        public float? CustomHeightTwo { get; set; }
        
        public float? WallRealCoefficient { get; set; }
        
        public float? TilesParquetCoefficient { get; set; }
        
        public float? SpecialTilesParquetCoefficient { get; set; }
        public RoomType Type { get; set; }
        public Guid HouseId { get; set; }
        public House House { get; set; }
        public List<RoomJob> RoomJobs { get; set; }
        public List<RoomWallObject> RoomObjects { get; set; }
    }
}