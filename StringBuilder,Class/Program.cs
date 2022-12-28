using System.Text;

namespace StringBuilder_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            //StringBuilder builder = new StringBuilder();

            ////for (int i = 0; i < 10; i++)
            ////{
            ////    builder.AppendLine(i.ToString());
            ////    Console.WriteLine(builder);
            ////}


            //builder.Append("Hello P327");
            //builder.Insert(5," Back-End");
            //Console.WriteLine(builder); 
            #endregion

            //string name = "Togrul";
            //string surname = "Hazizade";
            //byte age = 20;
            //var student = new
            //{
            //    Name = "Togrul",
            //    Surname = "Hazizade",
            //    Age = 20
            //};


            //Console.WriteLine(student
            //Student student = new Student();
            //Student student1 = new Student();
            //Student student2 = new Student();
            //student.Age = 30;
            //student.Firstname = "Arif";
            //student1.Firstname = "Asiman";
            //student2.Firstname = "Samra";
            //student.Surname = "Karimli";
            //student1.Surname = "Qasimzade";
            //student2.Surname = "Albandayeva";

            ////Student student2 = new Student();

            ////Console.WriteLine(student.Age);

            ////student.ShowFirstname();

            //student.ShowFullname();
            //student1.ShowFullname();
            //student2.ShowFullname();

            Student student = new Student("Asiman", "Qasimzade", 19, "Male");
            //Student student1 = new Student("Lutfu", "Mammadov", 24, "Male");
            //Student student2 = new Student("Farid", "Mammadov", 22, "Male");
            //Student student3 = new Student("Farid", "Mammadov", 22, "Male");
            //Student student4 = new Student("Farid", "Mammadov", 22, "Male");

            ////student4.ShowFirstname();

            //Student student = new Student("Asiman", "Qasimzade");

            Console.WriteLine(student);

            
        }
        
    }

}