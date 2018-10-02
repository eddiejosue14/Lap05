using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap05
{
    public class Person
    {
        public string FormatIdAndName(string name, int id)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Name: ");
            stringBuilder.Append(name);
            stringBuilder.Append("Id: ");
            stringBuilder.Append(id);


            return stringBuilder.ToString();


        }
    }

    public class Student:Person
    {




    }
}
