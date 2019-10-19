using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Hemma.API.Controllers.LoginController
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public IHttpActionResult login(string username, string password)
        {
            try
            {
                //TODO: Inlogg för att komma in på sites. 
                return null;
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}