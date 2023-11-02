using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using G5_ProgramacionAvanzada.Entities;
using G5_ProgramacionAvanzada.Models;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class LoginController : Controller
    {
        UsuarioModel modelUsuario = new UsuarioModel();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            var respuesta = modelUsuario.IniciarSesion(entidad);
            return View();
        }

        [HttpGet]
        public ActionResult RegistrarCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarCuenta(UsuarioEnt entidad)
        {
            var respuesta = modelUsuario.RegistrarCuenta(entidad);
            return View();
        }
        [HttpGet]
        public ActionResult RecuperarCuenta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            modelUsuario.RecuperarCuenta(entidad);
            return View();
        }
    }
}