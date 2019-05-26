using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWStudentClass.Classes

{   //Enums
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
        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAdress, string phoneNumber, string email, SpecialityType speciality, UniversityName university, FacultyType faculty)
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
            get { return this.LastName; }
            set { this.LastName = value; }
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
        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!((Object.Equals(this.firstName, student.FirstName)) && (Object.Equals(this.middleName, student.MiddleName)) && (Object.Equals(this.lastName, student.LastName))))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return (FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode());
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("First name: {0}\nMiddle name: {1}\nLast name: {2}\nSSN: {3}\nAddress: {4}\n" +
                "Phone number: {5}\nE-mail: {6}\nSpeciality: {7}\nUniversity: {8}\nFaculties: {9}", this.firstName, this.middleName, this.lastName, this.ssn, this.permanentAdress, this.phoneNumber, this.email, this.speciality, this.university, this.faculty);

            return result.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public Student Clone()
        {
            Student original = this;
            Student copy = new Student(original.firstName, original.middleName, original.lastName, original.ssn, original.permanentAdress, original.phoneNumber, original.email, original.speciality, original.university, original.faculty);
            return copy;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

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
