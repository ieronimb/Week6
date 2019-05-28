using HWPersonClass.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPersonClass
{
    class HWPerson
    {
        static void Main(string[] args)
        {
            Person person = new Person();           
            person.Name = "Nume Necunoscut";
            Console.WriteLine(person.ToString());
            person.Age = 6;
            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }
}


