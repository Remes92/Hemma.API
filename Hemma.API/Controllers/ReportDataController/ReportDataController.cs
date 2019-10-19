using System;
using System.Web.Http;

namespace Hemma.API.Controllers.ReportDataController
{
    public class ReportDataController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                string k = "hej";
                return Ok(k);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
