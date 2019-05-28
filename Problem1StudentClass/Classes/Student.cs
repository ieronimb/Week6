using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWStudentClass.Classes

{
    //Problem 1. Student class
    //Define a class Student, which contains data about a student – first, middle and last name, SSN, 
    //permanent address, mobile phone e-mail, course, specialty, university, faculty.Use an enumeration for the specialties, universities and faculties.
    //Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators ==and !=.

    //Enums
    public enum SpecialityType
    {
        Istorie, Drept, Medicina, Tehnica
    }
    public enum UniversityName
    {
        AlexandruIoanCuza, GheorgheAsachi, GrigoreTPopa
    }
    public enum FacultyType
    {
        Medicina, Farmacie, Automatica, Drept, Contructie, Jurnalism
    }

    class Student : ICloneable, IComparable<Student>
    {
        //Campuri - nu folosesc auto-property, numai ca sa ca ma obisnuiesc
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAdress;
        private string phoneNumber;
        private string email;
        SpecialityType speciality;
        UniversityName university;
        FacultyType faculty;

        //Constructori
        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAdress, 
            string phoneNumber, string email, SpecialityType speciality, UniversityName university, FacultyType faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.permanentAdress = permanentAdress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.speciality = speciality;
            this.university = university;
            this.faculty = faculty;
        }

        //Proprietati - nu folosesc auto-property, numai ca sa ca ma obisnuiesc
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string PermanentAdress
        {
            get { return this.permanentAdress; }
            set { this.permanentAdress = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public SpecialityType Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        public UniversityName University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public FacultyType Faculties
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        //Override System.Object: Equals()
        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.firstName, student.FirstName))              
            {
                return false;
            }
            if (!Object.Equals(this.middleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.lastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.ssn, student.SSN))
            {
                return false;
            }           
            return true;
        }
        //Override GetHashCode()
        public override int GetHashCode() //https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=netframework-4.8
        {
            return (FirstName.GetHashCode() 
                    ^ MiddleName.GetHashCode() 
                    ^ LastName.GetHashCode()
                    ^ SSN.GetHashCode()); //https://www.tutorialspoint.com/csharp/csharp_operators.htm Binary XOR Operator copies the bit if it is set in one operand but not both.	(A ^ B) = 49, which is 0011 0001
        }

        //Override ToString()
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("First name: {0}\nMiddle name: {1}\nLast name: {2}\nSSN: {3}\nAddress: {4}\n" +
                "Phone number: {5}\nE-mail: {6}\nSpeciality: {7}\nUniversity: {8}\nFaculties: {9}", 
                this.firstName, this.middleName, this.lastName, this.ssn, this.permanentAdress,
                this.phoneNumber, this.email, this.speciality, this.university, this.faculty);

            return output.ToString();
        }
        //Override operators ==
        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }
        //Override operators !=
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        //Problem 2. ICloneable
        //Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public Student Clone()
        {
            Student original = this;
            Student newStudent = new Student(original.firstName, original.middleName, original.lastName, 
                original.ssn, original.permanentAdress, original.phoneNumber, original.email, 
                original.speciality, original.university, original.faculty);
            return newStudent;
        }
        
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        //Problem 3. IComparable
        //Implement the IComparable<Student> interface to compare students by names(as first criteria, in lexicographic order) and by social security number(as second criteria, in increasing order).
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return String.Compare(this.FirstName, student.FirstName);
            }
            if (this.LastName != student.LastName)
            {
                return String.Compare(this.LastName, student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return String.Compare(this.SSN, student.SSN);
            }

            return 0;
        }
    }
}
