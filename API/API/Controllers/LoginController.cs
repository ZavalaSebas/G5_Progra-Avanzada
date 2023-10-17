using API.Entities;
using Microsoft.Ajax.Utilities;
using System.Web.Http;

namespace API.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            using (var context = new ProyectoPrograAvanzadaEntities())
            {
                usuarios user = new usuarios();
                user.Nombre = entidad.Nombre;
                user.Username = entidad.Username;
                user.Correo = entidad.Correo;
                user.Contrasenna = entidad.Contrasenna;

                context.usuarios.Add(user);
                context.SaveChanges();

                return "Registro exitoso";

            }
        }

    }
}
