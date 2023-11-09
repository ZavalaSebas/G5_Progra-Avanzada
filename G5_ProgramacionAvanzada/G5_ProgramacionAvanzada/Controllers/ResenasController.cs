using G5_ProgramacionAvanzada.Entities;
using G5_ProgramacionAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class ResenasController : Controller
    {
        ResenasModel MR = new ResenasModel();

        [HttpGet]
        public ActionResult AgregarResena()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarResena(ResenaEnt entidad)
        {
            string respuesta = MR.AgregarResena(entidad);

            if (respuesta == "ok")
            {
                return RedirectToAction("ConsultaHotel", "Hoteles");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar la reseña.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult ConsultarResenas()
        {
            var datos = MR.ConsultarResenas();
            return View(datos);
        }

    }
}
