using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBestYet
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("ID: {0}", PersonId));
            sb.Append(string.Format("Surname: {0}", Surname));
            sb.Append(string.Format("Forname: {0}", Forename));

            return sb.ToString();
        }
    }
}
