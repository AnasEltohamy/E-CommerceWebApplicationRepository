#pragma checksum "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd602e861718ec7237fa2a38c928b9dc76890e3aafe66ce17d710e3c59589edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\_ViewImports.cshtml"
using CompanyProject.PL

#nullable disable
    ;
#nullable restore
#line 2 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\_ViewImports.cshtml"
using CompanyProject.PL.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\_ViewImports.cshtml"
using Company.BLL.Interfaces;

#nullable disable
#nullable restore
#line 4 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\_ViewImports.cshtml"
using CompanyProject.PL.View_Models;

#nullable disable
#nullable restore
#line 5 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\_ViewImports.cshtml"
using Company.DaL.Models;

#nullable disable
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cd602e861718ec7237fa2a38c928b9dc76890e3aafe66ce17d710e3c59589edc", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"10516ac271d43ea5cb96dd4a0b46476f9d110393ffdcab37d345e0bf64745a24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
       IEnumerable<UserViewModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
 if(Model.Count()>0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd602e861718ec7237fa2a38c928b9dc76890e3aafe66ce17d710e3c59589edc5858", async() => {
                WriteLiteral(@"
            <div class=""col-8"">
                <input class=""form-control"" type=""text"" name=""SearchValue"" placeholder=""User Name"">
            </div>
            <div class=""col-4"">
                <input class=""btn btn-success"" type=""submit"" value=""Search"">
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <table class=\"table table-striped table-hover mt-5\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 25 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 26 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.Fname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 27 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.Lname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 28 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 29 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 30 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                     Html.DisplayNameFor(U=>U.Roles)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>Details</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
             foreach(var User in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            Write(
#nullable restore
#line 40 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         User.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 41 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         User.Fname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 42 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         User.Lname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 43 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         User.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 44 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         User.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 45 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                         string.Join("," ,User.Roles)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd602e861718ec7237fa2a38c928b9dc76890e3aafe66ce17d710e3c59589edc12147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 46 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
                                                                User.Id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 52 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div>\r\n        <h1> There Is No Users </h1>\r\n    </div>\r\n");
#nullable restore
#line 58 "D:\GitHubProject\E-CommerceWebApplicationRepository\CompanyProject.PL\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
