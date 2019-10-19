using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Hemma.Entities.Entities;
using Newtonsoft.Json;

namespace Hemma.API.Controllers.PersonController
{
    [RoutePrefix("api")]
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

        [Route("person/byname")]
        [HttpGet]
        public IHttpActionResult GetPersonByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();
            try
            {
                var person = Hemma.PersonInformation.Business.Person.GetPerson.GetPersonByFirstName(name);
                if (person == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(person);
                }
            }
            catch
            {
                return null;
            }
        }

        [Route("person/byid")]
        [HttpGet]
        public IHttpActionResult GetPersonById(int id)
        {
            if (id == null)
                return BadRequest();
            try
            {
                var person = Hemma.PersonInformation.Business.Person.GetPerson.GetPersonById(id);
                if (person == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(person);
                }
            }
            catch
            {
                return null;
            }
        }

        [Route("person/add")]
        [HttpPost]
        public IHttpActionResult PostAddPerson(string firstname, string lastname)
        {
            try
            {
                Hemma.PersonInformation.Business.Person.GetPerson.addPerson(firstname, lastname);
            }
            catch
            {

            }
            return Ok();
        }
    }
}