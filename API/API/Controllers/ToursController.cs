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
        public IHttpActionResult ConsultaTours()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    var datos = (from tour in context.tours
                                 join estado in context.estado on tour.IdEstado equals estado.ID
                                 join pais in context.paises on tour.IdPais equals pais.ID
                                 join destino in context.destino on tour.IdDestino equals destino.ID
                                 select new ToursEnt
                                 {
                                     
                                     nombre = tour.nombre,
                                     descripcion = tour.descripcion,
                                     precio = (decimal)tour.precio,
                                     imagen = tour.imagen,
                                     IdEstado = estado.ID,
                                     IdPais = pais.ID,
                                     IdDestino = destino.ID
                                 }).ToList();

                    return Ok(datos);
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return InternalServerError();
            }
        }
    }
}
