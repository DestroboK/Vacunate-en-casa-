using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Tarea9_Form_Vacunate.Shared
{
    public class Solicitud
    {
        [Key]
        public int id { get; set; }

        [Required, StringLength(20, ErrorMessage = "Cedula invalida")]
        [MaxLength(length: 11)]
        public string cedula { get; set; }

        [Required(ErrorMessage = "Nombre invalido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Apellido invalido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Falta el telefono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Email invalido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Falta la fecha de nacimiento")]
        public DateTime FechaNac { get; set; }

        [Required]
        public string tipo_sangre { get; set; }

        [Required]
        public string provincia { get; set; }

        [Required(ErrorMessage = "Falta la direccion del hecho.")]
        public string direccion { get; set; }

        public double latitud { get; set; }

        public double longitud { get; set; }

        public bool covid { get; set; }
        [Required(ErrorMessage = "Justifique porque debemos vacunarlo en su casa")]
        public string justificacion { get; set; }

    }
}
