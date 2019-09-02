using System;
using System.Collections.Generic;
using Calculus.Core.Models.GraphQl.filters;

namespace Calculus.Core.Models.JobModels
{
    public class House : IIdentifier
    {
        public Guid Id { get; set; }
        public string HouseAddress { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public List<Room> HouseRooms { get; set; }
    }
}