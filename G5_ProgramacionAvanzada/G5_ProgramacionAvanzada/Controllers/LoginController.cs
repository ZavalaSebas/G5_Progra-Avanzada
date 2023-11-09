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
        //-------------------------------------------------------------------
        public ActionResult Index()
        {
            return View();
        }
        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult ListaUsuarios()
        {
            var datos = modelUsuario.ListaUsuarios();
            return View(datos);
        }
        //-------------------------------------------------------------------

        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            var respuesta = modelUsuario.IniciarSesion(entidad);
            if (respuesta != null)
            {
                return RedirectToAction("Index", "Login");
                
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido validar su informacion";
                return View();
            }

        }
        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult RegistrarCuenta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarCuenta(UsuarioEnt entidad)
        {
            entidad.IdEstado = 1;
            entidad.IdRol = 2;
            string respuesta = modelUsuario.RegistrarCuenta(entidad);

            if (respuesta == "ok")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su informacion";
                return View();
            }
        }
        //-------------------------------------------------------------------
        [HttpGet]
        public ActionResult RecuperarCuenta()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            string respuesta = modelUsuario.RecuperarCuenta(entidad);
            if (respuesta == "ok")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido recuperar su informacion";
                return View();
            }
        }
    }
}
