#pragma checksum "C:\Users\romua\Downloads\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master\appmvc_projet2\Views\Shared\Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c70198abce5d8b5a11bca6b00f4f7b7e704618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layout), @"mvc.1.0.view", @"/Views/Shared/Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c70198abce5d8b5a11bca6b00f4f7b7e704618", @"/Views/Shared/Layout.cshtml")]
    #nullable restore
    public class Views_Shared_Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c70198abce5d8b5a11bca6b00f4f7b7e7046182867", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n  <title>JFR Innov </title>\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 183, "\"", 193, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 223, "\"", 233, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

  <!-- Favicons -->
  <link href=""assets/img/favicon.png"" rel=""icon"">
  <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

  <!-- Google Fonts -->
  <link href=""https://fonts.googleapis.com/css?family=Poppins:300,300i,400,400i,600,600i,700,700i|Satisfy|Comic+Neue:300,300i,400,400i,700,700i"" rel=""stylesheet"">

  <!-- Vendor CSS Files -->
  <link href=""../assets/vendor/animate.css/animate.min.css"" rel=""stylesheet"">
  <link href=""../assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
  <link href=""../assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
  <link href=""../assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
  <link href=""../assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
  <link href=""../assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

  <!-- Template Main CSS File -->
  <link href=""../assets/css/style.css"" rel=""stylesheet"">
  

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c70198abce5d8b5a11bca6b00f4f7b7e7046185358", async() => {
                WriteLiteral(@"

  <!-- ======= Top Bar ======= -->
  <section id=""topbar"" class=""d-flex align-items-center fixed-top "">
    <div class=""container-fluid container-xl d-flex align-items-center justify-content-center justify-content-lg-start"">
      <i class=""bi bi-phone d-flex align-items-center""><span>+1 5589 55488 55</span></i>
      <i class=""bi bi-clock ms-4 d-none d-lg-flex align-items-center""><span>Mon-Sat: 11:00 AM - 23:00 PM</span></i>
    </div>
  </section>

  <!-- ======= Header ======= -->
  <header id=""header"" class=""fixed-top d-flex align-items-center "">
    <div class=""container-fluid container-xl d-flex align-items-center justify-content-between"">

      <div class=""logo me-auto"">
        <h1><a href=""index.html"">JFR Innov</a></h1>
        <!-- Uncomment below if you prefer to use an image logo -->
        <!-- <a href=""index.html""><img src=""assets/img/logo.png"" alt="""" class=""img-fluid""></a>-->
      </div>

      <nav id=""navbar"" class=""navbar order-last order-lg-0"">
      <ul>
        ");
                WriteLiteral("  <li><a class=\"nav-link scrollto active\" href=\"/Shared/HomePage\">Home</a></li>\r\n          <li><a class=\"nav-link scrollto\" href=\"#about\">About</a></li>\r\n");
                WriteLiteral(@"          <li><a class=""nav-link scrollto"" href=""/Personne/CreerPersonne"">Envoyer un colis</a></li>
          <li><a class=""nav-link scrollto"" href=""#events"">Co-voiturage</a></li>
          <li><a class=""nav-link scrollto"" href=""#chefs"">Location Véhicule</a></li>
          <li><a class=""nav-link scrollto"" href=""#gallery"">Aide à la personne</a></li>
          <li class=""dropdown""><a href=""#""><span><i class=""fa-solid fa-user""></i></span> <i class=""bi bi-chevron-down""></i></a>
            
         
            <ul>

              <li><a href=""/Login/Connexion"">Connexion</a></li>
              <li><a href=""/Login/CreerCompte"">Inscription</a></li>

            </ul>
          </li>
          <li><a class=""nav-link scrollto"" href=""#contact"">Contact</a></li>
      </ul>
        <i class=""bi bi-list mobile-nav-toggle""></i>
      </nav><!-- .navbar -->

      <a href=""#book-a-table"" class=""book-a-table-btn scrollto"">Postez une annonce</a>

    </div>
  </header><!-- End Header -->

  <main id=");
                WriteLiteral("\"main\">\r\n\r\n    <!-- =======  Section ======= -->\r\n\r\n\r\n    <section class=\"inner-page\">\r\n      <div class=\"container\">\r\n          ");
#nullable restore
#line 89 "C:\Users\romua\Downloads\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master\appmvc_projet2\Views\Shared\Layout.cshtml"
     Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

      </div>
    </section>

  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id=""footer"">
    <div class=""container"">
      <h3>Delicious</h3>
      <p>Et aut eum quis fuga eos sunt ipsa nihil. Labore corporis magni eligendi fuga maxime saepe commodi placeat.</p>
      <div class=""social-links"">
        <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
        <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
        <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
        <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
        <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
      </div>
      <div class=""copyright"">
        &copy; Copyright <strong><span>Delicious</span></strong>. All Rights Reserved
      </div>
      <div class=""credits"">
        <!-- All the links in the footer should remain intact. -->
        <!-- You can delete the links only if you purchased the pro versio");
                WriteLiteral(@"n. -->
        <!-- Licensing information: https://bootstrapmade.com/license/ -->
        <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/delicious-free-restaurant-bootstrap-theme/ -->
        Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
      </div>
    </div>
  </footer><!-- End Footer -->

  <a href=""#"" class=""back-to-top d-flex align-items-center justify-content-center""><i class=""bi bi-arrow-up-short""></i></a>

  <!-- Vendor JS Files -->
  <script src=""../assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
  <script src=""../assets/vendor/glightbox/js/glightbox.min.js""></script>
  <script src=""../assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
  <script src=""../assets/vendor/swiper/swiper-bundle.min.js""></script>
  <script src=""../assets/vendor/php-email-form/validate.js""></script>

  <!-- Template Main JS File -->
  <script src=""../assets/js/main.js""></script>
    ");
#nullable restore
#line 132 "C:\Users\romua\Downloads\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master - connexion deconnexion\JFR-INNOV-master\appmvc_projet2\Views\Shared\Layout.cshtml"
Write(RenderSection("Scripts", required:false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
