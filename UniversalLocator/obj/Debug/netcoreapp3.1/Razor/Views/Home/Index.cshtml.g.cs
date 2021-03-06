#pragma checksum "C:\Users\Srishty\source\repos\UniversalLocator\UniversalLocator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1be6277063b3de4da6dc4c7f28c930e74045f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Srishty\source\repos\UniversalLocator\UniversalLocator\Views\_ViewImports.cshtml"
using UniversalLocator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Srishty\source\repos\UniversalLocator\UniversalLocator\Views\_ViewImports.cshtml"
using UniversalLocator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1be6277063b3de4da6dc4c7f28c930e74045f3e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b33839a78499dfcd7d451079ed9e592804b0405", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Srishty\source\repos\UniversalLocator\UniversalLocator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Please Enter a ZipCode</h1>\r\n        <br />\r\n        <br />\r\n        <lablel>\r\n            Zipcode:\r\n            <input id=\"zipcode\"");
            BeginWriteAttribute("value", " value=\"", 240, "\"", 248, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" maxlength=""5"" />
        </lablel>

        <label>
            <button id=""search"" onclick=""onSearch()"">Search</button>
        </label>
        <br />
        <br />

        <div class=""resultDiv"">
            <div class=""success"">
                <h4>You have entered zipcode: <span id=""resultZip""></span></h4>
                <h4>Your city is: <span id=""resultCity""></span></h4>
                <h4>Your state is: <span id=""resultState""></span></h4>
                <h4>Your distance from MindGrub's office location is: <span id=""resultDistance""></span> miles</h4>
            </div>
            <div class=""failure"">
                <h4> Your entered zipcode cannot be found!</h4>
            </div>
        </div>

    </div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.success').hide();
            $('.failure').hide();
            $('#search').prop('disabled', true);

            $('#zipcode').on(""keyup"", function () {
                if ($(this).val() != '') {
                    $('#search').prop('disabled', false);
                }
            });
        });

        function onSearch() {
            const zipcode = $('#zipcode').val();
            $.ajax({
                type: ""GET"",
                url: `/api/Locator/${zipcode}`,
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                success: function(place) {
                    if (place) {
                        $('#resultZip').html(zipcode);
                        $('#resultCity').html(place.city)
                        $('#resultState').html(place.state)
                        $('#resultDistance').html(place.distanceFromMindGrub)
                       ");
                WriteLiteral(@" $('.success').show();
                        $('.failure').hide();
                    } else {
                        $('.failure').show();
                        $('.success').hide();
                    }
                },
                error: function () {
                    console.log('Error in searching the zipcode');
                }
            });
        }
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
