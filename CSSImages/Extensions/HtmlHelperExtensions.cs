using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace CSSImages.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString BundleAndRenderScript(this HtmlHelper helper, string path, params string[] urls)
        {
            var bundle = new ScriptBundle(path).Include(urls);
            BundleTable.Bundles.Add(bundle);

            return Scripts.Render(path);
        }

        public static IHtmlString BundleAndRenderStyle(this HtmlHelper helper, string path, params string[] urls)
        {
            var bundle = new StyleBundle(path).Include(urls);
            BundleTable.Bundles.Add(bundle);

            return Styles.Render(path);
        }
    }
}