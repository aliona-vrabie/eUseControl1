using System;
using System.Web.Optimization;
using System.Web;
using System.Collections.Generic;
using System.Linq;
namespace eUseControl1.App_Start

{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Responsive styles
            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include(
            "~/Content/responsive.css", new CssRewriteUrlTransform()));
            // Slick-theme styles
            bundles.Add(new StyleBundle("~/bundles/slick/css").Include(
            "~/Content/slick.css", new CssRewriteUrlTransform()));
            // Slick styles
            bundles.Add(new StyleBundle("~/bundles/slick-theme/css").Include(
            "~/Content/slick-theme.css", new CssRewriteUrlTransform()));
            // Personal styles
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
            "~/Content/style.css", new CssRewriteUrlTransform()));
            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
            "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
            "~/Scripts/bootstrap.min.js"));
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
            "~/Scripts/jquery-3.3.1.min.js"));
            // Unobtrusive
            bundles.Add(new ScriptBundle("~/bundles/unobtrusive/js").Include(
            "~/Scripts/jquery.unobtrusive-ajax.min.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
            "~/Scripts/jquery.validate.min.js"));
            // Popper
            bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
            "~/Scripts/popper.min.js"));
            // Slick
            bundles.Add(new ScriptBundle("~/bundles/slick/js").Include(
            "~/Scripts/slick.js"));
            // Filtering
            bundles.Add(new ScriptBundle("~/bundles/filtering/js").Include(
            "~/Scripts/filtering.js"));
            bundles.Add(new StyleBundle("~/bundles/site").Include(
          "~/Content/Site.css"));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/bundles/bootstrap.css"));
            bundles.Add(new StyleBundle("~/bundles/styles/css").Include(
               "~/bundles/styles.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/animate/css").Include(
               "~/bundles/assets/css/animate.css"));
            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include(
               "~/bundles/magnific-popup.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/aos/css").Include(
              "~/bundles/assets/css/aos.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/bootstrap-datepicker/css").Include(
              "~/bundles/assets/css/bootstrap-datepicker.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/jquery.timepicker/css").Include(
              "~/bundles/assets/css/jquery.timepicker.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/flaticon/css").Include(
              "~/bundles/assets/css/flaticon.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/icomoon/css").Include(
              "~/bundles/assets/css/icomoon.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/bootstrap.min.css").Include(
             "~/bundles/assets/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/icomoon.min.css").Include(
             "~/bundles/assets/css/icomoon.min.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/open-iconic-bootstrap.min.css").Include(
             "~/bundles/assets/css/open-iconic-bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/owl.carousel.min.css").Include(
             "~/bundles/assets/css/owl.carousel.min.css"));

        }
    }
}
