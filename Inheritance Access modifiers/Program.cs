namespace Inheritance_Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Arif","Karimli",29,"Male","1", 40);
            //Teacher teacher = new Teacher("Arif", "Karimli", 29, "Male", "Programming");
            //Console.WriteLine(student.GetPassword());
            //student.SetPassword("4321");
            //Console.WriteLine(student.GetPassword());

            //student.Password = "1234";

            Console.WriteLine(student.Password);
        }
    }
}