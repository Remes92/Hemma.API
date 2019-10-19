using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Hemma.API.Controllers.AdminController
{
    public class AdminController : ApiController
    {
        [HttpPost]
        public IHttpActionResult login(string username, string password)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}