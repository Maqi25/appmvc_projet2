#pragma checksum "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8cc1fb734b976ab80b562640eafb9739bb0239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personne_ModifierPersonne), @"mvc.1.0.view", @"/Views/Personne/ModifierPersonne.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8cc1fb734b976ab80b562640eafb9739bb0239", @"/Views/Personne/ModifierPersonne.cshtml")]
    #nullable restore
    public class Views_Personne_ModifierPersonne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<appmvc_projet2.Models.Personne>
    #nullable disable
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
#nullable restore
#line 2 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e8cc1fb734b976ab80b562640eafb9739bb02393078", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ModifierLieu</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e8cc1fb734b976ab80b562640eafb9739bb02394144", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <fieldset>\r\n            <legend>Modifier une personne : </legend>\r\n            ");
#nullable restore
#line 16 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.LabelFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.TextBoxFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            \r\n             ");
#nullable restore
#line 19 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.LabelFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.TextBoxFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("            <br />\r\n             ");
#nullable restore
#line 23 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.LabelFor(m => Model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             ");
#nullable restore
#line 24 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.TextBoxFor(m => Model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 26 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.LabelFor(m => Model.NumeroTel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             ");
#nullable restore
#line 27 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.TextBoxFor(m => Model.NumeroTel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           \r\n              ");
#nullable restore
#line 29 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
         Write(Html.LabelFor(m => Model.Adresse));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             ");
#nullable restore
#line 30 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.TextBoxFor(m => Model.Adresse));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           \r\n");
                WriteLiteral("            <br />\r\n            <input type=\"submit\" value=\"Modifier\" />\r\n        </fieldset>\r\n");
#nullable restore
#line 39 "C:\Users\romua\Downloads\appmvc_projet2\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                                                                             

    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<appmvc_projet2.Models.Personne> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
