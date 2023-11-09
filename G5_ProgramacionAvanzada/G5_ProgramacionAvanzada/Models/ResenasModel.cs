using G5_ProgramacionAvanzada.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Json;

namespace G5_ProgramacionAvanzada.Models
{
    public class ResenasModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        public string AgregarResena(ResenaEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "AgregarResena";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<ResenaEnt> ConsultarResenas()
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "ConsultarResenas";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<ResenaEnt>>().Result;
            }
        }

    }
}
