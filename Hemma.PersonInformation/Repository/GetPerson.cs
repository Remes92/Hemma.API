using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Hemma.Entities.Entities;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Hemma.PersonInformation.Repository
{
    public class GetPerson
    {

        public static Person GetPersonByFirstName(string name)
        {
            using(var db = new Hemma.Context.Context.HemmadbContext())
            {
                var p = db.Person.Where(x => x.firstname.Equals(name)).FirstOrDefault();
                return p;
            }
        }

        public static Person GetPersonById(int id)
        {
            using (var db = new Hemma.Context.Context.HemmadbContext())
            {
                var p = db.Person.Where(x => x.id.Equals(id)).FirstOrDefault();
                return p;
            }
        }

        public static void createPerson(string fname, string lname)
        {
            using(var db = new Hemma.Context.Context.HemmadbContext())
            {
                db.Database.EnsureCreated();
                var p = new Person
                {
                    firstname = fname,
                    lastname = lname
                };
                db.Person.Add(p);

                db.SaveChanges();
            }
        }

        public static List<Person> GetAll()
        {
            using(var db = new Hemma.Context.Context.HemmadbContext())
            {
                var persons = db.Person.ToList();
                return persons;
            }   
        }
    }
}
