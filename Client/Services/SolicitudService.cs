using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9_Form_Vacunate.Shared;
using System.Net.Http;
using System.Net.Http.Json;
namespace Tarea9_Form_Vacunate.Client.Services
{
    public class SolicitudService : ISolicitudService
    {
        private readonly HttpClient _http;

        public SolicitudService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Solicitud>> GetSolicitudes()
        {
            return await _http.GetFromJsonAsync<List<Solicitud>>("api/solicitud");
        }
        public async Task<List<Solicitud>> CrearSolicitud(Solicitud request)
        {

            var result = await  _http.PostAsJsonAsync<Solicitud>($"api/solicitud", request);
            var solicitues = await result.Content.ReadFromJsonAsync<List<Solicitud>>();
            return solicitues;
        }

    }
}
