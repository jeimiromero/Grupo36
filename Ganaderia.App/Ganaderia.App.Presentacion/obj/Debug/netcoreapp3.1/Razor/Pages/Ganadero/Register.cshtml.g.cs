#pragma checksum "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca734d31df61accbb3e12197ecdf0c0d8ffa228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ganaderia.App.Presentacion.Pages.Ganadero.Pages_Ganadero_Register), @"mvc.1.0.razor-page", @"/Pages/Ganadero/Register.cshtml")]
namespace Ganaderia.App.Presentacion.Pages.Ganadero
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
#line 1 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\_ViewImports.cshtml"
using Ganaderia.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca734d31df61accbb3e12197ecdf0c0d8ffa228", @"/Pages/Ganadero/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1717c2eb7bb98504efa8c0608ed0b9689cdbfa7f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ganadero_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/logo-mintic.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Registro de ganadero</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ca734d31df61accbb3e12197ecdf0c0d8ffa2284551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca734d31df61accbb3e12197ecdf0c0d8ffa2285748", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleFormControlSelect1\">Ganaderos</label>\r\n        <select class=\"form-control\" id=\"mySelect\" onchange=\"myFunction()\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca734d31df61accbb3e12197ecdf0c0d8ffa2286211", async() => {
                    WriteLiteral("Seleccione una opción");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
             foreach (var ganadero in Model.Ganaderos)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca734d31df61accbb3e12197ecdf0c0d8ffa2287543", async() => {
#nullable restore
#line 16 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
                   Write(ganadero.Nombres);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" class=""form-control"" placeholder=""First name"">
        </div>
        <div class=""col"">
            <input type=""text"" class=""form-control"" placeholder=""Last name"">
        </div>
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Nombres</label>
        <input class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Apellidos</label>
        <input class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Numero de telefono</label>
        <input class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Direccion</lab");
                WriteLiteral("el>\r\n        <input class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"name@example.com\">\r\n    </div>\r\n");
#nullable restore
#line 44 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
     if (Model.tipoPerfil == "Ganadero")
    {



#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"exampleFormControlInput1\">Correo</label>\r\n            <input class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"name@example.com\">\r\n        </div>\r\n");
#nullable restore
#line 52 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""form-group"">
            <label for=""exampleFormControlInput1"">Contraseña</label>
            <input class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlInput1"">Repetir contraseña</label>
            <input class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
        </div>
");
                WriteLiteral("        <div>\r\n            <button type=\"button\" class=\"btn btn-primary\">Registro</button>\r\n        </div>\r\n");
#nullable restore
#line 67 "D:\MINTIC\Grupo36\Ganaderia\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganadero\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script>\r\n        function myFunction() {\r\n            var x = document.getElementById(\"mySelect\").value;\r\n            alert(x);\r\n        }\r\n    </script>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ganaderia.App.Presentacion.Pages.RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RegisterModel>)PageContext?.ViewData;
        public Ganaderia.App.Presentacion.Pages.RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591