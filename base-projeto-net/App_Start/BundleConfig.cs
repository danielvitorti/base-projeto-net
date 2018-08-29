using System.Web;
using System.Web.Optimization;

namespace base_projeto_net
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {   

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/adminlte.min.js",
                      "~/Scripts/jquery.sparkline.min.js",
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery-jvectormap-world-mill-en.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/Chart.js",
                      "~/Scripts/dashboard2.js",
                      "~/Scripts/demo.js"

                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css", //ok
                      "~/Content/font-awesome.min.css", //ok
                      "~/Content/ionicons.min.css", //ok
                      "~/Content/jquery-jvectormap.min.css", //ok
                      "~/Content/AdminLTE.min.css",
                      "~/Content/_all-skins.min.css.min.css" //ok

                      ));
        }
    }
}
