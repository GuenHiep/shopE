using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopE.Models;

namespace shopE.Data
{
    public class shopEContext : DbContext
    {
        public shopEContext (DbContextOptions<shopEContext> options)
            : base(options)
        {
        }

        public DbSet<shopE.Models.Category> Category { get; set; } = default!;
        public DbSet<shopE.Models.Product> Product { get; set; } = default!;
        public DbSet<shopE.Models.User> User { get; set; } = default!;
    }
}
