#pragma checksum "C:\Users\marti\OneDrive\Escritorio\Proyectofinalciclo 3\TransporteBusesApp\TransporteBusesApp.Frontend\Pages\Buses\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbaec3fa43fc417c263d615d7f50c9ea1ef0bc2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TransporteBusesApp.Frontend.Pages.Buses.Pages_Buses_List), @"mvc.1.0.razor-page", @"/Pages/Buses/List.cshtml")]
namespace TransporteBusesApp.Frontend.Pages.Buses
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
#line 1 "C:\Users\marti\OneDrive\Escritorio\Proyectofinalciclo 3\TransporteBusesApp\TransporteBusesApp.Frontend\Pages\_ViewImports.cshtml"
using TransporteBusesApp.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbaec3fa43fc417c263d615d7f50c9ea1ef0bc2f", @"/Pages/Buses/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7761aa0c8bdf26a082a99c36e251e839b2e8f8f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buses_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Marca</th>
      <th scope=""col"">Modelo</th>
      <th scope=""col"">Kilometraje</th>
      <th scope=""col"">Numero de Asientos</th>
      <th scope=""col"">Placa</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>BMW</td>
      <td>2019</td>
      <td>50000</td>
      <td>5</td>
      <td>ZZZ001</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>HONDA</td>
      <td>2021</td>
      <td>20000</td>
      <td>5</td>
      <td>WWW001</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>MAZDA</td>
      <td>2022</td>
      <td>250</td>
      <td>7</td>
      <td>XXX001</td>
    </tr>
  </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Buses_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_List>)PageContext?.ViewData;
        public Pages_Buses_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
