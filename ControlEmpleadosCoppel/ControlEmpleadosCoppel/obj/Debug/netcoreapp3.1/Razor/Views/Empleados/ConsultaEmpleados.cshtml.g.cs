#pragma checksum "C:\Users\javii\Desktop\Software Coppel\ControlNominaCoppel\ControlEmpleadosCoppel\ControlEmpleadosCoppel\Views\Empleados\ConsultaEmpleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9acd249c0278568beb24d4691e3e3910d101ebbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_ConsultaEmpleados), @"mvc.1.0.view", @"/Views/Empleados/ConsultaEmpleados.cshtml")]
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
#nullable restore
#line 1 "C:\Users\javii\Desktop\Software Coppel\ControlNominaCoppel\ControlEmpleadosCoppel\ControlEmpleadosCoppel\Views\_ViewImports.cshtml"
using ControlEmpleadosCoppel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javii\Desktop\Software Coppel\ControlNominaCoppel\ControlEmpleadosCoppel\ControlEmpleadosCoppel\Views\_ViewImports.cshtml"
using ControlEmpleadosCoppel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acd249c0278568beb24d4691e3e3910d101ebbf", @"/Views/Empleados/ConsultaEmpleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2047e1ae5dae1d9a0cb00264f4c957e5879c155e", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_ConsultaEmpleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":key", new global::Microsoft.AspNetCore.Html.HtmlString("index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("c.idMes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("(c, index) in meses"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("c.rolId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("(c, index) in roles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\javii\Desktop\Software Coppel\ControlNominaCoppel\ControlEmpleadosCoppel\ControlEmpleadosCoppel\Views\Empleados\ConsultaEmpleados.cshtml"
  
    ViewData["Title"] = "Consulta Emppleados";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\javii\Desktop\Software Coppel\ControlNominaCoppel\ControlEmpleadosCoppel\ControlEmpleadosCoppel\Views\Empleados\ConsultaEmpleados.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""row"">
    <div id=""app"">
        <template>
            <div class=""row col m-4"">
                <div class=""col-12"">
                    <div class=""form-group row"">
                        <label class=""col-3 col-form-label text-sm-right pr-0"">
                            <b>Numero de Empleado:</b>
                        </label>
                        <div class=""col-2"">
                            <input type=""text""
                                   class=""form-control form-control-sm""
                                   v-model.trim=""numEmpleado""
                                   id=""txtNumEmpleado""
                                  
                                   tabindex=""1""
                                   placeholder=""Numero Empleado.."">
                        </div>
                        <label 
                               class=""col-2 col-form-label text-sm-right pr-0""><b>Mes:</b></label>
                        <div class=""col-3"">
           ");
            WriteLiteral("                 <select class=\"form-control form-control-sm input-select\"\r\n                                    v-model=\"fechaIni\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acd249c0278568beb24d4691e3e3910d101ebbf7244", async() => {
                WriteLiteral("Seleccione...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acd249c0278568beb24d4691e3e3910d101ebbf8635", async() => {
                WriteLiteral("\r\n                                    {{ c.mes }}\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>

                    </div>
                </div>

                <div class=""col d-block text-center m-2"">
                    <div class=""form-group row"">
                        <label
                               class=""col-3 col-form-label text-sm-right pr-0""><b>Nombre del Empleado:</b></label>
                        <div class=""col-8"">
                            <input disabled type=""text""
                                   class=""form-control form-control-sm""
                                   v-model.trim=""nomEmpleado""
                                  
                                  
                                   tabindex=""1""
                                   placeholder=""Nombre del Empleado"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label 
                               class=""col-3 col-form-label text-s");
            WriteLiteral(@"m-right pr-0""><b>Rol de Trabajo:</b></label>
                        <div class=""col-3"">
                            <select disabled class=""form-control form-control-sm input-select""
                                    v-model=""rolId"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acd249c0278568beb24d4691e3e3910d101ebbf11277", async() => {
                WriteLiteral("Seleccione...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acd249c0278568beb24d4691e3e3910d101ebbf12669", async() => {
                WriteLiteral("\r\n                                    {{ c.rolName }}\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    
                    <div class=""form-group row"">
                        <label 
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Cantidad de Entregas:</b></label>
                        <div class=""col-3"">
                            <input disabled type=""text""
                                   class=""form-control form-control-sm""
                                   v-model.trim=""numEntregas""
                                  
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label 
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Horas Trabajadas:</b></label>
                        <div class=""col-3"">
                            <input disabled type=""text""
                   ");
            WriteLiteral(@"                class=""form-control form-control-sm""
                                   v-model.trim=""numHorasTrabajadas""
                                  
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Pago por Entregas:</b></label>
                        <div class=""col-3"">
                            <input type=""text"" disabled
                                   class=""form-control form-control-sm""
                                   v-model.trim=""pagoEntregas""
                                  
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label 
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Pago por");
            WriteLiteral(@" Bonos:</b></label>
                        <div class=""col-3"">
                            <input type=""text"" disabled
                                   class=""form-control form-control-sm""
                                   v-model.trim=""pagoBonos""
                                   
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Retenciones:</b></label>
                        <div class=""col-3"">
                            <input type=""text"" disabled
                                   class=""form-control form-control-sm""
                                   v-model.trim=""retenciones""
                                   
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group ro");
            WriteLiteral(@"w"">
                        <label
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Vales:</b></label>
                        <div class=""col-3"">
                            <input type=""text"" disabled
                                   class=""form-control form-control-sm""
                                   v-model.trim=""vales""
                                  
                                   tabindex=""1"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label 
                               class=""col-4 col-form-label text-sm-right pr-0""><b>Sueldo Total:</b></label>
                        <div class=""col-3"">
                            <input type=""text"" disabled
                                   class=""form-control form-control-sm""
                                   v-model.trim=""sueldoTotal""
                                  
                                   tabind");
            WriteLiteral(@"ex=""1"">
                        </div>
                    </div>

                    <div class=""pt-3 form-group row"">

                        <div class=""col-11 d-flex justify-content-end"">
                            <button class="" btn btn-info mr-1""
                                    v-on:click=""ConsultarEmpleado()"">
                                Consultar
                            </button>
                            <button class="" btn btn-primary"" v-on:click=""limpiarDatos()"">
                                Borrar
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </template>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>

    var app = new Vue({
        el: ""#app"",
        data() {

            return {
                idCategoriaSeleccionada: 0,
                fechaIni: '',
                numEmpleado: '',
                meses: [{ idMes: 1, mes: ""Enero"" }, { idMes: 2, mes: ""Febrero"" }, { idMes: 3, mes: ""Marzo"" }, { idMes: 4, mes: ""Abril"" },
                    { idMes: 5, mes: ""Mayo"" }, { idMes: 6, mes: ""Junio"" }, { idMes: 7, mes: ""Julio"" }, { idMes: 8, mes: ""Agosto"" },
                    { idMes: 9, mes: ""Septiembre"" }, { idMes: 10, mes: ""Octubre"" }, { idMes: 11, mes: ""Noviembre"" }, { idMes: 12, mes: ""Diciembre"" }],
                url: null,
                message: ""hola mundo desde vue"",
                rbRol: true,
                sueldoTotal: '',
                nomEmpleado: '',
                roles: [{ rolId: 1, rolName: 'Chofer' }, { rolId: 2, rolName: 'Cargador' }, { rolId: 3, rolName: 'Auxiliar' }],
                numEntregas: '',
                numHorasTrabajadas: '',
        ");
                WriteLiteral(@"        pagoEntregas: '',
                pagoBonos: '',
                retenciones: '',
                vales: '',
                sueldoTotal: ''




            }
        },
        methods: {

            ConsultarEmpleado: function () {
   
                var self = this;
                if (self.fechaIni != '' && self.numEmpleado != '') {

                    this.$http.get('../Empleados/ConsultarEmpleados?NumEmpleado=' + self.numEmpleado + '&mes=' + self.fechaIni).then(function (response) {
                        
                        var data = response.data[0];
                        if (response.data.length > 0) {
                            self.numHorasTrabajadas = data.horasTrabajadas;
                            self.nomEmpleado = data.nombre_empleado;
                            self.numEmpleado = data.numEmpleado;
                            self.pagoBonos = data.pagoTotalBonos;
                            self.pagoTotalHoras = data.pagoTotalHoras;
           ");
                WriteLiteral(@"                 self.pagoEntregas = data.pagoTotalEntregas
                            self.retenciones = data.retenciones;
                            self.rolId = data.rolId;
                            self.sueldoTotal = data.sueldoTotal;
                            self.vales = data.vales;
                            self.numEntregas = data.numMovimientos
                        } else {
                            alert(""No se encontraron datos!!"");
                        }
                    }, function () {
                        alert(""Ocurri?? un error mientras se consultaba la informaci??n!!"");
                    });

                } else {
                    alert(self.numEmpleado == '' ? 'favor de introducir el n??mero de empleado!!': 'Favor de seleccionar el mes');
                }

            },
            limpiarDatos: function () {
                var self = this;
                self.numHorasTrabajadas = '';
                self.nomEmpleado = '';
                ");
                WriteLiteral(@"self.numEmpleado = '';
                self.pagoBonos = '';
                self.pagoTotalHoras = '';
                self.pagoEntregas = '';
                self.retenciones = '';
                self.rolId = '';
                self.sueldoTotal = '';
                self.vales = '';
                self.numEntregas = '';
                self.fechaIni = '';
            }
        }

    });

</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
