using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Entities;


namespace API.Controllers
{
    public class HotelesController : ApiController
    {
        //-------------------------------------------------------------------
        [HttpPost]
        [Route("AnadirHotel")]
        public string AnadirHotel(HotelesEnt entidad)
        {
            using (var context = new ProyectoBDEntities1())
            {
                try
                {
                    hoteles hotel = new hoteles();
                    hotel.nombre = entidad.nombre;
                    hotel.direccion = entidad.direccion;
                    hotel.descripcion = entidad.descripcion;
                    hotel.precio = entidad.precio;
                    hotel.imagen = entidad.imagen;
                    hotel.IdAmenidades = entidad.IdAmenidades;
                    hotel.IdPais = entidad.IdPais;
                    hotel.IdEstado = entidad.IdEstado;

                    context.hoteles.Add(hotel);
                    context.SaveChanges();

                    return "ok";
                }
                catch (Exception)
                {
                    return "Error";
                }


            }
        }
        //-------------------------------------------------------------------
        [HttpGet]
        [Route("ConsultaHotel")]
        public List<HotelesEnt> ConsultaHotel()
        {
            try
            {
                using (var context = new ProyectoBDEntities1())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from hoteles in context.hoteles
                                 join estado in context.estado on hoteles.IdEstado equals estado.ID
                                 join paises in context.paises on hoteles.IdPais equals paises.ID
                                 join amenidades in context.amenidades on hoteles.IdAmenidades equals amenidades.ID
                                 select new HotelesEnt
                                 {
                                     nombre = hoteles.nombre,
                                     direccion = hoteles.direccion,
                                     descripcion = hoteles.descripcion,
                                     precio = hoteles.precio,
                                     imagen = hoteles.imagen,
                                     IdEstado = estado.ID,
                                     IdAmenidades = amenidades.ID,
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
        //-------------------------------------------------------------------

        //-------------------------------------------------------------------

        //-------------------------------------------------------------------
       
    }
}
