using Cinema_application.Services;
using Cinema_application.Utilities;

namespace Cinema_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int selection;
            //Console.WriteLine("Welcome Cinema");
            //do
            //{
            //    start:
            //    Console.WriteLine("1. Create hall");
            //    Console.WriteLine("2. Edit hall");
            //    Console.WriteLine("3. Get all halls");
            //    Console.WriteLine("4. Get all seats by hall no");
            //    Console.WriteLine("5. Reserve seat");
            //    Console.WriteLine("0. Exit");
            //    bool result = int.TryParse(Console.ReadLine(), out selection);
            //    if (result)
            //    {
            //        switch (selection)
            //        {
            //            case 1:
            //                MenuService.CreateHall();
            //                break;
            //            case 2:
            //                MenuService.EditHall();
            //                break;
            //            case 3:
            //                MenuService.GetHalls();
            //                break;
            //            case 4:
            //                MenuService.GetSeatsByHall();
            //                break;
            //            case 5:
            //                MenuService.Reserve();
            //                break;
            //            default:
            //                Console.Clear();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        goto start;
            //    }
            //} while (selection !=0);



            string fullname;
            do
            {
                Console.WriteLine("Please login");
                fullname = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(fullname));


            int selection;
            Console.WriteLine($"Welcome our Cinema {fullname}");
            do
            {
            start:
                Console.WriteLine("1. Create hall");
                Console.WriteLine("2. Edit hall");
                Console.WriteLine("3. Get all halls");
                Console.WriteLine("4. Get all seats by hall no");
                Console.WriteLine("5. Reserve seat");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.CreateHall();
                            break;
                        case 2:
                            MenuService.EditHall();
                            break;
                        case 3:
                            MenuService.GetHalls();
                            break;
                        case 4:
                            MenuService.GetSeatsByHall();
                            break;
                        case 5:
                            MenuService.Reserve();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            } while (selection != 0);
        }
    }
}