using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal static class MenuService
    {

        static CinemaService _cinemaService;

        static MenuService()
        {
            _cinemaService = new CinemaService();
        }


        public static void CreateHall()
        {
            CheckRowAndColumn(out int row, out int col);
            int min = (int)Enum.GetValues(typeof(Categories)).Cast<Categories>().Min();
            int max = (int)Enum.GetValues(typeof(Categories)).Cast<Categories>().Max();
        category:
            Console.WriteLine("Please select category:");

            foreach (object category in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}.{category}");
            }

            bool cgResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out object cg);
            if (cgResult && (int)cg >= min && (int)cg <= max)
            {
                string no = _cinemaService.CreateHall(row, col, (Categories)cg);
                Console.WriteLine($"{no} hall have been successfully created");
            }
            else
            {
                goto category;
            }
        }

        public static void EditHall()
        {
            _cinemaService.GetHalls();

        oldNo:
            Console.WriteLine("Please enter hall no which you want to change");
            string oldNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(oldNo))
            {
                goto oldNo;
            }
        newNo:
            Console.WriteLine("Please enter new hall no:");
            string newNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newNo))
            {
                goto newNo;
            }


            bool? result = _cinemaService.EditHallNo(oldNo, newNo);
            if (result == null)
            {
                Console.WriteLine("There is no hall no which you entered");
            }
            else if (result == false)
            {
                Console.WriteLine("Already have this hall no, please try again");
            }
            else
            {
                Console.WriteLine($"You successfully change no to {newNo.ToUpper()}");
            }
        }

        public static void GetHalls()
        {
            _cinemaService.GetHalls();
        }

        public static void GetSeatsByHall()
        {
            _cinemaService.GetHalls();
        no:
            Console.WriteLine("Please enter hall no:");
            string no = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(no))
            {
                goto no;
            }

            _cinemaService.GetSeatsByHall(no);
        }

        public static void Reserve()
        {
            CheckRowAndColumn(out int row, out int col);
        no:
            Console.WriteLine("Please enter hall no:");
            string no = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(no))
            {
                goto no;
            }

            bool? result = _cinemaService.Reserve(row, col, no);

            if(result == null)
            {
                Console.WriteLine("There is no hall");
            }else if(result == false)
            {
                Console.WriteLine("Please enter valid row or column");
            }
            else
            {
                Console.WriteLine("Successfully reserved");
            }

        }

        static void CheckRowAndColumn(out int row, out int col)
        {
        row:
            Console.WriteLine("Please enter row:");
            bool rowResult = int.TryParse(Console.ReadLine(), out row);
            if (!rowResult)
            {
                Console.WriteLine("Please enter valid row");
                goto row;
            }
        col:
            Console.WriteLine("Please enter col:");
            bool colResult = int.TryParse(Console.ReadLine(), out col);
            if (!colResult)
            {
                Console.WriteLine("Please enter valid col");
                goto col;
            }

            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Please enter valid col or row");
                goto row;
            }
        }
    }
}
