using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Class
{
    public class Student
    {
        public string Firstname;
        public string Surname;
        public byte Age;
        public string Gender;

        //public Student(string Firstname,string Surname, byte Age, string Gender)
        //{
        //    this.Firstname = Firstname;
        //    this.Surname = Surname;
        //    this.Age = Age;
        //    this.Gender = Gender;
        //}


        public Student(string name,string surname,byte age,string gender):this(age,gender)
        {
            Firstname = name;
            Surname = surname;
            Console.WriteLine("First");
        }

        public Student(byte age,string gender):this(gender)
        {
            Age = age;
            Console.WriteLine("Second");
        }

        public Student(string gender)
        {
            Gender = gender;
            Console.WriteLine("Third");
        }

        

        public void ShowFirstname()
        {
            Console.WriteLine(Firstname);
        }

        public void ShowFullname()
        {
            Console.WriteLine(Firstname + " " + Surname);
        }

    }
}
