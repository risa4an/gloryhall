#pragma checksum "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d06d8f25c8d578da6136655cc33329d6fef165e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d06d8f25c8d578da6136655cc33329d6fef165e", @"/Views/Messages/Index.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gloryhall.Data.Models.Message>>
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
            WriteLiteral("\n\n");
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d06d8f25c8d578da6136655cc33329d6fef165e2738", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Thread</title>

    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://gloryhall.azurewebsites.net/css/Messages.css""  rel=""stylesheet"" type=""text/css"" />

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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d06d8f25c8d578da6136655cc33329d6fef165e4021", async() => {
                WriteLiteral(@"
    <header class=""header-box"">
        <div class=""collapse bg-dark"" id=""navbarHeader"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-8 col-md-7 py-4"">
                        <h4 class=""text-white"">About</h4>
                        <p class=""text-muted"">Add some information about the album below, the author, or any other background context. Make it a few sentences long so folks can pick up some informative tidbits. Then, link them off to some social networking sites or contact information.</p>
                    </div>
                    <div class=""col-sm-4 offset-md-1 py-4"">
                        <h4 class=""text-white"">Contact</h4>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"" class=""text-white"">Follow on Twitter</a></li>
                            <li><a href=""#"" class=""text-white"">Like on Facebook</a></li>
                            <li><a href=""#"" class=""text-white"">Email me</a></li>
");
                WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""navbar navbar-dark bg-dark shadow-sm"">
            <div class=""container d-flex justify-content-between"">
                <a");
                BeginWriteAttribute("href", " href=\"", 1697, "\"", 1753, 3);
#nullable restore
#line 36 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
WriteAttributeValue("", 1704, Url.Action("Index", "Match"), 1704, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1733, "?id=", 1733, 4, true);
#nullable restore
#line 36 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
WriteAttributeValue("", 1737, ViewBag.matchId, 1737, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"navbar-brand d-flex align-items-center\">\n\n                    <strong>&larr;</strong>\n                </a>\n");
#nullable restore
#line 40 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <a href=""#"" class=""navbar-brand d-flex align-items-center"">

                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-controller"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M11.119 2.693c.904.19 1.75.495 2.235.98.407.408.779 1.05 1.094 1.772.32.733.599 1.591.805 2.466.206.875.34 1.78.364 2.606.024.815-.059 1.602-.328 2.21a1.42 1.42 0 0 1-1.445.83c-.636-.067-1.115-.394-1.513-.773a11.307 11.307 0 0 1-.739-.809c-.126-.147-.25-.291-.368-.422-.728-.804-1.597-1.527-3.224-1.527-1.627 0-2.496.723-3.224 1.527-.119.131-.242.275-.368.422-.243.283-.494.576-.739.81-.398.378-.877.705-1.513.772a1.42 1.42 0 0 1-1.445-.83c-.27-.608-.352-1.395-.329-2.21.024-.826.16-1.73.365-2.606.206-.875.486-1.733.805-2.466.315-.722.687-1.364 1.094-1.772.486-.485 1.331-.79 2.235-.98.932-.196 2.03-.292 3.119-.292 1.089 0 2.187.096 3.119.292zm-6.032.979c-.877.185-1.469.443-1.733.708-.276.276-.587.783-.885 1.465a13.748 13.748 0");
                WriteLiteral(@" 0 0-.748 2.295 12.351 12.351 0 0 0-.339 2.406c-.022.755.062 1.368.243 1.776a.42.42 0 0 0 .426.24c.327-.034.61-.199.929-.502.212-.202.4-.423.615-.674.133-.156.276-.323.44-.505C4.861 9.97 5.978 9.026 8 9.026s3.139.943 3.965 1.855c.164.182.307.35.44.505.214.25.403.472.615.674.318.303.601.468.929.503a.42.42 0 0 0 .426-.241c.18-.408.265-1.02.243-1.776a12.354 12.354 0 0 0-.339-2.406 13.753 13.753 0 0 0-.748-2.295c-.298-.682-.61-1.19-.885-1.465-.264-.265-.856-.523-1.733-.708-.85-.179-1.877-.27-2.913-.27-1.036 0-2.063.091-2.913.27z"" />
                            <path d=""M11.5 6.026a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zm-1 1a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zm2 0a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zm-1 1a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zm-7-2.5h1v3h-1v-3z"" />
                            <path d=""M3.5 6.526h3v1h-3v-1zM3.051 3.26a.5.5 0 0 1 .354-.613l1.932-.518a.5.5 0 0 1 .258.966l-1.932.518a.5.5 0 0 1-.612-.354zm9.976 0a.5.5 0 0 0-.353-.613l-1.932-.518a.5.5 0 1 0-.259.966l1.932.518a.5.5 0 0 0 .612-.354z"" />
                        </sv");
                WriteLiteral("g>\n                        <strong>");
#nullable restore
#line 49 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                        <form method=""post"" asp-controller=""Account"" asp-action=""Logout"">
                            <input type=""submit"" value=""Logout"" class=""navbar-toggler"" data-toggle=""collapse"" />
                        </form>
                    </a>
");
#nullable restore
#line 54 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 4390, "\"", 4428, 1);
#nullable restore
#line 57 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
WriteAttributeValue("", 4397, Url.Action("Login", "Account"), 4397, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""navbar-brand d-flex align-items-center"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-frown"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                            <path fill-rule=""evenodd"" d=""M4.285 12.433a.5.5 0 0 0 .683-.183A3.498 3.498 0 0 1 8 10.5c1.295 0 2.426.703 3.032 1.75a.5.5 0 0 0 .866-.5A4.498 4.498 0 0 0 8 9.5a4.5 4.5 0 0 0-3.898 2.25.5.5 0 0 0 .183.683z"" />
                            <path d=""M7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z"" />
                        </svg>
                        <strong>Log In</strong>
                    </a>
");
#nullable restore
#line 65 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n        </div>\n    </header>\n    <div class=\"row\">\n        <div class=\"col-12\">\n            <hr />\n        </div>\n    </div>\n    <div class=\"row mes-box\" id=\"messages\">\n");
#nullable restore
#line 75 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
         if (Model != null)
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row mb-3\">\n                <div class=\"col-md-4 themed-grid-col\" style=\"font-weight:bold\">");
#nullable restore
#line 80 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                                                                          Write(item.User.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                <div class=\"col-md-8 themed-grid-col\">");
#nullable restore
#line 81 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
                                                 Write(item.text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n            </div>\n");
#nullable restore
#line 83 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div class=\"container input-box\">\n        <div class=\"row mes-input\">\n        \n            <div class=\"col-12\"><input type=\"text\" class=\"field\" id=\"messageInput\" /><input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6014, "\"", 6037, 1);
#nullable restore
#line 89 "/Users/katerina/Projects/gloryhall/gloryhall/Views/Messages/Index.cshtml"
WriteAttributeValue("", 6022, ViewData["id"], 6022, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"threadID\"/></div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-6\">\n                <input type=\"button\" class=\"send-btn\" id=\"sendButton\" value=\"Send Message\" />\n            </div>\n        </div>\n    </div>\n");
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
            WriteLiteral("\n</html>\n\n<script src=\"https://gloryhall.azurewebsites.net/js/signalr/dist/browser/signalr.js\"></script>\n<script src=\"https://gloryhall.azurewebsites.net/js/Chathub.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<gloryhall.Data.Models.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
