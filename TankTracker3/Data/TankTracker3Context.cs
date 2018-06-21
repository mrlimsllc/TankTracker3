using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TankTracker3.Models;

namespace TankTracker3.Data
{
    public class TankTracker3Context : IdentityDbContext
    {
        public TankTracker3Context(DbContextOptions<TankTracker3Context> options)
            : base(options)
        { }

        DbSet<FishTank> FishTanks { get;set; }
    }
}
