using MyLibrary;
using Namespaces__Access_modifiers__dynamic_link_library.Models;
using System.Text;

namespace Namespaces__Access_modifiers__dynamic_link_library
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student homework
            //Student student = new Student("Mahammad","Ismayilov","P327",100);
            //string fullname = student.Fullname();
            //Console.WriteLine(fullname);
            //student.Info();

            //student.TryExam(); 
            #endregion

            #region Encapsulation homework
            //string username;
            //do
            //{
            //    Console.WriteLine("Please enter username");
            //    username = Console.ReadLine();

            //} while (username.Length<=6);
            //string pw;
            //do
            //{
            //    Console.WriteLine("Please enter password");
            //   pw = Console.ReadLine();
            //} while (!CheckPassword(pw));

            //Console.WriteLine("is super admin? y/n");

            //char yesOrNo = Console.ReadKey().KeyChar;
            //Console.WriteLine("\n");
            //bool isSuper = false;
            //if(char.ToLower(yesOrNo) == 'y')
            //{
            //    isSuper = true;
            //}
            //Admin admin = new Admin(username, pw, "Slider",isSuper);
            //admin.Info(); 
            #endregion


            //Cola cola = new Cola();
            //cola.price
            //StringBuilder builder = new StringBuilder();
            Category category = new Category();
            Context 
        }
        static bool CheckPassword(string pw)
        {
            bool result = false;
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasLower = false;
                bool hasUpper = false;
                foreach (char character in pw)
                {
                    if (char.IsDigit(character))
                    {
                        hasDigit = true;
                    }
                    else if (char.IsLower(character))
                    {
                        hasLower = true;
                    }
                    else if (char.IsUpper(character))
                    {
                        hasUpper = true;
                    }
                }
                result = hasLower && hasDigit && hasUpper;
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}