using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankTracker3.Models
{
    public class FishTank
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SizeInGallons { get; set; }
        public int? SizeInLiters { get; set; }
    }
}
