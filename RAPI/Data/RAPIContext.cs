using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAPI.Models;

namespace RAPI.Data
{
    public class RAPIContext : DbContext
    {
        public RAPIContext (DbContextOptions<RAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
