using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kundeApp1.Models
{
    public class KundeContext : DbContext
    {
        public KundeContext(DbContextOptions<KundeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Kunde> Kunder { get; set; }
    }
}
