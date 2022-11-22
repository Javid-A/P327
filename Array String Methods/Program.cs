namespace Array_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework and Classworks
            //Console.WriteLine(FindNearBySeven());
            //Console.WriteLine(Count("Salam P327 assalamu aleykum"));
            //ShowLastThree("Hello"); 
            #endregion

            #region Array methods
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr2 = new int[5];//0,0,0,0,0
            //Array.Clear(arr);
            //int[] arr2 = (int[])arr.Clone();

            //arr2[2] = 222;

            //Array.Clear(arr,4,1);
            //foreach (int number in arr)
            //{
            //    Console.WriteLine(number);
            //}


            //Array.Copy(arr,arr2,3);//1,2,3,0,0

            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Copy(arr, 3, arr2, 3, 2);

            //Console.WriteLine("After second copy process");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //arr.CopyTo(arr2,2);
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] test = { 1, 2, 3, 4, 5 };
            //int[] test2 = new int[5];
            //int[] test3 = new int[] { 1, 2, 3, 4, 5 };
            //Array doubleArr = Array.CreateInstance(typeof(double),5);

            //foreach (var item in doubleArr)
            //{
            //    Console.WriteLine(item);
            //}
            //object obj = new
            //{

            //};

            //string name = "Lutfu";
            //string name2 = "Lutfu";

            //Console.WriteLine(name.Equals(name2)) ;

            //Console.WriteLine(arr.GetType());
            //Console.WriteLine(arr.GetValue(2));
            //Console.WriteLine(Array.IndexOf(arr, 15));
            //Console.WriteLine(Array.IndexOf(arr, 3));
            //Console.WriteLine(Array.LastIndexOf(arr, 3));

            //Array.Reverse(arr, 0, arr.Length);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arr.ToString());

            //string name = "Arif";
            //name = "Samra";
            //Console.WriteLine(name);

            //string test = "P327";

            //for (int i = 0; i < 10; i++)
            //{
            //    test += i;
            //    Console.WriteLine(test);
            //}

            //arr = new int[10];

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Resize(ref arr, arr.Length + 1);
            //arr[arr.Length - 1] = 222;
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //Test("1","2","3","4");

            //Console.WriteLine(string.Compare("test1", "test"));

            //string numbers= string.Concat("1", "2", "3", "4", "5");

            //Console.WriteLine(numbers);
            string test = "Cola,Milk,Coffeem,Tea";
            int price = 257;

            //Console.WriteLine(test.Contains("m P"));

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(string.Format("{0:Y}", DateTime.Now));

            //Console.WriteLine(test.Insert(5, " Hello")) ;

            //if (string.IsNullOrWhiteSpace(test))
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    Console.WriteLine(test);
            //}

            //Console.WriteLine(test.Remove(0));
            //foreach (var item in test.ToCharArray())
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine(test.Trim('-')) ;
            //Console.WriteLine(test) ;
            //string[] words = test.Split(',');
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(string.Join("==>",words));
        }

        #region Homework and Classworks
        static int FindNearBySeven()
        {
            bool result = int.TryParse(Console.ReadLine(), out int num);
            if (result)
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine("Eded 7-ye bolunur");
                    return num;
                }
                else
                {
                    int remainder = num % 7;
                    //if (remainder<4)
                    //{
                    //    num -= remainder;
                    //    return num;
                    //}
                    //else
                    //{
                    //    num += 7 - remainder;
                    //    return num;
                    //}
                    if (remainder < 4)
                    {
                        while (num % 7 != 0)
                        {
                            num--;
                        }
                        return num;
                    }
                    else
                    {
                        while (num % 7 != 0)
                        {
                            num++;
                        }
                        return num;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please choose valid number");
                return num;
            }
        }

        static int Count(string str)
        {
            int count = default;

            foreach (char letter in str)
            {
                if (letter == 'a')
                {
                    count++;
                }
            }
            return count;
        }
        static void ShowLastThree(string str)
        {
            for (int i = str.Length - 3; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
        }
        #endregion

        //static void Test(params string[] test)
        //{
        //    foreach (string item in test)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}