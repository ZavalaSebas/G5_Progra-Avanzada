﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using G5_ProgramacionAvanzada.Models;

namespace G5_ProgramacionAvanzada.Controllers
{
    public class LoginController : Controller
    {
        Usuario claseUsuario = new Usuario();

        public ActionResult IniciarSesion()
        { 
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}