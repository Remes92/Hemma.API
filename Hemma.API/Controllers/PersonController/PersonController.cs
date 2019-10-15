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
            var persons = Hemma.PersonInformation.Business.Person.GetPerson.GetAllPersons();
            if (persons == null)
            {
                return BadRequest();
            }
            else if (persons.Count < 1)
            {
                return StatusCode(System.Net.HttpStatusCode.NoContent);
            }
            else
            {
                return Ok(persons);
            }
        }

        [HttpGet]
        //[Route("person/byname")]
        public IHttpActionResult GetPersonByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();

            var person = Hemma.PersonInformation.Business.Person.GetPerson.GetPersonByFirstName(name);

            if(person != null)
            {
                return Ok(person);
            }
            return StatusCode(System.Net.HttpStatusCode.NoContent);


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