using G5_ProgramacionAvanzada.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Models
{
    public class ToursModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        public string AnadirTour(ToursEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "AnadirTour";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
    }
}