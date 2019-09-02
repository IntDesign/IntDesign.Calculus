using System;
using System.Collections.Generic;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MaterialModels;

namespace Calculus.Core.Models.JobModels
{
    public class RoomJob : IIdentifier
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public List<Material> Materials { get; set; }
        public Room Room { get; set; }
    }
}