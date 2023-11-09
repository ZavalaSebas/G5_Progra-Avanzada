using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CarrosController : ApiController
    {
        //-------------------------------------------------------------------
        [HttpPost]
        [Route("AnadirCarro")]
        public string AnadirCarro(CarrosEnt entidad)
        {
            using (var context = new ProyectoBDEntities())
            {
                try
                {
                    carros carro = new carros();
                    carro.marca = entidad.marca;
                    carro.modelo = entidad.modelo;
                    carro.annio = entidad.annio;
                    carro.precio = entidad.precio;
                    carro.imagen = entidad.imagen;
                    carro.IdPais = entidad.IdPais;
                    carro.IdEstado = 1;

                    context.carros.Add(carro);
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
        [Route("ConsultaCarro")]
        public List<CarrosEnt> ConsultaCarro()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from carros in context.carros
                                 join estado in context.estado on carros.IdEstado equals estado.ID
                                 join paises in context.paises on carros.IdPais equals paises.ID
                                 select new CarrosEnt
                                 {
                                     marca = carros.marca,
                                     modelo = carros.modelo,
                                     annio = carros.annio,
                                     precio = (decimal)carros.precio,
                                     imagen = carros.imagen,
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
        //-------------------------------------------------------------------

        //-------------------------------------------------------------------

        //-------------------------------------------------------------------
        
        //-------------------------------------------------------------------
        
    }
}
