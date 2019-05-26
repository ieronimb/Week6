using HWPersonClass.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());
            person.Name = "Joro Petkoff";
            Console.WriteLine(person.ToString());
            person.Age = 19;
            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }
}

