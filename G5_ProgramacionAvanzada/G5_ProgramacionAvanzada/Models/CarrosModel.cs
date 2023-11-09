using G5_ProgramacionAvanzada.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Models
{
    public class CarrosModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        //-------------------------------------------------------------------

        public string AnadirCarro(CarrosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "AnadirCarro";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public string EditarCarro(CarrosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EditarCarro";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public string EliminarCarro(CarrosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EliminarCarro";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        //-------------------------------------------------------------------
        public List<CarrosEnt> ConsultaCarro()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "ConsultaCarro";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<CarrosEnt>>().Result;
            }
        }

    }
}