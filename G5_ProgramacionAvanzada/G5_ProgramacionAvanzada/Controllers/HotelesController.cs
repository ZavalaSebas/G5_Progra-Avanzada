using G5_ProgramacionAvanzada.Entities;
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
        HotelesModel MH = new HotelesModel();

        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult AnadirHotel()
        {
            ViewBag.Amenidades = MH.Amenidades();
            ViewBag.Paises = MH.Paises();
            return View();
        }

        [HttpPost]
        public ActionResult AnadirHotel(HotelesEnt entidad)
        {
            string respuesta = MH.AnadirHotel(entidad);

            if (respuesta == "ok")
            {
                return RedirectToAction("ConsultaHotel", "Hoteles");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        //-------------------------------------------------------------------

        [HttpGet]
        public ActionResult ConsultaHotel()
        {
            var datos = MH.ConsultaHotel();
            return View(datos);
        }

        //-------------------------------------------------------------------

        public ActionResult EditarHotel()
        {
            return View();
        }
        //-------------------------------------------------------------------

        public ActionResult EliminarHotel()
        {
            return View();
        }
        //-------------------------------------------------------------------

        public ActionResult Amenidades()
        {
            var datos = MH.Amenidades();
            return View(datos);
        }
        //-------------------------------------------------------------------

        public ActionResult Paises()
        {
            var datos = MH.Paises();
            return View(datos);
        }
    }
}