using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLOANDBUS.Controllers
{
    public class PlantaController : Controller
    {
        //
        // GET: /Planta/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }
	}
}