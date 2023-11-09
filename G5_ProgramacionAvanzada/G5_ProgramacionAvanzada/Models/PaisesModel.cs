﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using System.Web.Mvc;

namespace G5_ProgramacionAvanzada.Models
{
    public class PaisesModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];

        //-------------------------------------------------------------------
        public List<SelectListItem> Paises()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "Paises";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
            }
        }
    }
}