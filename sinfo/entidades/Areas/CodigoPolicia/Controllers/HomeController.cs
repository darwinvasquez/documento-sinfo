using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entidades.Areas.CodigoPolicia.Controllers
{
    public class HomeController : Controller
    {
        // GET: CodigoPolicia/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}