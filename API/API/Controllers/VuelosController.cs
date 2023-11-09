using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Entities;

namespace API.Controllers
{
    public class VuelosController : ApiController
    {
        // *********************(Añadir Vuelo)*********************
        [HttpPost]
        [Route("AnadirVuelo")]
        public string AnadirVuelo(VuelosEnt entidad)
        {
            using (var context = new ProyectoBDEntities())
            {
                try
                {
                    vuelos vuelo = new vuelos();
                    vuelo.Fecha = entidad.Fecha;
                    vuelo.precio = entidad.precio;
                    vuelo.IdPais = entidad.IdPais;
                    vuelo.IdEstado = 1;

                    context.vuelos.Add(vuelo);
                    context.SaveChanges();

                    return "ok";
                }
                catch (Exception)
                {
                    return "Error";
                }


            }
        }

        [HttpGet]
        [Route("ConsultaVuelo")]
        public List<VuelosEnt> ConsultaVuelo()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from vuelos in context.vuelos
                                 join estado in context.estado on vuelos.IdEstado equals estado.ID
                                 join paises in context.paises on vuelos.IdPais equals paises.ID
                                 select new VuelosEnt
                                 {
                                     Fecha = vuelos.Fecha,
                                     precio= (decimal)vuelos.precio,
                                     IdEstado = estado.ID,
                                     IdPais = paises.ID
                                 }).ToList();

                    return datos;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }

}