using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Hemma.API.Controllers.PersonController
{
    
    public class PersonController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            Hemma.PersonInformation.Business.Person.GetPerson.test();
            //Get all Persons registred. 
            return null;
        }

        [HttpGet]
        public IHttpActionResult GetPerson(string name)
        {
            return null;
        }

        [HttpPost]
        [Route("Person/AddPerson")]
        public IHttpActionResult AddPerson(string name)
        {
            try
            {

            }
            catch
            {

            }
            return null;
        }
    }
}