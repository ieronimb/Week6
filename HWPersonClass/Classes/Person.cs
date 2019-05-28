using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPersonClass.Classes
{
    class Person
    {
        private string name;
        private int age;

        //Constructor gol dinadins pentru a ne returna un nume gol
        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;           
        }

        public string Name
        {
            get { return this.name; }
            set {
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
            
        }

        public override string ToString()
        {
            string result = "Name: " + this.name + "\n";
            if (this.age <= 0)
            {
                result += "Age is left unspecified.";
            }
            else
            {
                result += "Age: " + this.age + "\n";
            }
            return result;
        }
    }
}
