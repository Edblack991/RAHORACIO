using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MachinLocal.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Es necesario introducir el nombre")]
        [StringLength(50,ErrorMessage = "Solo se pueden introducior 50 caractere")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario introducir los apellidos")]
        [StringLength(100, ErrorMessage = "Solo se pueden introducior 100 caracteres")]
        public String Apellidos { get; set; }

        [Required(ErrorMessage = "Es necesario introducir la direccion")]
        [StringLength(200, ErrorMessage = "Solo se pueden introducior 200 caracteres")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el telefono")]
        [StringLength(20, ErrorMessage = "Solo se pueden introducior 20 caracteres")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "Es necesario introducir el email")]
        [StringLength(20, ErrorMessage = "Solo se pueden introducior 20 caracteres")]
        public String Email { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }

    }
}