using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class MachinLocalDbInitializer : DropCreateDatabaseIfModelChanges<MachinLocalDbContext>

    {
        protected override void Seed(MachinLocalDbContext context)
        { 
            context.Database.Log = Console.Write;

            using (DbContextTransaction dbTran = context.Database.BeginTransaction())
             
            {
                try
                {
                    List<Cliente> clientes = new List<Cliente>();

                    clientes.Add(new Cliente()
                    {
                        Nombre = "Alejandro",
                        Apellidos = "Cruz Sanchez",
                        Direccion = "Escobedo, Col. Emiliano zapata, Azucena #234",
                        Telefono = "8117428122",
                        Email = "Alex_28@gmail.com"
                    });
                    clientes.Add(new Cliente()
                    {
                        Nombre = "Pedro",
                        Apellidos = "Armando Lopez",
                        Direccion = "Cienega, Col. portal de las salinas, vivero del rocio #105",
                        Telefono = "8112457874",
                        Email = "molkas291@gmail.com"
                    });
                    clientes.Add(new Cliente()
                    {
                        Nombre = "Jonathan",
                        Apellidos = "Cruz Sanchez",
                        Direccion = "Escobedo, Col. jardines, Pablo A. de la garza #247",
                        Telefono = "8117842694",
                        Email = "JonaDrow23@gmail.com",
                    });

                    context.Clientes.AddRange(clientes);
                    context.SaveChanges();

                    List<Servicio> servicios = new List<Servicio>();

                    servicios.Add(new Servicio()
                    {
                        NombreServicio = "frenos",
                        Descripcion = "Cuando se desgasta se deben sustituir los discos y las pastillas de freno.",
                        Costo = 1200
                    });
                    servicios.Add(new Servicio()
                    {
                        NombreServicio = "alineacion y balanceo",
                        Descripcion = "se ajustan las llantas de un vehículo para que miren hacia el frente y  se ajustan los pesos de una llanta y su rin para mantener un equilibrio correcto entre ambos",
                        Costo = 600
                    });
                    servicios.Add(new Servicio()
                    {
                        NombreServicio = "carburador",
                        Descripcion = "limpieza profunda del carburador.",
                        Costo = 700
                    });

                    context.Servicios.AddRange(servicios);
                    context.SaveChanges();

                    List<Sucursal> sucursales = new List<Sucursal>();

                    sucursales.Add(new Sucursal()
                    {
                        Nombre = "Diaz",
                        Direccion = "Monterrey, Res. Abraham lincoln, Ruiz Cortinez #4053",
                        Telefono = "83719559",
                        Encargado = "julio lopez"
                    });
                    sucursales.Add(new Sucursal()
                    {
                        Nombre = "Mave",
                        Direccion = " Mariano Matamoros #240",
                        Telefono = "83404418",
                        Encargado = "Rolando Alvarez"
                    });
                    sucursales.Add(new Sucursal()
                    {
                        Nombre = "Mave",
                        Direccion = "Mitras centro, Av Ruiz Cortinez #2626",
                        Telefono = "8113578949",
                        Encargado = "julio lopez"
                    });

                    context.Sucursals.AddRange(sucursales);
                    context.SaveChanges();

                    dbTran.Commit(); //ejecutar cambios
                }

                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\" Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    dbTran.Rollback(); //descartar cambios
                    throw;
                }

            }
            base.Seed(context);
        }
    }
}
