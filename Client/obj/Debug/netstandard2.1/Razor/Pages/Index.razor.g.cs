#pragma checksum "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d8f12bb4ac262c7a91e5dd5e6406e5ae58ae34a"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea9_Form_Vacunate.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\_Imports.razor"
using Tarea9_Form_Vacunate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\Pages\Index.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\Pages\Index.razor"
                                          SendMail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Enviar correo");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "style", "font-weight:bold;font-size:28px;color:#c00;");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\Pages\Index.razor"
                                                           Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Vacunate-en-casa-\Client\Pages\Index.razor"
      
    private string Message { get; set; } = "";
    private void SendMail()
    {
        try
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("bryanlorenzo18mcfa5a@gmail.com");
                mail.To.Add("dariellorenzo89@gmail.com");
                mail.Subject = "Sending Mail Testing (Blazor)";
                mail.Body = "<h1>This is mail body</h1>";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("bryanlorenzo18mcfa5a@gmail.com", "Rain1234");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Message = "Mail Sent";
                }
            }
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
