﻿using G5_ProgramacionAvanzada.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

namespace G5_ProgramacionAvanzada.Models
{
    public class UsuarioModel
    {
        //Es el llamao a la ruta guardada en el Web.config
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        //-------------------------------------------------------------------
        public UsuarioEnt IniciarSesion(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "IniciarSesion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<UsuarioEnt>().Result;               
            }
        }
        //-------------------------------------------------------------------

        public string RegistrarCuenta(UsuarioEnt entidad) 
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "RegistrarCuenta";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public string RecuperarCuenta(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "RecuperarCuenta";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public List<UsuarioEnt> ListaUsuarios()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "ListaUsuarios";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<UsuarioEnt>>().Result;
            }
        }
    }
}