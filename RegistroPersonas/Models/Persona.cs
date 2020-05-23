using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.Models
{
    public class Persona
    {    [Key]
        public int  IdPersona  { get; set; }
        [Required(ErrorMessage = "Este Campo no puede estar vacio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="Este Campo no puede estar vacio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este Campo no puede estar vacio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este Campo no puede estar vacio")]
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
