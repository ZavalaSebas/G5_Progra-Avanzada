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
            using (var context = new ProyectoBDEntities())
            {
                try
                {
                    hoteles hotel = new hoteles();
                    hotel.nombre = entidad.nombre;
                    hotel.direccion = entidad.direccion;
                    hotel.pais = entidad.pais;
                    hotel.puntuacion = entidad.puntuacion;
                    hotel.descripcion = entidad.descripcion;
                    hotel.precio = entidad.precio;
                    hotel.imagen = entidad.imagen;
                    hotel.IdAmenidades = entidad.IdAmenidades;


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
                using (var context = new ProyectoBDEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from hoteles in context.hoteles
                                 join amenidades in context.amenidades on hoteles.IdAmenidades equals amenidades.IDAmenidades
                                 select new HotelesEnt
                                 {
                                     nombre = hoteles.nombre,
                                     pais = hoteles.pais,
                                     direccion = hoteles.direccion,
                                     puntuacion = hoteles.puntuacion,
                                     descripcion = hoteles.descripcion,
                                     precio = hoteles.precio,
                                     imagen = hoteles.imagen,
                                     IdAmenidades = amenidades.IDAmenidades
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
        [HttpGet]
        [Route("Amenidades")]
        public List<System.Web.Mvc.SelectListItem> Amenidades()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    var datos = (from x in context.amenidades
                                 select x).ToList();

                    var result = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        result.Add(new System.Web.Mvc.SelectListItem
                        {
                            Value = item.IDAmenidades.ToString(),
                            Text = item.nombre
                        });
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        //-------------------------------------------------------------------
        [HttpGet]
        [Route("Paises")]
        public List<System.Web.Mvc.SelectListItem>Paises()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    var datos = (from x in context.Paises
                                 select x).ToList();

                    var result = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        result.Add(new System.Web.Mvc.SelectListItem
                        {
                            Value = item.IDPais.ToString(),
                            Text = item.Nombre
                        });
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
