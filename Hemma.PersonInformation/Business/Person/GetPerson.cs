using System;
using System.Collections.Generic;

namespace Hemma.PersonInformation.Business.Person
{
    public class GetPerson
    {
        public static List<Entities.Entities.Person> GetAllPersons()
        {
            var persons = Repository.GetPerson.GetAll();
            return persons;
        }

        public static Entities.Entities.Person GetPersonByFirstName(string name)
        {
            return Repository.GetPerson.GetPersonByFirstName(name);
        }

        public static Entities.Entities.Person GetPersonById(int id)
        {
            return Repository.GetPerson.GetPersonById(id);
        }

        public static void addPerson(string firstname, string lastname)
        {
            Repository.GetPerson.createPerson(firstname,lastname);
        }
    }
}
