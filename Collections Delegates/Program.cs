using System.Collections;

namespace Collections_Delegates
{
    public delegate void Parametrless();
    public delegate void Test(string word);

    public delegate bool Dividable(int num, int divide);

    public delegate void WriteSomething(params string[] words);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //City city = new City("NY",2000000);
            //City city2 = new City("LA",7000000);
            //City city3 = new City("California",5000000);

            //Country country = new Country("America");

            //country.Add(city);
            //country.Add(city2);
            //country.Add(city3);
            //Console.WriteLine(country.TotalPopulation);

            //foreach (var item in country.FindAllByPopulation(3000000,10000000))
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Collections
            //ArrayList arrayList = new();
            //arrayList.Add(1);
            //arrayList.Add("string");
            //arrayList.Add('a');
            //arrayList.Add(1.5);
            //arrayList.Add(new City("LA",30000000));
            //arrayList.Add(new Country("America"));

            //ArrayList arrayList2 = new();
            //arrayList2.Add(999);
            //arrayList2.Add("string99");
            //arrayList2.Add('b');
            ////arrayList.InsertRange();
            //arrayList.AddRange(arrayList2);
            //arrayList.Remove(999);
            //arrayList.RemoveAt(2);
            //arrayList.RemoveRange(2,5);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine(arrayList.Count);

            //SortedList sortedList = new();

            ////sortedList.Add('D',"Hamid,Mahammad,Ziya");
            //sortedList.Add("P330", "Samra,Lutfu,Asiman");
            //sortedList.Add("P327", "Fikrat,Ayxan,Huseyn");
            //sortedList.Add(1,5);
            //sortedList.RemoveAt(1);
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //Dictionary<string, string> keys = new();
            //keys.Add("P330", "Samra,Lutfu,Asiman");
            //keys.Add("P327", "Fikrat,Ayxan,Huseyn");
            //bool result = keys.TryAdd("P328", "Fikrat,Ayxan,Huseyn");
            //if (result)
            //{
            //    Console.WriteLine("Added");
            //}
            //else
            //{
            //    Console.WriteLine("Not added");
            //}
            //foreach (var item in keys)
            //{
            //    Console.WriteLine(item.Value);
            //}


            //Stack<DateTime> stack = new();

            //stack.Push(new DateTime(2024,2,3));
            //stack.Push(new DateTime(2023, 9, 20));
            //stack.Push(new DateTime(2023, 2, 9));

