using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la placa del numero")]
        public int PlacaNumero { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la fecha")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el id de la sucursal")]
        [ForeignKey("Sucursal")]
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }

    }
}