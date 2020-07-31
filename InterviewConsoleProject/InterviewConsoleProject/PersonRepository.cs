using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewConsoleProject
{
    public class PersonRepository
    {
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { PersonId = 1, Surname = "Newman", Forename = "David" });
            people.Add(new Person { PersonId = 2, Surname = "Wilson", Forename = "Clare" });
            people.Add(new Person { PersonId = 3, Surname = "Widdowson", Forename = "Anthony" });
            people.Add(new Person { PersonId = 4, Surname = "Walker", Forename = "Arron" });
            people.Add(new Person { PersonId = 5, Surname = "Walker", Forename = "Martin" });
            return people;
        }
    }
}
