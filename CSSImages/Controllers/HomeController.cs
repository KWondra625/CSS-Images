using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSSImages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "A brief discussion of Sprites vs. DataURIs";

            return View();
        }

        public ActionResult Sprite()
        {
            ViewBag.Message = "Images using a sprite.";

            return View();
        }

        public ActionResult DataURIs()
        {
            ViewBag.Message = "Images using DataURIs.";

            return View();
        }
    }
}
