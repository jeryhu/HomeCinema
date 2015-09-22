using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace HomeCinema.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/Vendors/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/vendor/jquery/dist/jquery.js",
                "~/Scripts/vendor/bootstrap/dist/js/bootstrap.js",
                "~/Scripts/vendor/toastr/toastr.js",
                "~/Scripts/vendor/raty/lib/jquery.raty.js",
                "~/Scripts/vendor/respond/dest/respond.src.js",
                "~/Scripts/vendor/angular/angular.js",
                "~/Scripts/vendor/angular-base64/angular-base64.js",
                "~/Scripts/vendor/angular-file-upload/dist/angular-file-upload.min.js",
                "~/Scripts/vendor/angucomplete-alt/dist/angucomplete-alt.min.js",
                "~/Scripts/vendor/angular-route/angular-route.js",
                "~/Scripts/vendor/angular-cookies/angular-cookies.js",
                "~/Scripts/vendor/angular-bootstrap/ui-bootstrap.js",
                "~/Scripts/vendor/angular-bootstrap/ui-bootstrap-tpls.js",
                "~/Scripts/vendor/tg-angular-validator/dist/angular-validator.js",
                "~/Scripts/vendor/raphael/raphael.js",
                "~/Scripts/vendor/morris.js/morris.js",
                "~/Scripts/vendor/underscore/underscore.js",
                "~/Scripts/vendor/angular-loading-bar/src/loading-bar.js",
                "~/Scripts/vendor/fancybox/source/jquery.fancybox.js",
                "~/Scripts/vendor/fancybox/source/jquery.fancybox.pack.js",
                "~/Scripts/vendor/fancybox/source/helpers/jquery.fancybox-media.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/services/apiService.js",
                "~/Scripts/spa/services/notificationService.js",
                "~/Scripts/spa/services/membershipService.js",
                "~/Scripts/spa/services/fileUploadService.js",
                "~/Scripts/spa/layout/topBar.directive.js",
                "~/Scripts/spa/layout/sideBar.directive.js",
                "~/Scripts/spa/layout/customPager.directive.js",
                "~/Scripts/spa/directives/rating.directive.js",
                "~/Scripts/spa/directives/availableMovie.directive.js",
                "~/Scripts/spa/account/loginCtrl.js",
                "~/Scripts/spa/account/registerCtrl.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/home/indexCtrl.js",
                "~/Scripts/spa/customers/customersCtrl.js",
                "~/Scripts/spa/customers/customersRegCtrl.js",
                "~/Scripts/spa/customers/customerEditCtrl.js",
                "~/Scripts/spa/movies/moviesCtrl.js",
                "~/Scripts/spa/movies/movieAddCtrl.js",
                "~/Scripts/spa/movies/movieDetailsCtrl.js",
                "~/Scripts/spa/movies/movieEditCtrl.js",
                "~/Scripts/spa/controllers/rentalCtrl.js",
                "~/Scripts/spa/rental/rentMovieCtrl.js",
                "~/Scripts/spa/rental/rentStatsCtrl.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/content/css/site.css",
                "~/content/css/bootstrap.css",
                "~/content/css/bootstrap-theme.css",
                 "~/content/css/font-awesome.css",
                "~/content/css/morris.css",
                "~/content/css/toastr.css",
                "~/content/css/jquery.fancybox.css",
                "~/content/css/loading-bar.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
