using Autores_Libros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autores_Libros.Application.AutoresAPP
{
    public interface IAutores
    {
        public Task<ApiRespuesta<IEnumerable<Autore>>> ObtenerAutoresAPP();
        public Task<ApiRespuesta<bool>> AdicionarAutorAPP(Autore autore);
        public Task<ApiRespuesta<bool>> ActualizarAutorAPP(Autore autore);
    }
}