            //Console.WriteLine($"{stack.Pop()} cixarildi");
            //Console.WriteLine($"{stack.Pop()} cixarildi");
            //Console.WriteLine($"{stack.Pop()} cixarildi");
            //Console.WriteLine($"{stack.TryPeek(out DateTime result)} ==> {result} novbeti mehsul");

            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Samra");
            //queue.Enqueue("Asiman");
            //queue.Enqueue("Lutfu");

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.TryDequeue());
            //Console.WriteLine(queue.TryPeek());

            //City city = new City("NY", 2000000);
            //City city2 = new City("LA", 7000000);
            //City city3 = new City("California", 5000000);
            //City city4 = new City("California", 4000000);

            //List<City> cities = new List<City>()
            //{
            //    city,
            //    city2,
            //    new City("California", 5000000),
            //    city4
            //};
            //Console.WriteLine(cities.RemoveAll(x => x.Population <= 5000000));
            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item.Population);
            //}
            //cities.ToArray(); 
            #endregion


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //DividableWithDelegate(Module,20);
            //DividableWithDelegate(IsGreaterThanFifty,20);

            //DividableWithDelegate(IsGreaterThan50AndLessThan75, 7);

            //Dividable dividable = new Dividable(IsGreaterThan50AndLessThan75);
            //Console.WriteLine(dividable(50, 4));
            //Console.WriteLine(dividable.Invoke(50, 4));
            //Dividable dividable2 = IsGreaterThanFifty;

            //dividable += dividable2;
            //Console.WriteLine(dividable(50, 4));

            //WriteSomething something = new WriteSomething(Write);
            //WriteSomething avarage = WriteAvarageGrade;
            //WriteSomething process = AnotherProcess;
            //something += avarage;
            //something += process;
            //something("Samra","Ayxan","Ziya","Huseyn");
            //something -= process;
            //something -= process;
            //Console.WriteLine("After minus");
            //something("Samra", "Ayxan", "Ziya", "Huseyn");

            //    Test(string word)
            //    {
            //        Console.WriteLine(word);
            //    }
            //(string word) =>
            //{

            //};
            //Test test = delegate (string word)
            //{
            //    Console.WriteLine(word);
            //};
            //Test test = Test;

            //test("Hello");

            //Test test = (string word) =>
            //{
            //    Console.WriteLine(word);
            //};

            //Parametrless parametrless = () =>
            //{
            //    Console.WriteLine("parametrless");
            //};
            //parametrless();
            //test.Invoke("P327");

            //Action<int, int> sum = (int num1, int num2) =>
            //{
            //    Console.WriteLine(num1+num2);
            //};
            //sum(5, 6);
            //Action action = delegate ()
            //{
            //    Console.WriteLine("Parametrless action");
            //};
            //action.Invoke();
            //Action<int, int, double, char, string> action2= MethodForAction;

            //action2(1,2,3.4,'a',"Hello");

            //Func<char> func = () =>
            //{
            //    return '5';
            //};
            //Console.WriteLine(func());

            //Func<int, int, string> func2 = delegate (int num1,int num2)
            //{
            //    int result = num1 + num2;

            //    return result.ToString();
            //};

            //Console.WriteLine(func2(20, 15));


            //Predicate<int> predicate = (int num) => num > 10;



            //Console.WriteLine(predicate(10));


            //Predicate<string> predicate1 = (string word) => word.Contains('a');

            //Console.WriteLine(predicate1("Fikrat"));


            List<Student> list = new List<Student>()
            {
                new Student("Samra"),
                new Student("Hamid"),
                new Student("Toghrul"),
                new Student("Mahammad"),
                new Student("Lutfu"),
                new Student("Asiman"),
                new Student("Ziya"),
                new Student("Ayxan"),
                new Student("Fikrat"),
                new Student("Tural"),
                new Student("Orxan"),
                new Student("Shahin"),
                new Student("Huseyn"),
                new Student("Israfil"),
            };

            List<Student> students = new List<Student>();
            //foreach (var item in list)
            //{
            //    if (item.Name.Contains('m'))
            //    {
            //        students.Add(item);
            //    }
            //}

            //IEnumerable<Student> stus = list.Where(s=>s.Name.Contains('m') && s.Name.Contains('i'));
            //foreach (var item in stus)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Student student = list.FirstOrDefault(s=>s.Name == "Ayxaasdan");
            //Console.WriteLine(student==null);


            SortedList<int, City> sorted = new SortedList<int, City>();

            
        }

        public static void MethodForAction(int num1, int num2, double num3, char ch,string word)
        {
            Console.WriteLine(word);
        }

        public static void Test(string word)
        {
            Console.WriteLine(word);
        }
        //static void Dividable(int divide)
        //{

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (Module(i,divide))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        static void DividableWithDelegate(Dividable method,int divide)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (method(i,divide))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool Module(int number, int divide)
        {
            return number % divide == 0;
        }
        static bool IsGreaterThanFifty(int number, int divide)
        {
            return number % divide == 0 && number > 50;
        }

        static bool IsGreaterThan50AndLessThan75(int number, int divide)
        {
            return number % divide == 0 && number > 50 && number <75;
        }

        public static void Write(params string[] words)
        {
            Console.WriteLine(string.Join(" ",words));
        }

        public static void WriteAvarageGrade(params string[] words)
        {
            //some codes
            Console.WriteLine("90");
            //some codes
        }

        public static void AnotherProcess(params string[] words)
        {
            //some codes
            Console.WriteLine("result of process");
            //some codes
        }

    }
}