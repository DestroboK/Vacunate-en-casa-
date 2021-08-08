using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea9_Form_Vacunate.Server.Data;
using Tarea9_Form_Vacunate.Shared;
using Microsoft.EntityFrameworkCore;
namespace Tarea9_Form_Vacunate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly VacunateEnCasaContext context;

        public SolicitudController(VacunateEnCasaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Solicitud>>> GetSolicitudes()
        {
            return Ok(context.Solicitudes) ;
        }
        [HttpPost]
        public async Task<IActionResult> CrearSolicitud(Solicitud request)
        {
            context.Add(request);
            context.SaveChanges();
            return Ok(context.Solicitudes);

 
        }
    }
}
