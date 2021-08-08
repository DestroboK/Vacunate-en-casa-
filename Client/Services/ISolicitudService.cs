using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9_Form_Vacunate.Shared;
namespace Tarea9_Form_Vacunate.Client.Services
{
    public interface ISolicitudService
    {
        Task<List<Solicitud>> GetSolicitudes();
        Task<List<Solicitud>> CrearSolicitud(Solicitud request);
    }
}
