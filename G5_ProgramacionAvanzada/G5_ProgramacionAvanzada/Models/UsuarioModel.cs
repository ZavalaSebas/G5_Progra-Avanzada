using G5_ProgramacionAvanzada.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

namespace G5_ProgramacionAvanzada.Models
{
    public class UsuarioModel
    {
        public UsuarioEnt IniciarSesion(UsuarioEnt entidad)
        {
            //HTTPCLIENT SIRVE PARA LLAMADAS A PROTOCOLOS DE HTTP
            using (var client = new HttpClient())
            {
                var urlApi = "https://localhost:44392/IniciarSesion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<UsuarioEnt>().Result;               
            }
        }
        public string RegistrarCuenta(UsuarioEnt entidad) 
        {
            using (var client = new HttpClient())
            {
                var urlApi = "https://localhost:44392/RegistrarCuenta";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadAsStringAsync().Result;
            }
        }
        public void RecuperarCuenta(UsuarioEnt entidad)
        {

        }
    }
}