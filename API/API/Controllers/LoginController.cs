using API.Entities;
using Microsoft.Ajax.Utilities;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            using (var context = new ProyectoPrograAvanzadaEntities1())
            {
                TUsuario user = new TUsuario();
                user.Nombre = entidad.Nombre;
                user.Apellidos = entidad.Apellidos;
                user.Correo = entidad.Correo;
                user.Contrasenna = entidad.Contrasenna;
                user.Estado = entidad.Estado;
                user.Rol = entidad.Rol;

                context.TUsuario.Add(user);
                context.SaveChanges();

                return "Registro realizado correctamente";
            }
        }

        //ESTE DEBERIA SER DE TIPO GET POR QUE ES CONSULTA PERO PARA QUE NO VIAJE POR URL SE HACE POST, POR SEGURIDAD
        [HttpPost]
        [Route("IniciarSesion")]
        public TUsuario IniciarSesion(UsuarioEnt entidad)
        {
            using (var context = new ProyectoPrograAvanzadaEntities1())
            {
                var datos = (from x in context.TUsuario
                             where x.Correo == entidad.Correo
                             && x.Contrasenna == entidad.Contrasenna
                             && x.Estado == true
                             select x).FirstOrDefault();

                return datos;

            }
        }

    }
}
