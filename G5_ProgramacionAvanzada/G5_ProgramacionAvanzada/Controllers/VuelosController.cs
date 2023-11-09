using G5_ProgramacionAvanzada.Entities;
using G5_ProgramacionAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class VuelosController : Controller
    {
        VuelosModel MV = new VuelosModel();
        PaisesModel MP = new PaisesModel();


        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult AnadirVuelo()
        {
            ViewBag.Paises = MP.Paises();
            return View();
        }


        [HttpPost]
        public ActionResult AnadirVuelo(VuelosEnt entidad)
        {
            string respuesta = MV.AnadirVuelo(entidad);

            if (respuesta == "ok")
            {
                return RedirectToAction("ConsultaVuelos", "Vuelos");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        //-------------------------------------------------------------------

        [HttpGet]
        public ActionResult ConsultaVuelos()
        {
            var datos = MV.ConsultaVuelos();
            return View(datos);
        }
        //-------------------------------------------------------------------

        public ActionResult EditarVuelos()
        {
            return View();
        }
        //-------------------------------------------------------------------


        public ActionResult EliminarVuelos()
        {
            return View();
        }
    }
}