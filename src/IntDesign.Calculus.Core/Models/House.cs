using System;
using System.Collections.Generic;
using Calculus.Core.Tools;

namespace Calculus.Core.Models
{
    public class House : IIdentifier
    {
        public Guid Id { get; set; }
        public string HouseAddress { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public List<Room> HouseRooms { get; set; }
        
        public Guid UserId { get; set; }
        
        public User User { get; set; }
    }
}