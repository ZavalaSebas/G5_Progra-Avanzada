using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class PaginasInfoController : Controller
    {
        // GET: PaginasInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SobreNosotros()
        {
            return View();
        }
        public ActionResult PoliticasPrivacidad()
        {
            return View();
        }
    }
}