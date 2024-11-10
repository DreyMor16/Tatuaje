using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EclipseTatuaje.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FormularioArtistas()
        {
            return View();
        }


        public ActionResult FormularioUsuarios()
        {
            return View();
        }
    }
}