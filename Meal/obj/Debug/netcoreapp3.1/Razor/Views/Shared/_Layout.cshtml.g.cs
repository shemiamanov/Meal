#pragma checksum "C:\Users\Acer\Desktop\task3\Meal\Meal\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cfe111d0f97a0b70813badcb7b618c04ea90b31"
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
#line 1 "C:\Users\Acer\Desktop\task3\Meal\Meal\Views\_ViewImports.cshtml"
using Meal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\task3\Meal\Meal\Views\_ViewImports.cshtml"
using Meal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cfe111d0f97a0b70813badcb7b618c04ea90b31", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd4bb89eb3598777156e3fcbcbf14ccac362603", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cfe111d0f97a0b70813badcb7b618c04ea90b313833", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""assets/style.css"">
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cfe111d0f97a0b70813badcb7b618c04ea90b315325", async() => {
                WriteLiteral(@"
    <header>

        <nav class=""navbar navbar-white bg-white"" aria-label=""First navbar example"">
            <div class=""container-fluid"">
                <a class=""navbar-brand"" href=""#"" style=""margin-left: 700px;"">
                    <button style=""font-size: 35px;"">
                        M
                    </button>
                </a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                        data-bs-target=""#navbarsExample01"" aria-controls=""navbarsExample01"" aria-expanded=""false""
                        aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarsExample01"">
                    <ul class=""navbar-nav me-auto mb-2"" style=""padding-left:90%;"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
        ");
                WriteLiteral(@"                </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Link</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">About Us</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Reserve A Table</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Contact</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    ");
#nullable restore
#line 53 "C:\Users\Acer\Desktop\task3\Meal\Meal\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer class=""bg-dark text-center text-white"">
        <!-- Grid container -->
        <div class=""container p-4"">
            <!-- Section: Social media -->
            <section class=""mb-4"">
                <!-- Facebook -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-facebook-f""></i>
                </a>

                <!-- Twitter -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-twitter""></i>
                </a>

                <!-- Google -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-google""></i>
                </a>

                <!-- Instagram -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-instagram""></i>
                </a>

     ");
                WriteLiteral(@"           <!-- Linkedin -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-linkedin-in""></i>
                </a>

                <!-- Github -->
                <a class=""btn btn-outline-light btn-floating m-1"" href=""#!"" role=""button"">
                    <i class=""fab fa-github""></i>
                </a>
            </section>
            <!-- Section: Social media -->
            <!-- Section: Form -->
            <section");
                BeginWriteAttribute("class", " class=\"", 4007, "\"", 4015, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cfe111d0f97a0b70813badcb7b618c04ea90b319599", async() => {
                    WriteLiteral(@"
                    <!--Grid row-->
                    <div class=""row d-flex justify-content-center"">
                        <!--Grid column-->
                        <div class=""col-auto"">
                            <p class=""pt-2"">
                                <strong>Sign up for our newsletter</strong>
                            </p>
                        </div>
                        <!--Grid column-->
                        <!--Grid column-->
                        <div class=""col-md-5 col-12"">
                            <!-- Email input -->
                            <div class=""form-outline form-white mb-4"">
                                <input type=""email"" id=""form5Example21"" class=""form-control"" />
                                <label class=""form-label"" for=""form5Example21"">Email address</label>
                            </div>
                        </div>
                        <!--Grid column-->
                        <!--Grid column-->
               ");
                    WriteLiteral(@"         <div class=""col-auto"">
                            <!-- Submit button -->
                            <button type=""submit"" class=""btn btn-outline-light mb-4"">
                                Subscribe
                            </button>
                        </div>
                        <!--Grid column-->
                    </div>
                    <!--Grid row-->
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </section>
            <!-- Section: Form -->
            <!-- Section: Text -->
            <section class=""mb-4"">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt distinctio earum
                    repellat quaerat voluptatibus placeat nam, commodi optio pariatur est quia magnam
                    eum harum corrupti dicta, aliquam sequi voluptate quas.
                </p>
            </section>
            <!-- Section: Text -->
            <!-- Section: Links -->
            <section");
                BeginWriteAttribute("class", " class=\"", 6067, "\"", 6075, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <!--Grid row-->
                <div class=""row"">
                    <!--Grid column-->
                    <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                        <h5 class=""text-uppercase"">Links</h5>

                        <ul class=""list-unstyled mb-0"">
                            <li>
                                <a href=""#!"" class=""text-white"">Link 1</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 2</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 3</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 4</a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
      ");
                WriteLiteral(@"              <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                        <h5 class=""text-uppercase"">Links</h5>

                        <ul class=""list-unstyled mb-0"">
                            <li>
                                <a href=""#!"" class=""text-white"">Link 1</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 2</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 3</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 4</a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                        <h5 class=""text-uppercase"">Links<");
                WriteLiteral(@"/h5>

                        <ul class=""list-unstyled mb-0"">
                            <li>
                                <a href=""#!"" class=""text-white"">Link 1</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 2</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 3</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 4</a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                        <h5 class=""text-uppercase"">Links</h5>

                        <ul class=""list-unstyled mb-0"">
                            <li>
                  ");
                WriteLiteral(@"              <a href=""#!"" class=""text-white"">Link 1</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 2</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 3</a>
                            </li>
                            <li>
                                <a href=""#!"" class=""text-white"">Link 4</a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                </div>
                <!--Grid row-->
            </section>
            <!-- Section: Links -->
        </div>
        <!-- Grid container -->
        <!-- Copyright -->
        <div class=""text-center p-3"" style=""background-color: rgba(0, 0, 0, 0.2);"">
            ?? 2020 Copyright:
            <a class=""text-white"" href=""https://mdbootstrap.com/"">MDBootstrap.com</a>");
                WriteLiteral(@"
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
    <script src=""assets/main.js""></script>

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
            WriteLiteral("\r\n\r\n</html>");
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
