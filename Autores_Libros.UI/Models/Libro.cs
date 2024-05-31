using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autores_Libros.UI
{
    public class Libro
    {
        [Required(ErrorMessage = "Campo es requerido")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "Campo es requerido")]
        public int Año { get; set; }

        [Required(ErrorMessage = "Campo es requerido")]
        public string Género { get; set; } = null!;

        public int NumeroPaginas { get; set; }

        [Required(ErrorMessage = "Campo es requerido")]
        public int IdAutor { get; set; }
    }
}
