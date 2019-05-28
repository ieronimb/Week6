using HWStudentClass.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1StudentClass
{
    class HWStudent
    {
        static void Main(string[] args)        {

            Student firstStudent = new Student("Botoc", "Stefan", "Petrica", "XCAE", "Strada Iasi", "0746970456", "psb@g.com", SpecialityType.Tehnica, UniversityName.GheorgheAsachi, FacultyType.Automatica);
            Student secondStudent = new Student("Popescu", "George", "Ionut", "EFSE", "Strada Bacau", "074980588", "pgi@g.com", SpecialityType.Drept, UniversityName.AlexandruIoanCuza, FacultyType.Drept);
            
            Console.WriteLine("firstStudent == secondStudent ?");
            Console.WriteLine(firstStudent == secondStudent);

            Console.WriteLine("firstStudent != secondStudent ?");
            Console.WriteLine(firstStudent != secondStudent);

            Console.WriteLine("firstStudent compared to secondStudent");
            Console.WriteLine(firstStudent.CompareTo(secondStudent));

            Console.WriteLine("Hashcode for firstStudent");
            Console.WriteLine(firstStudent.GetHashCode());
            Console.WriteLine("Hashcode for secondStudent");
            Console.WriteLine(secondStudent.GetHashCode());

            Student thirdStudent = firstStudent.Clone();
            Console.WriteLine(firstStudent.CompareTo(thirdStudent));
            Console.WriteLine(thirdStudent);
            
            Console.ReadLine();
        }
       
    }
}
