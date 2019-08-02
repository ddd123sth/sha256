using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Canvas.Controllers
{
    public class CanvasController : Controller
    {
        // GET: Canvas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Canvas_View()
        {
            return View();
        }
    }
}