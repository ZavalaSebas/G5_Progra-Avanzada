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
    public class HotelesModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        //-------------------------------------------------------------------

        public string AnadirHotel(HotelesEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "AnadirHotel";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public string EditarHotel(HotelesEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EditarHotel";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        //-------------------------------------------------------------------
        public string EliminarHotel(HotelesEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EliminarHotel";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        //-------------------------------------------------------------------
        public List<HotelesEnt> ConsultaHotel()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "ConsultaHotel";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<HotelesEnt>>().Result;
            }
        }

    }
}