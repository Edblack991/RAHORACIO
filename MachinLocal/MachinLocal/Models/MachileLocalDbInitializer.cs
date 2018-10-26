using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class MachileLocalDbInitializer : DropCreateDataBaseIfModelChanges<MachinLocalDbContext>

    {
        protected override void Seed(MachinLocalDbContext context)
        { 

            context.DataBase.Log = Console.Write;
            using (DbContextTransaction dbTran = context.DataBase.BeginTransaction())
             
            {
                try
                {
                    List<Clientes> clientes = new List<Clientes>();

                    clientes.add(new Clientes()
                    {
                        Nombre = "Alejandro",
                        Apellidos = "Cruz Sanchez",
                        Direccion = "Escobedo, Col. Emiliano zapata, Azucena #234",
                        Telefono = 8117428122,
                        Email = "Alex_28@gmail.com",
                        EnrollmentDate = DateTime.Now
                    });
                    clientes.add(new Clientes()
                    {
                        Nombre = "Pedro",
                        Apellidos = "Armando Lopez",
                        Direccion = "Cienega, Col. portal de las salinas, vivero del rocio #105",
                        Telefono = 8112457874,
                        Email = "molkas291@gmail.com",
                        EnrollmentDate = DateTime.Now
                    });
                    clientes.add(new Clientes()
                    {
                        Nombre = "Jonathan",
                        Apellidos = "Cruz Sanchez",
                        Direccion = "Escobedo, Col. jardines, Pablo A. de la garza #247",
                        Telefono = 8117842694,
                        Email = "JonaDrow23@gmail.com",
                        EnrollmentDate = DateTime.Now
                    });

                    Context.Clientes.AddRange(clientes);
                    context.SaveChanges();

                    List<Servicios> servicios = new List<Servicios>();

                    servicios.Add(new Servicios()
                    {
                        NombreServicio = "frenos",
                        Descripcion = "Cuando se  desgasta se deben sustituir los discos y las pastillas de freno.",
                        Costo = 1200
                    });
                    servicios.Add(new Servicios()
                    {
                        NombreServicio = "alineacion y balanceo",
                        Descripcion = "se ajustan las llantas de un vehículo para que miren hacia el frente y  se ajustan los pesos de una llanta y su rin para mantener un equilibrio correcto entre ambos",
                        Costo = 600
                    });
                    servicios.Add(new Servicios()
                    {
                        NombreServicio = "carburador",
                        Descripcion = "limpieza profunda del carburador.",
                        Costo = 700
                    });

                    context.Servicios.AddRange(servicios);
                    context.SaveChanges();

                    List<Sucursales> sucursales = new List<Sucursales>();

                    sucursales.Add(new Sucursales()
                    {
                        Nombre = "Diaz",
                        Direccion = "Monterrey, Res. Abraham lincoln, Ruiz Cortinez #4053",
                        Telefono = 83719559,
                        Encargado = "julio lopez"
                    });
                    sucursales.Add(new Sucursales()
                    {
                        Nombre = "Mave",
                        Direccion = " Mariano Matamoros #240",
                        Telefono = 83404418,
                        Encargado = "Rolando Alvarez"
                    });
                    sucursales.Add(new Sucursales()
                    {
                        Nombre = "Mave",
                        Direccion = "Mitras centro, Av Ruiz Cortinez #2626",
                        Telefono = 8113578949,
                        Encargado = "julio lopez"
                    });

                    context.Sucursales.AddRange(sucursales);
                    context.SaveChanges();

                    dbtran.Commit(); //ejecutar cambios
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
