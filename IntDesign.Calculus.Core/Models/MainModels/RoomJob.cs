using System;
using System.Collections.Generic;
using Calculus.Core.Models.Enums;
using Calculus.Core.Models.SecondaryModels;
using Calculus.Core.Models.Tools;

namespace Calculus.Core.Models.MainModels
{
    public class RoomJob : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public JobRequestType Type { get; set; }
        public List<Material> Materials { get; set; }
        public Room Room { get; set; }
    }
}