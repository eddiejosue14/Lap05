using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Herencia");
            PrintPerson(new Student());

            Console.WriteLine("Hola,COmposicion");
            PrintPerson(new StudentC(new Person()));

            Console.ReadKey();

        }

        public static void PrintPerson(Student student)
        {
           Console.Write(student.FormatIdAndName("John Smith", 1));
        }

        public static void PrintPerson(StudentC student)
        {
            Console.Write(student.FormatIdAndName("John Smith", 1));
        }
    }
}
