using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap05
{
    public class StudentC
    {

        Person person;

        public StudentC(Person person)
        {
            this.person = person; 
        }

        public string FormatIdAndName(string name, int id)
        {
            return person.FormatIdAndName(name, id); 
        }

        }
}
