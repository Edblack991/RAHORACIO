using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class MachinLocalDbContext : DbContext
    {
        public MachinLocalDbContext() : base("MachinLocalDbContext")
        {

        }

        public DbSet<Servicios> Servicios { get; set; }

        public DbSet<Citas> Citas { get; set; }

        public DbSet<Sucursales> Sucursales { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}