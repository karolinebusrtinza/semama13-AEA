using APITecsup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace APITecsup.Controllers
{
    public class PersonController : ApiController
    {
        List<Person> people = new List<Person>();

        
        public PersonController()
        {
            people.Add(new Person { PersonID = 1, LastName = "Cueva", FirstName = "Cristian" });
            people.Add(new Person { PersonID = 2, LastName = "Tapia", FirstName = "Renato" });
            people.Add(new Person { PersonID = 3, LastName = "Romaní", FirstName = "Juan" });
            people.Add(new Person { PersonID = 4, LastName = "Lapadula", FirstName = "Gianluca" });
        }
        // GET: Person
        public IEnumerable<Person> Get()
        {
            var response = people;
            return response;
        }

        public Person Get(int id)
        {
            var response = people.Where(x => x.PersonID == id).FirstOrDefault();
            return response;
        }

        public IEnumerable<Person> GetByName(string name)
        {
            var response = people.Where(x => x.FirstName.Contains(name));
            return response;
        }
        public IEnumerable<Person> GetByLastName(string lastName)
        {
            var response = people.Where(x => x.LastName.Contains(lastName));
            return response;
        }

        public void Post([FromBody] Person request)
        {
            people.Add(request);
        }

    }
}