#pragma checksum "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ffc12a7682210e3d93856e6d1de010cc0f67b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
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
#line 1 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\_ViewImports.cshtml"
using ManagementSoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\_ViewImports.cshtml"
using ManagementSoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ffc12a7682210e3d93856e6d1de010cc0f67b8", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de362d898c9bd1205613fe9357ea2d9015e2e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLib.Entities.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-datatable btn-icon btn-transparent-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quickForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
  
    ViewData["Title"] = "Order";
    Layout = "~/Views/Shared/adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ffc12a7682210e3d93856e6d1de010cc0f67b85513", async() => {
                WriteLiteral("\r\n    <div class=\"card-body\">\r\n        <div class=\"col-md-12\">\r\n            <input type=\"button\" id=\"btnAdd\" class=\"btn btn-success\" style=\"margin-top: 14px; margin-bottom:10px; float:right;\" value=\"Add Order\"");
                BeginWriteAttribute("onclick", " onclick=\"", 420, "\"", 498, 2);
#nullable restore
#line 11 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
WriteAttributeValue("", 430, "window.location.href='" + @Url.Action("AddOrder", "Home") + "'", 430, 67, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 497, ";", 497, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <table id=\"example2\" class=\"table table-bordered table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                   Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                   Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                   Write(Html.DisplayNameFor(model => model.ShipingAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>Action</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 35 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RequiredDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ShipingAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"textcentre\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ffc12a7682210e3d93856e6d1de010cc0f67b811390", async() => {
                    WriteLiteral("<i class=\"fa fa-edit\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2360, "~/Home/AddOrder?Id=", 2360, 19, true);
#nullable restore
#line 56 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
AddHtmlAttributeValue("", 2379, item.Id, 2379, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n                                <a href=\"#\" class=\"btn btn-datatable btn-icon btn-transparent-dark\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2578, "\"", 2604, 3);
                WriteAttributeValue("", 2588, "Delete(", 2588, 7, true);
#nullable restore
#line 57 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
WriteAttributeValue("", 2595, item.Id, 2595, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2603, ")", 2603, 1, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\Order.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function Delete(id) {
            $.ajax({
                type: ""POST"",
                url: '/Home/DeleteOrder',
                data: { Id: id },

                success: function (data) {
                    alert(""Deleted Successfully"");
                    location.reload();
                },
                error: function (x) {
                    alert(""Something went wrong"");
                }
            })
        }
        $(function () {
            $('#example2').DataTable({
                ""paging"": true,
                ""lengthChange"": true,
                ""searching"": true,
                ""ordering"": true,
                ""info"": false,
                ""autoWidth"": true,
                ""responsive"": true,
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLib.Entities.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
