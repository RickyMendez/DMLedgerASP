using System.Web;
using System.Web.Optimization;

namespace DMLedgerASP
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/DataTables-1.10.12/media/js/jquery.dataTables.js",
                        "~/Scripts/DataTables-1.10.12/media/js/dataTables.bootstrap.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/toastr.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/services").Include(
                        "~/Scripts/MyScripts/userServices.js",
                        "~/Scripts/DataTables-1.10.12/extensions/CellEdit/dataTables.editCell.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-slate.css",
                      "~/Content/site.css",
                      "~/Content/DataTables-1.10.12/media/css/dataTables.bootstrap.css",
                      "~/Content/toastr.css"));
        }
    }
}
