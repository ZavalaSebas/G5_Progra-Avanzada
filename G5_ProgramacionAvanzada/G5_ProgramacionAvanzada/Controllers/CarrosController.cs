﻿using G5_ProgramacionAvanzada.Entities;
using G5_ProgramacionAvanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class CarrosController : Controller
    {
        CarrosModel MC = new CarrosModel();
        PaisesModel MP = new PaisesModel();


        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult AnadirCarro()
        {
            ViewBag.Paises = MP.Paises();
            return View();
        }

        [HttpPost]
        public ActionResult AnadirCarro(CarrosEnt entidad)
        {
            ViewBag.Paises = MP.Paises();
            string respuesta = MC.AnadirCarro(entidad);

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
        public ActionResult ConsultaCarro()
        {
            var datos = MC.ConsultaCarro();
            return View(datos);
        }

        //-------------------------------------------------------------------

        public ActionResult EditarCarro()
        {
            return View();
        }
        //-------------------------------------------------------------------

        public ActionResult EliminarCarro()
        {
            return View();
        }
       
    }
}