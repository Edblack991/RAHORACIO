using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MachinLocal.Models
{
    public class Servicio
    {
        [Key]
        public int ServicioID { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el nombre del servicio")]
        [StringLength(50, ErrorMessage = "Solo se pueden introducior 50 caracteres")]
        public String NombreServicio { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la descripcion")]
        [StringLength(100, ErrorMessage = "Solo se pueden introducior 100 caracteres")]
        public String Descripcion { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el Costo")]
        public int Costo { get; set; }
    }
}