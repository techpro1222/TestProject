#pragma checksum "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753b53f9f3f150f0153127d2735e9297d60922ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerDetail), @"mvc.1.0.view", @"/Views/Home/CustomerDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753b53f9f3f150f0153127d2735e9297d60922ab", @"/Views/Home/CustomerDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de362d898c9bd1205613fe9357ea2d9015e2e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLib.Entities.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-datatable btn-icon btn-transparent-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quickForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsersDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
  
    ViewData["Title"] = "CustomerDetail";
    Layout = "~/Views/Shared/adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753b53f9f3f150f0153127d2735e9297d60922ab5585", async() => {
                WriteLiteral("\r\n    <div class=\"card-body\">\r\n\r\n        <div class=\"col-md-12\">\r\n            <input type=\"button\" id=\"btnAdd\" class=\"btn btn-success\" style=\"margin-top: 14px; margin-bottom:10px; float:right;\" value=\"Add Customer\"");
                BeginWriteAttribute("onclick", " onclick=\"", 443, "\"", 524, 2);
#nullable restore
#line 12 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
WriteAttributeValue("", 453, "window.location.href='" + @Url.Action("AddCustomer", "Home") + "'", 453, 70, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 523, ";", 523, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <table id=\"example2\" class=\"table table-bordered table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.ContactTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>Action</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 45 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                 if (Model != null)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ContactTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PostalCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"textcentre\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753b53f9f3f150f0153127d2735e9297d60922ab13976", async() => {
                    WriteLiteral("<i class=\"fa fa-edit\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3177, "~/Home/AddCustomer?Id=", 3177, 22, true);
#nullable restore
#line 76 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
AddHtmlAttributeValue("", 3199, item.Id, 3199, 8, false);

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
                BeginWriteAttribute("onclick", " onclick=\"", 3398, "\"", 3424, 3);
                WriteAttributeValue("", 3408, "Delete(", 3408, 7, true);
#nullable restore
#line 77 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
WriteAttributeValue("", 3415, item.Id, 3415, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3423, ")", 3423, 1, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 80 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\Development\Web\Ready To User WebApp DarkSkin\ManagementSoft\ManagementSoft\Views\Home\CustomerDetail.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
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
                url: '/Home/DeleteCustomer',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLib.Entities.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
