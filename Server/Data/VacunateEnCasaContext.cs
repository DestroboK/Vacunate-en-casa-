using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea9_Form_Vacunate.Shared;


namespace Tarea9_Form_Vacunate.Server.Data
{
    public class VacunateEnCasaContext:DbContext
    {
        public VacunateEnCasaContext(DbContextOptions<VacunateEnCasaContext> options): base(options)
        {
        }

        public DbSet<Solicitud> Solicitudes { get; set; }

       
    }
}
