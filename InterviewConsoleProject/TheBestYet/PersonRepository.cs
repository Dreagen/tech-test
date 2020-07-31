using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBestYet
{
    public class PersonRepository
    {
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { PersonId = 1, Surname = "Newman", Forename = "David"});
            people.Add(new Person { PersonId = 2, Surname = "Wilson", Forename = "Clare"});
            people.Add(new Person { PersonId = 3, Surname = "Widdowson", Forename = "Anthony"});

            return people;
        }
    }
}
