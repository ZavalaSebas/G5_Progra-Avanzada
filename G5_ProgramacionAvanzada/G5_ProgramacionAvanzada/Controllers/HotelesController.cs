using G5_ProgramacionAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class HotelesController : Controller
    {
        HotelesModel modelUsuario = new HotelesModel();

        public ActionResult AnadirHotel()
        {
            return View();
        }
        public ActionResult ConsultaHotel()
        {
            return View();
        }
        public ActionResult EditarHotel()
        {
            return View();
        }
        public ActionResult EliminarHotel()
        {
            return View();
        }
        public ActionResult Amenidades()
        {
            var datos = modelUsuario.Amenidades();
            return View(datos);
        }
    }
}