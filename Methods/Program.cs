namespace Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Homeworks
            //int power = 2;
            //int total = 1;
            //Console.WriteLine("Please, enter the number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (total<number)
            //{
            //    total *= power;
            //}
            //if (total==number)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}

            //            string numStr = Console.ReadLine();
            //            string num2Str = Console.ReadLine();

            //            int num = Convert.ToInt32(numStr);
            //            int num2 = Convert.ToInt32(num2Str);

            //            for ( int i=num+1 ; i < num2; i++ )
            //            {
            //                Console.WriteLine(i);
            //            }

            //Console.WriteLine("Zehmet olmasa ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result;
            //if (num>70)
            //{
            //    result = (num - 70) * 3;
            //}
            //else
            //{
            //    result = (70 - num);
            //}
            //    Console.WriteLine(result);


            //int num = Convert.ToInt32(Console.ReadLine());
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num>num1 && num>num2)
            //{

            //    Console.WriteLine("en boyuk eded" +num);
            //}
            //else if (num1>num && num1>num2)
            //{

            //    Console.WriteLine("en boyuk eded" + num1);
            //}
            //else {

            //    Console.WriteLine("en boyuk eded" +num2);
            //}
            //int m = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int remainder = m % 2;
            //int count = 0;
            //if (remainder == 0)
            //{
            //    m++;


            //}
            //else
            //{
            //    count--;
            //}
            //for (int result = m; result < n; result += 2)
            //{
            //    count++;
            //}
            //Console.WriteLine(count); 
            #endregion

            //Console.WriteLine("Tek ededler");
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("3-e bolunenler");
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("7-ye bolunenler");
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //SaySomething("Hello P327");
            //SaySomething("This is method");

            //string name = Console.ReadLine();
            //Console.WriteLine(name);


            //Console.WriteLine(Sum(100,20));

            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();

            ////Console.WriteLine(Fullname(name,surname));

            //Grade(name,surname,25);

            //int result = 5 + 10;
            //Console.WriteLine(result);

            Total();
            Total(5, 10);
            Total(5, 10, 10);
            Total(10.6, 20.3);
            Total(10.3, 10);
            Total(10, 30.3);

            ShowRange(0,30,2);
            ShowRange(100,200,7);
            ShowRange(200,500,15);


            int number1 = 10;
            int number2 = 0;

            Console.WriteLine(number1/number2);
            //var number = 10;
            //dynamic number2 = 20;
            //Console.WriteLine(number);
            //Console.WriteLine(number2);
        }
        //static void SaySomething(string something)
        //{
        //    Console.WriteLine(something);
        //}

        //static int Sum(int num1, int num2)
        //{
        //    return num1+num2;
        //}

        //static string Fullname(string name, string surname)
        //{
        //    return name + " " + surname;
        //}

        //static void Grade(string name,string surname,byte age, byte grade = 20)
        //{
        //    string result = name + " " + surname + " telebenin yashi: " + age +  " Telebenin : grade-i: " + grade;
        //    Console.WriteLine(result);
        //}

       static void Total()
        {
            Console.WriteLine("Total is zero");
        }

        static void Total(int price1, int price2)
        {
            Console.WriteLine("Total is " + (price1 + price2));
        }

        static void Total(int price1, int price2, int price3=10)
        {
            Console.WriteLine("Total is " + (price1 + price2+price3));

        }

        static void Total(double price1, double price2)
        {
            Console.WriteLine("Total is " + (price1 + price2));
        }

        static void Total(double price1, int price2)
        {
            Console.WriteLine("Total is " + (price1 + price2));
        }

        static void Total(int price1, double price2)
        {
            Console.WriteLine("Total is " + (price1 + price2));
        }

       
        static void ShowRange(int start,int end , int divide)
        {
            Console.WriteLine(divide + "-a bolunenler");
            for (int i = start; i <= end; i++)
            {
                if (i % divide == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
} 