#pragma checksum "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bd746ad7f00ac29c443ebb29564beb0cab481d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bd746ad7f00ac29c443ebb29564beb0cab481d6", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b330e1eb204d7d943e394df42c33964e609f73c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : Pos.Web.Views.PosRazorPage<Pos.Web.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
  
    ViewBag.DisableTopBar = true;

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(135, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(140, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d68235", async() => {
                    BeginContext(173, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(182, 99, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bd746ad7f00ac29c443ebb29564beb0cab481d68649", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 9 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(281, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(300, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(306, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d611970", async() => {
                    BeginContext(346, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(355, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bd746ad7f00ac29c443ebb29564beb0cab481d612386", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(458, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(477, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(497, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(502, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d615902", async() => {
                    BeginContext(535, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(544, 92, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d616317", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 18 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(636, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(655, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(661, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d619568", async() => {
                    BeginContext(701, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(710, 96, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d619983", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 22 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(806, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(825, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(828, 50, true);
            WriteLiteral("<div class=\"card\">\n    <div class=\"body\">\n        ");
            EndContext();
            BeginContext(878, 2647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d623408", async() => {
                BeginContext(938, 37, true);
                WriteLiteral("\n            <h4 class=\"text-center\">");
                EndContext();
                BeginContext(976, 13, false);
#line 28 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                               Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(989, 7, true);
                WriteLiteral("</h4>\n\n");
                EndContext();
#line 30 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
             if (@ViewBag.ErrorMessage != null)
            {

#line default
#line hidden
                BeginContext(1058, 99, true);
                WriteLiteral("                <div class=\"alert alert-danger\">\n                    <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(1158, 20, false);
#line 33 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                             Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1178, 24, true);
                WriteLiteral("\n                </div>\n");
                EndContext();
#line 35 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
            }

#line default
#line hidden
                BeginContext(1216, 56, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"IsExternalLogin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1272, "\"", 1313, 1);
#line 37 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1280, Model.IsExternalLogin.ToString(), 1280, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1314, 67, true);
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1381, "\"", 1419, 1);
#line 38 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1389, Model.ExternalLoginAuthSchema, 1389, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1420, 164, true);
                WriteLiteral(" />\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1584, "\"", 1603, 1);
#line 42 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1592, Model.Name, 1592, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1604, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1613, "\"", 1651, 1);
#line 42 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1625, AbpUserBase.MaxNameLength, 1625, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1652, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(1701, 9, false);
#line 43 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(1710, 214, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"Surname\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1924, "\"", 1946, 1);
#line 49 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1932, Model.Surname, 1932, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1947, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1956, "\"", 1997, 1);
#line 49 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1968, AbpUserBase.MaxSurnameLength, 1968, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1998, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2047, 12, false);
#line 50 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(2059, 220, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2279, "\"", 2306, 1);
#line 56 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2287, Model.EmailAddress, 2287, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2307, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2316, "\"", 2362, 1);
#line 56 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2328, AbpUserBase.MaxEmailAddressLength, 2328, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2363, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2412, 17, false);
#line 57 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(2429, 215, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"UserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2644, "\"", 2667, 1);
#line 63 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2652, Model.UserName, 2652, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2668, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2677, "\"", 2719, 1);
#line 63 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2689, AbpUserBase.MaxUserNameLength, 2689, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2720, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2769, 13, false);
#line 64 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(2782, 228, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"password\" class=\"form-control\" name=\"Password\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 3010, "\"", 3057, 1);
#line 70 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3022, AbpUserBase.MaxPlainPasswordLength, 3022, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3058, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(3107, 13, false);
#line 71 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Password"));

#line default
#line hidden
                EndContext();
                BeginContext(3120, 154, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n            \n            <div class=\"row\">\n                <div class=\"col-xs-12\">\n                    ");
                EndContext();
                BeginContext(3274, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd746ad7f00ac29c443ebb29564beb0cab481d633824", async() => {
                    BeginContext(3335, 9, false);
#line 77 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                                                           Write(L("Back"));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3348, 96, true);
                WriteLiteral("\n                    <button id=\"RegisterButton\" class=\"btn bg-pink waves-effect\" type=\"submit\">");
                EndContext();
                BeginContext(3445, 13, false);
#line 78 "D:\Training\Programs\Pos\4.8.0\aspnet-core\src\Pos.Web.Mvc\Views\Account\Register.cshtml"
                                                                                          Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(3458, 60, true);
                WriteLiteral("</button>\n                </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3525, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pos.Web.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
