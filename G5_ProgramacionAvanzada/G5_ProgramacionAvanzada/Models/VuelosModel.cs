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
    public class VuelosModel
    {
        public string ruta = ConfigurationManager.AppSettings["ruta"];
        PaisesModel MP = new PaisesModel();
        //*********************(Añadir Vuelo)**********************
        public string AnadirVuelo(VuelosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string urlApi = ruta + "AnadirVuelo";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        //*********************(Editar Vuelo)**********************
        public string EditarVuelo(VuelosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EditarVuelo";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        //*********************(Eliminar Vuelo)**********************
        public string EliminarVuelo(VuelosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "EliminarVuelo";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        //*********************(Consulta Vuelos)**********************
        public List<VuelosEnt> ConsultaVuelos()
        {
            using (var client = new HttpClient())
            {
                var urlApi = ruta + "ConsultaVuelo";
                var res = client.GetAsync(urlApi).Result;
                var vuelos = res.Content.ReadFromJsonAsync<List<VuelosEnt>>().Result;

                // Obtener la lista de países para asociar el nombre del país con el ID
                var paises = MP.Paises();

                // Asignar el nombre del país a cada vuelo
                for (int i = 0; i < vuelos.Count; i++)
                {
                    VuelosEnt vuelo = vuelos[i];
                    vuelo.NombrePais = paises.FirstOrDefault(p => p.Value == vuelo.IdPais.ToString())?.Text;
                }

                return vuelos;
            }
        }



    }
}