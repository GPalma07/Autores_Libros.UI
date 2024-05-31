using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autores_Libros.UI
{
    public class Autore
    {
        [Required(ErrorMessage = "Campo es requerido")]
        public int IdAutor { get; set; }
        [Required(ErrorMessage = "Campo es requerido")]
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }

        [Required(ErrorMessage = "Campo es requerido")]
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }

        [Required(ErrorMessage = "Campo es requerido")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo es requerido")]
        public string CiudadNacimiento { get; set; } = null!;

        [EmailAddress(ErrorMessage ="Ingrese un formato válido")]
        public string? Correo { get; set; }
    }
}
