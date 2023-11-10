using G5_ProgramacionAvanzada.Entities;
using G5_ProgramacionAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class ToursController : Controller
    {

        ToursModel MT = new ToursModel();
        // GET: Tours
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ConsultaTours()
        {
            var datosTours = MT.ConsultaTours();
            return View(datosTours);
        }

        [HttpGet]
        public ActionResult AnadirTour()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AnadirTour(ToursEnt entidad)
        {
            ToursModel toursModel = new ToursModel();
            string respuesta = toursModel.AnadirTour(entidad);

            if (respuesta == "ok")
            {
                
                return RedirectToAction("ConsultaTours", "Tours");
            }
            else
            {
                
                ViewBag.ErrorMessage = "Hubo un error al agregar el tour.";
                return View(); 
            }
        }

    }
}