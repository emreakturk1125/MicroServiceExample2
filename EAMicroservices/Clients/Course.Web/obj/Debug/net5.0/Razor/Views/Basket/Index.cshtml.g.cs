#pragma checksum "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a54ea1e2adada9347563a092bb42fef30f4ca2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\_ViewImports.cshtml"
using Course.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\_ViewImports.cshtml"
using Course.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\_ViewImports.cshtml"
using Course.Web.Models.Catalogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\_ViewImports.cshtml"
using Course.Web.Models.Baskets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\_ViewImports.cshtml"
using Course.Web.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a54ea1e2adada9347563a092bb42fef30f4ca2a", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03489512b3cd1d87ba3551b0c60806d063c0016d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveBasketItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelApplyDiscount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplyDiscount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"row\">\n\n    <div class=\"col-md-8 offset-md-2\">\n\n        <div class=\"card\">\n            <div class=\"card-body\">\n\n                <h5 class=\"card-title\">Sepet</h5>\n\n");
#nullable restore
#line 16 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                 if (Model != null && Model.BasketItems.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped"">

                        <tr>
                            <th>Kurs isim</th>
                            <th>Kurs fiyat</th>
                            <th>İşlemler</th>
                        </tr>

");
#nullable restore
#line 26 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                         foreach (var item in Model.BasketItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 29 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                               Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    ");
#nullable restore
#line 31 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                               Write(item.GetCurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL ");
#nullable restore
#line 31 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                                                         Write(Model.HasDiscount ? $"(%{Model.DiscountRate.Value} uygulandı)" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a54ea1e2adada9347563a092bb42fef30f4ca2a10316", async() => {
                WriteLiteral("sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                                                                                                                            WriteLiteral(item.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                            </tr>\n");
#nullable restore
#line 37 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 39 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                         if (Model.HasDiscount)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>Indirim oranı</td>\n                                <th colspan=\"2\"> % ");
#nullable restore
#line 44 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                                              Write(Model.DiscountRate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            </tr>\n");
#nullable restore
#line 46 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <tr>\n                            <td>");
#nullable restore
#line 50 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                            Write(Model.HasDiscount ? "İndirimli fiyat" : "Toplam fiyat");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <th colspan=\"2\">");
#nullable restore
#line 51 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                                       Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</th>\n                        </tr>\n                    </table>\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a54ea1e2adada9347563a092bb42fef30f4ca2a15162", async() => {
                WriteLiteral("\n");
#nullable restore
#line 56 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                         if (Model.HasDiscount)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"alert alert-success\">\n                                \"");
#nullable restore
#line 59 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                            Write(Model.DiscountCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"indirim kodu uygulandı\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a54ea1e2adada9347563a092bb42fef30f4ca2a16178", async() => {
                    WriteLiteral(" (iptal et)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n");
#nullable restore
#line 62 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""input-group mb-3"">
                            <input type=""text"" class=""form-control"" name=""DiscountApplyInput.Code"">
                            <button class=""btn btn-outline-secondary"" type=""submit"">Uygula</button>
                        </div>

");
#nullable restore
#line 70 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                         if (TempData["discountStatus"] != null && (bool)TempData["discountStatus"] == false)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"text-danger\">indirim kodu geçersiz</div>\n");
#nullable restore
#line 73 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                         if (TempData["discountError"] != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"text-danger\">");
#nullable restore
#line 76 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                                                Write(TempData["discountError"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
#nullable restore
#line 77 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a54ea1e2adada9347563a092bb42fef30f4ca2a21283", async() => {
                WriteLiteral("Ödeme bilgileri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a54ea1e2adada9347563a092bb42fef30f4ca2a22755", async() => {
                WriteLiteral("Kursları incelemeye devam et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 81 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">Sepet boş</div>\n");
#nullable restore
#line 85 "C:\Users\emre.akturk\Documents\GitHub\MicroServiceExample2\EAMicroservices\Clients\Course.Web\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
