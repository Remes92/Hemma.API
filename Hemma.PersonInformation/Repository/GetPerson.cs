using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Hemma.PersonInformation.Entities;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Hemma.PersonInformation.Repository
{
    public class GetPerson
    {
        public static List<Person> GetAll()
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["HemmaDb"].ConnectionString);
            con.Open();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand("Select * FROM Persons", con);
            var reader = cmd.ExecuteReader();


            List<Person> personList = new List<Person>();
            while (reader.Read())
            {
                Person p = new Person();
                p.ID = Int32.Parse(reader["id"].ToString());
                p.Firstname = reader["Firstname"].ToString();
                p.Lastname = reader["Lastname"].ToString();
                personList.Add(p);
            }
            con.Close();
            return personList;
        }

        public static Person GetPersonByFirstName(string name)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["HemmaDb"].ConnectionString);
            var cmd = new MySql.Data.MySqlClient.MySqlCommand("Select * FROM Persons WHERE Firstname = @name", con);
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@name";
            param.Value = name;
            cmd.Parameters.Add(param);
            con.Open();

            var reader = cmd.ExecuteReader();
            reader.Read();
            Person p = new Person();
            p.ID = Int32.Parse(reader["id"].ToString());
            p.Firstname = reader["Firstname"].ToString();
            p.Lastname = reader["Lastname"].ToString();

            con.Close();
            return p;
        }
    }
}
