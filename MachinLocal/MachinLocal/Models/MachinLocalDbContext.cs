using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class MachinLocalDbContext : DbContext
    {
        public MachinLocalDbContext() : base("MachinLocalDbContext")
        {
            Database.SetInitializer<MachinLocalDbContext>(new MachinLocalDbInitializer());
        }

        public DbSet<Servicio> Servicios { get; set; }

        public DbSet<Cita> Citas { get; set; }

        public DbSet<Sucursal> Sucursals { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}