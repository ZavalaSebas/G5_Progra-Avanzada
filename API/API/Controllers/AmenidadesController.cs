using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AmenidadesController : ApiController
    {
        //-------------------------------------------------------------------
        [HttpGet]
        [Route("Amenidades")]
        public List<System.Web.Mvc.SelectListItem> Amenidades()
        {
            try
            {
                using (var context = new ProyectoBDEntities1())
                {
                    var datos = (from x in context.amenidades
                                 select x).ToList();

                    var result = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        result.Add(new System.Web.Mvc.SelectListItem
                        {
                            Value = item.ID.ToString(),
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
    }
}
