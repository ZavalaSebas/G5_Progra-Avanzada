using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PaisController : ApiController
    {
        [HttpGet]
        [Route("Paises")]
        public List<System.Web.Mvc.SelectListItem> Paises()
        {
            try
            {
                using (var context = new ProyectoBDEntities())
                {
                    var datos = (from x in context.paises
                                 select x).ToList();

                    var result = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        result.Add(new System.Web.Mvc.SelectListItem
                        {
                            Value = item.ID.ToString(),
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