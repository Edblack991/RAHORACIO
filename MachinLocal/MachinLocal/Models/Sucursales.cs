using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class Sucursales
    {
        [Key]
        public int SucursalId { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el nombre")]
        [StringLength(50, ErrorMessage = "Solo se pueden introducior 50 caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la direccion")]
        [StringLength(100, ErrorMessage = "Solo se pueden introducior 100 caracteres")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el telefono")]
        [StringLength(20, ErrorMessage = "Solo se pueden introducior 20 caracteres")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el encargado")]
        [StringLength(50, ErrorMessage = "Solo se pueden introducior 50 caracteres")]
        public String Encargado { get; set; }

        public virtual ICollection<Citas> Citas { get; set; }
    }
}