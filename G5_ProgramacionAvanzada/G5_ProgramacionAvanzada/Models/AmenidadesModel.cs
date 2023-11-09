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
    public class AmenidadesModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];
        //-------------------------------------------------------------------
        public List<SelectListItem> Amenidades()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "Amenidades";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
            }
        }
    }
}