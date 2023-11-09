using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ToursController : ApiController
    {
        [HttpPost]
        [Route("AnadirTour")]
        public string AnadirTour(ToursEnt entidad)
        {
            using (var context = new ProyectoBDEntities())
            {
                try
                {
                    tours tour = new tours();
                    tour.nombre = entidad.nombre;
                    tour.descripcion = entidad.descripcion;
                    tour.imagen = entidad.imagen;
                    tour.precio = entidad.precio;
                    tour.IdPais = entidad.IdPais;
                    tour.IdDestino = entidad.IdDestino;
                    tour.IdEstado = 2;

                    context.tours.Add(tour);
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
        [Route("ConsultaTours")]
        public List<tours> ConsultaTours()
        {
            using (var context = new ProyectoBDEntities())
            {
                return context.tours.ToList();
            }
        }
    }
}
