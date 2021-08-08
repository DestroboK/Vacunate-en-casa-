// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea9_Form_Vacunate.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/form")]
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\Kelvin\Desktop\Tarea9\Vacunate-en-casa-\Client\Pages\Form.razor"
       
    Tarea9_Form_Vacunate.Shared.Solicitud nuevoForm = new Tarea9_Form_Vacunate.Shared.Solicitud();

    List<Solicitud> solicitudes = new List<Solicitud>();

    string advertencia;

    protected override async Task OnInitializedAsync() {

        solicitudes = await SolicitudService.GetSolicitudes();
    }


    async void CreateNewSolicitud()
    {
        foreach(Solicitud soli in solicitudes)
        {
            if(soli.cedula == nuevoForm.cedula && soli.nombre == nuevoForm.nombre && soli.email == nuevoForm.email && soli.apellido == nuevoForm.apellido)
            {
                advertencia = "Usted ya ha llenado este formulario.";
            }
            else {
                await SolicitudService.CrearSolicitud(nuevoForm);
                SendLocalEmail(nuevoForm.email, "Resumen de datos", "<h3>" + "Nombre: " + nuevoForm.nombre + ", Apellido: " + nuevoForm.apellido + ", Direccion: " + nuevoForm.direccion + ",Telefono: " + nuevoForm.telefono + ", Cedula: " + nuevoForm.cedula + ", Fecha de nacimiento: " + nuevoForm.FechaNac.ToShortDateString() + ", Latitud: " + nuevoForm.latitud + ", Longitud: " + nuevoForm.longitud + ", Tipo de sangre: " + nuevoForm.tipo_sangre + ", Provincia: " + nuevoForm.provincia + ", Direccion: " + nuevoForm.direccion + ", Justificacion: " + nuevoForm.justificacion + "</h3>");
                Console.WriteLine("Formulario envidado correctamente");
            }
        }

    }
    protected void SendLocalEmail(string toEmailAddress, string subject, string body)
    {
        JsRuntime.InvokeAsync<object>("blazorExtensions.SendLocalEmail",
        new object[] { toEmailAddress, subject, body });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISolicitudService SolicitudService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
