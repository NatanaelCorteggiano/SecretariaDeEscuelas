#pragma checksum "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\Materias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4328fe6e0b43ed1761adacc59f0ccd1b04b8c2ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materias_Index), @"mvc.1.0.view", @"/Views/Materias/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Materias/Index.cshtml", typeof(AspNetCore.Views_Materias_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\_ViewImports.cshtml"
using SecretariaDeEscuelas;

#line default
#line hidden
#line 2 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\_ViewImports.cshtml"
using SecretariaDeEscuelas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4328fe6e0b43ed1761adacc59f0ccd1b04b8c2ee", @"/Views/Materias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5284ba5c654a810d0111b0b884390dff6b69db0", @"/Views/_ViewImports.cshtml")]
    public class Views_Materias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SecretariaDeEscuelas.Models.Materia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\Materias\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 2476, true);
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr class=""bg-danger"">
            <th style=""text-align:center"">
                Carrera
            </th>
            <th style=""text-align:center"">
                Materia
            </th>
            <th style=""text-align:center"">
                Opciones
            </th>

        </tr>
    </thead>

    <tbody style=""font-size:17px;"">
        <tr class=""bg-info"">
            <td id=""carreras"">
            </td>
            <td id=""materias"">
            </td>

            <td id=""opciones"">
            </td>
        </tr>

    </tbody>
</table>

<div class=""modal fade"" id=""modalMaestros"" tabindex=""-1"" role=""dialog"" aria - labelledby=""exampleModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-di");
            WriteLiteral(@"smiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p id=""maestros""> </p>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""modalEstudiantes"" tabindex=""-1"" role=""dialog"" aria - labelledby=""exampleModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p id=""");
            WriteLiteral(@"estudiantes""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>


<script>

    $(document).ready(function () {



        $.ajax({
            url: '");
            EndContext();
            BeginContext(2577, 38, false);
#line 87 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\Materias\Index.cshtml"
             Write(Url.Action("ListaCarreras","Carreras"));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 2033, true);
            WriteLiteral(@"',
            data: ""{}"",
            success: function (carrera) {
                var carreras;
                var materias;
                var opciones;
                for (var i = 0; i < carrera.length; i++) {
                    for (var j = 0; j < carrera[i].carrerasMaterias.length; j++) {
                        var materia = carrera[i].carrerasMaterias[j].materia;
                        var materiaId = carrera[i].carrerasMaterias[j].materiaId;

                        carreras += '<tr style=""display: flex; justify-content: center;""><td>' + carrera[i].nombre + '</td></tr>';
                        materias += '<tr style=""display: flex; justify-content: center;""><td>' + materia.nombre + '</td></tr>';
                        opciones += '<tr style=""display: flex; justify-content: center;""><td> <div class=""dropdown""><button  class=""btn btn-default btn-xs dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" >   Opciones <span class=""caret""></spa");
            WriteLiteral(@"n> </button>'
                            + '<div class=""dropdown-menu"">'
                            + '<button onclick=""test(' + materiaId + ')"" class=""dropdown-item btn btn-link"" data-toggle=""modal"" data-target=""#modalMaestros"">Maestros</button>'
                            + '<button onclick=""test2(' + materiaId + ')"" class=""dropdown-item btn btn-link"" data-toggle=""modal"" data-target=""#modalEstudiantes"">Estudiantes</button>'
                            + '</div></div></td></tr>';
                        console.log(materia.nombre);
                        console.log(carrera[i].carrerasMaterias[j].materiaId);
                        $(""#carreras"").html(carreras);
                        $(""#materias"").html(materias);
                        $(""#opciones"").html(opciones);
                    }

                }
            }
        });

    });

    function test(id) {
        console.log(id);

        var data = { id: id }
            $.ajax({
                url: '");
            EndContext();
            BeginContext(4649, 34, false);
#line 123 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\Materias\Index.cshtml"
                 Write(Url.Action("Maestros", "Maestros"));

#line default
#line hidden
            EndContext();
            BeginContext(4683, 607, true);
            WriteLiteral(@"',
                data: data,
                contentType: 'application/x-www-form-urlencoded',
                success: function (maestro) {
                    console.log(maestro);
                    if (maestro) {
                        $(""#maestros"").html(maestro.nombre + "" "" + maestro.apellido);
                    }
                    else {
                        console.log(""Error"")
                    }
                }
            });
    }

    function test2(id) {
        console.log(id);

        var data = { id: id }
            $.ajax({
                url: '");
            EndContext();
            BeginContext(5291, 40, false);
#line 143 "C:\Users\natac\OneDrive\Documentos\GitHub\SecretariaDeEscuelas\SecretariaDeEscuelas\Views\Materias\Index.cshtml"
                 Write(Url.Action("Estudiantes", "Estudiantes"));

#line default
#line hidden
            EndContext();
            BeginContext(5331, 511, true);
            WriteLiteral(@"',
                data: data,
                contentType: 'application/x-www-form-urlencoded',
                success: function (estudiante) {
                    console.log(estudiante);
                    if (estudiante) {
                        $(""#estudiantes"").html(estudiante.nombre + "" "" + estudiante.apellido);
                    }
                    else {
                        console.log(""Error"")
                    }
                }
            });
        }

</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SecretariaDeEscuelas.Models.Materia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
