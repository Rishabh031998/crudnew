#pragma checksum "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e34073d15cde03c6bf7e5bf698ba86f5a44f7d"
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
#line 1 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\_ViewImports.cshtml"
using crudnew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\_ViewImports.cshtml"
using crudnew.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e34073d15cde03c6bf7e5bf698ba86f5a44f7d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265cc442ccb4a3e21e0d4292fb175330bf9d6297", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bootstrap-css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Students";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97e34073d15cde03c6bf7e5bf698ba86f5a44f7d4479", async() => {
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
            WriteLiteral("\r\n\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row mb-2\">\r\n            <div class=\"col-6\">\r\n                <h1>");
#nullable restore
#line 12 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n");
            WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    <a class=\"btn btn-primary btn-inline-block float-right\" href=\"/AccountController1/Logout\">\r\n                      Logout\r\n                    </a>\r\n                </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n");
            WriteLiteral("                            <div class=\"row mb-2\">\r\n                                <div class=\"col-md-12\">\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div style=\"width:100%;\">\r\n                                ");
#nullable restore
#line 43 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
                           Write(Html.AjaxGrid(Url.Action("IndexGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n<div id=\'DocumentTypeModal\' class=\'modal fade in\'>\r\n    <div id=\'DocumentTypeContainer\'>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
      document.querySelectorAll("".mvc-grid"").forEach(element => new MvcGrid(element));

      function loadModal() {
          OnAdd();
    }
    function closeModal() {
        $('#DocumentTypeModal').modal('hide');
        }

         function OnAdd(current) {
             var URL = """);
#nullable restore
#line 72 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
                   Write(Url.Action("EntriesWiseDocumentTypeDetails", new { Id = 0}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                $.ajax({
                    url: URL,
                    type: 'POST',
                    success: function (returndata) {
                        debugger
                        $('#DocumentTypeContainer').empty();
                        $('#DocumentTypeContainer').append(returndata);

                        $('#DocumentTypeModal').modal('show');
                        $('#DocumentTypeContainer').show();
                    }
                });
        }
        function OnEditDocumentType(current) {
      var URL = """);
#nullable restore
#line 87 "C:\Users\Amar\source\repos\crudnew\crudnew\Views\Home\Index.cshtml"
            Write(Url.Action("DocumentTypeDetailsListGrid", new { id = "ids" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""".replace(""ids"", parseInt(current));
                $.ajax({
                    url: URL,
                    type: 'POST',
                    success: function (returndata) {
                        debugger;
                        window.location.href = URL;
                        debugger;
                       
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
