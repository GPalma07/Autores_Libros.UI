using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace Autores_Libros.UI.Controllers
{
    public class AutoresController : Controller
    {
        public Autore AutorModel { get; set; }
        public List<Autore> ListaAutoresModel { get; set; }
        public string TipoAccion { get; set; }
        private readonly HttpClient _httpClient;
        public AutoresController(HttpClient httpClient)
        {
            AutorModel = new();
            TipoAccion = "Grid";
            _httpClient = httpClient;
            ListaAutoresModel = new();
        }

        public async Task CargarAutores()
        {
            try
            {
                TipoAccion = "Cargando";
                //StringContent content = new(JsonSerializer.Serialize(requestPokemon), Encoding.UTF8, "application/json");
                //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
                var respuesta = await _httpClient.GetAsync($"{_httpClient.BaseAddress}v1/Autores");

                if (!respuesta.IsSuccessStatusCode)
                {

                }

                ApiRespuesta<IEnumerable<Autore>> responseClient = await respuesta.Content.ReadFromJsonAsync<ApiRespuesta<IEnumerable<Autore>>>();

                if (responseClient is null)
                {

                }
                
                ListaAutoresModel =  responseClient.Model.ToList();
                TipoAccion = "GridAutores";
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task CargarComponenteNuevoAutor()
        {

        }

        public async Task CargarComponenteEditarUsuario(int idAutor)
        {

        }
    }
}
