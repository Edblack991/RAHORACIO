using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }

        [ForeignKey("Clientes")]
        [Required(ErrorMessage = "Es necesario introducir el id de cliente")]
        [StringLength(10, ErrorMessage = "Solo se pueden introducior 10 caracteres")]
        public int ClienteId { get; set; }
        public Clientes Clientes { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la placa del numero")]
        [StringLength(10, ErrorMessage = "Solo se pueden introducior 10 caracteres")]
        public int PlacaNumero { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la fecha")]
        [StringLength(8, ErrorMessage = "Solo se pueden introducior 8 caracteres")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el id de la sucursal")]
        [StringLength(10, ErrorMessage = "Solo se pueden introducior 10 caracteres")]
        [ForeignKey("Sucursales")]
        public int SucursalId { get; set; }
        public Sucursales Sucursales { get; set; }

    }
}