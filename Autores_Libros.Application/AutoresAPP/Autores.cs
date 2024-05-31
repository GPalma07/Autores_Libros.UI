using Autores_Libros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autores_Libros.Application.AutoresAPP
{
    public class Autores : IAutores
    {
        public Task<ApiRespuesta<bool>> ActualizarAutorAPP(Autore autore)
        {
            throw new NotImplementedException();
        }

        public Task<ApiRespuesta<bool>> AdicionarAutorAPP(Autore autore)
        {
            throw new NotImplementedException();
        }

        public Task<ApiRespuesta<IEnumerable<Autore>>> ObtenerAutoresAPP()
        {
            throw new NotImplementedException();
        }
    }
}
