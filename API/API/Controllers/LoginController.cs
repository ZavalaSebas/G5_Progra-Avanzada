using API.Entities;
using Microsoft.Ajax.Utilities;
using System;
using System.Linq;
using System.Net.Mail;
using System.Web.Http;

namespace API.Controllers
{
    public class LoginController : ApiController
    {
        Utilitarios util = new Utilitarios();

        //-------------------------------------------------------------------

        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            using (var context = new ProyectoBDEntities1())
            {
                try
                {
                    usuarios user = new usuarios();
                    user.username = entidad.username;
                    user.nombre = entidad.nombre;
                    user.apellidos = entidad.apellidos;
                    user.email = entidad.email;
                    user.contrasenna = entidad.contrasenna;
                    user.IdEstado = 1;
                    user.IdRol = 2;

                    context.usuarios.Add(user);
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
        [HttpPost]
        [Route("IniciarSesion")]
        public usuarios IniciarSesion(UsuarioEnt entidad)
        {
            try
            {

                using (var context = new ProyectoBDEntities1())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from x in context.usuarios
                                 where x.email == entidad.email
                                 && x.contrasenna == entidad.contrasenna
                                 && x.IdEstado == 1
                                 select x).FirstOrDefault();

                    return datos;

                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        //-------------------------------------------------------------------


        [HttpPost]
        [Route("RecuperarCuenta")]
        public string RecuperarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoBDEntities1())
                {
                    var datos = context.usuarios
                      .Where(u => u.email == entidad.email)
                      .FirstOrDefault();

                    if (datos != null)
                    {
                        string contenido = "Estimad@: " + datos.nombre + ". Contraseña: " + datos.contrasenna;
                        util.EnviarCorreo(datos.email, "Contraseña de Acceso", contenido);
                        return "OK";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


    }
}
