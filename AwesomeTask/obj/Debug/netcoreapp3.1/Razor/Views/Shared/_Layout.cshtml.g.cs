#pragma checksum "C:\Users\ibm\source\repos\AwesomeTask\AwesomeTask\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6454b4ac994837dd3e63a25d4cda23053bb3b3aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\ibm\source\repos\AwesomeTask\AwesomeTask\Views\_ViewImports.cshtml"
using AwesomeTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibm\source\repos\AwesomeTask\AwesomeTask\Views\_ViewImports.cshtml"
using AwesomeTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ibm\source\repos\AwesomeTask\AwesomeTask\Views\_ViewImports.cshtml"
using AwesomeTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6454b4ac994837dd3e63a25d4cda23053bb3b3aa", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea54a055ee78a90476107fbb96e1f5d07a797b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6454b4ac994837dd3e63a25d4cda23053bb3b3aa3443", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""assets/css/main.css"">
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6454b4ac994837dd3e63a25d4cda23053bb3b3aa5039", async() => {
                WriteLiteral(@"
    <section id=""navbar"">
        <div class=""container"">
            <header class=""d-flex flex-wrap justify-content-center py-3 "">
                <a href=""/"" class=""d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none"">
                    <img src=""https://demo.templateflip.com/awesome-app/images/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1008, "\"", 1014, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <h3 style=""color: white;"">AWESOME APP </h3>
                </a>
                <ul class=""nav nav-pills"" id=""ul"">
                    <li class=""nav-item""><a href=""#"" class=""nav-link "" aria-current=""page"">Home</a></li>
                    <li class=""nav-item""><a href=""#"" class=""nav-link"">Features</a></li>
                    <li class=""nav-item""><a href=""#"" class=""nav-link"">Pricing</a></li>
                    <button type=""button"" class=""btn btn-outline-light"">DOWNLOAD NOW</button>
                </ul>
            </header>
        </div>
    </section>
    ");
#nullable restore
#line 30 "C:\Users\ibm\source\repos\AwesomeTask\AwesomeTask\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <section style=""background-color: #252422"">
        <div class=""container"">
            <footer class=""py-3 "">
                <ul class=""nav justify-content-center  pb-3 mb-3"">
                    <li class=""nav-item""><a href=""#"" class=""nav-link px-2 text-muted""><i class=""bi bi-facebook"" style=""color: white;""></i></a></li>
                    <li class=""nav-item""><a href=""#"" class=""nav-link px-2 text-muted""><i class=""bi bi-twitter"" style=""color: white;""></i></a></li>
                    <li class=""nav-item""><a href=""#"" class=""nav-link px-2 text-muted""><i class=""bi bi-google"" style=""color: white;""></i></a></li>
                    <li class=""nav-item""><a href=""#"" class=""nav-link px-2 text-muted""><i class=""bi bi-instagram"" style=""color: white;""></i></a></li>

                </ul>
                <p class=""text-center text-muted"" style=""color: white !important;"">
                    Copyright ?? Awesome App. All rights reserved. <br>
                    Design - TemplateFlip
                <");
                WriteLiteral(@"/p>
            </footer>
        </div>
    </section>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
