using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ResenasController : ApiController
    {
        [HttpPost]
        [Route("AgregarResena")]
        public string AgregarResena(ResenaEnt entidad)
        {
            using (var context = new ProyectoBDEntities())
            {
                try
                {
                    resennas resena = new resennas();
                    resena.titulo = entidad.Titulo;
                    resena.descripcion = entidad.Descripcion;
                    resena.puntuacion = entidad.Puntuacion;
                    resena.IdUser = entidad.IdUsuario;
                    resena.IdHotel = entidad.IdHotel;

                    context.resennas.Add(resena);
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
        [Route("ConsultarResenas")]
        public List<ResenaEnt> ConsultarResenas()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from resena in context.resennas
                                 select new ResenaEnt
                                 {
                                     Id = resena.ID,
                                     Titulo = resena.titulo,
                                     Descripcion = resena.descripcion,
                                     Puntuacion = (decimal)resena.puntuacion,
                                     IdUsuario = resena.IdUser,
                                     IdHotel = resena.IdHotel
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
