using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vego.Model
{
    public class VegoDbContext:DbContext
    {

        public DbSet<Make> Makes { get; set; }
        public VegoDbContext(DbContextOptions<VegoDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
