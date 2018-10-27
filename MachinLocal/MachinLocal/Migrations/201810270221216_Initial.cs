namespace MachinLocal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cita",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        PlacaNumero = c.Int(nullable: false),
                        FechaCita = c.DateTime(nullable: false, precision: 0),
                        SucursalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Sucursal", t => t.SucursalId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.SucursalId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Apellidos = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 200, unicode: false, storeType: "nvarchar"),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Sucursal",
                c => new
                    {
                        SucursalId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Encargado = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.SucursalId);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        ServicioID = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Costo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cita", "SucursalId", "dbo.Sucursal");
            DropForeignKey("dbo.Cita", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Cita", new[] { "SucursalId" });
            DropIndex("dbo.Cita", new[] { "ClienteId" });
            DropTable("dbo.Servicio");
            DropTable("dbo.Sucursal");
            DropTable("dbo.Cliente");
            DropTable("dbo.Cita");
        }
    }
}
