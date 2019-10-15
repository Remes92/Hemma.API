using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemma.PersonInformation.Business.Person
{
    public class GetPerson
    {
        public static List<Entities.Person> GetAllPersons()
        {
            var persons = Repository.GetPerson.GetAll();
            return persons;
        }

        public static Entities.Person GetPersonByFirstName(string name)
        {
            return Repository.GetPerson.GetPersonByFirstName(name);
        }
    }
}
