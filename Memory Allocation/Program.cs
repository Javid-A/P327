namespace Memory_Allocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework and Classwork
            //int result = Calculation(5, 2, "/");
            //Console.WriteLine(result);

            //Console.WriteLine(Calculator());

            //AddPrefix(657123); 
            #endregion

            //int num = 300;

            //int num2 = num;

            //num = 400;

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] arr = numbers;//0x803567

            //numbers[0] = 99;

            //Console.WriteLine(arr[0]);

            //int number = 100; //0x899001

            //ChangeNumber(ref number);

            //ChangeNumberWithOutKeyword(out number);
            //Console.WriteLine(number);


            //int number=20;

            //ChangeNumber(ref number);


            //Console.WriteLine(number);
            //int number2;

            //ChangeNumberWithOutKeyword(out number2);

            string str = Console.ReadLine();
            int number;
            bool result = int.TryParse(str,out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number);
                Console.WriteLine("Please choose valid number");
            }

        }

        #region Homework and Classwork
        //Worst case
        //static int Calculation(int num1,int num2,string operation)
        //{
        //    int result = 0;

        //    if (operation=="*")
        //    {
        //        result = num1 * num2;
        //    }
        //    else if(operation=="/")
        //    {
        //        result = num1 / num2;
        //    }
        //    else if (operation=="+")
        //    {
        //        result = num1 + num2;
        //    }
        //    else if (operation=="-")
        //    {
        //        result = num1 - num2;
        //    }
        //    return result;
        //}

        //static double Calculator()
        //{
        //    Console.WriteLine("Please choose first number");
        //    double num1 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Please choose second number");
        //    double num2 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Please choose operator(example: + - / *)");
        //    char op = char.Parse(Console.ReadLine());

        //    double result = 0;
        //    switch (op)
        //    {
        //        case '+':
        //            result += num1 + num2;
        //            Console.WriteLine(num1 + "+" +num2 + "=" + result);
        //            break;

        //        case '-':
        //            result += num1 - num2;
        //            Console.WriteLine(num1 + "-" + num2 + "=" + result);
        //            break;
        //        case '/':
        //            result += num1 / num2;
        //            Console.WriteLine(num1 + "/" + num2 + "=" + result);
        //            break;
        //        case '*':
        //            result += num1 * num2;
        //            Console.WriteLine(num1 + "*" + num2 + "=" + result);
        //            break;
        //        default:
        //            Console.WriteLine("Please choose valid operator");
        //            break;
        //    }

        //    return result;
        //}



        //static void AddPrefix(int number)
        //{
        //    int inital = number;
        //    int floor = 3;//1000 10000 100000
        //    while (number>0)
        //    {
        //        number /= 10;// number = number/10  (1. 65), (2. 6) , (3. 0)
        //        floor *= 10;
        //    }

        //    int result = floor + inital;//3000 + 657 = 3657
        //    Console.WriteLine(result);
        //}

        #endregion


        static void ChangeNumber(ref int number)
        {
            number += 100;
            Console.WriteLine(number);
        }

        static void ChangeNumberWithOutKeyword(out int number)
        {
            number = 100;
            Console.WriteLine(number);
        }
    }
}