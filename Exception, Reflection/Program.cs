using System.Reflection;

namespace Exception__Reflection
{
    internal class Program
    {
        public string ProgramField;
        static void Main(string[] args)
        {
            #region Exception
            ////DivideByZeroException
            ////int twenty = 20;
            ////int zero = 0;
            ////int result = twenty / zero;

            ////IndexOutOfRangeException
            ////int[] arr = new int[2];

            ////Console.WriteLine(arr[2]);

            //List<int> list = new List<int>()
            //{
            //    1,
            //    2,
            //    3,
            //    4
            //};



            ////NullReferenceException
            ////List<int> list2 = null;

            ////list2?.Add(5);
            ////int[] arr = new int[2];
            ////try
            ////{

            ////    int twenty = 20;
            ////    int zero = 0;
            ////    int result = twenty / 7;


            ////    Console.WriteLine(arr[1]);

            ////    int.Parse("a");
            ////    list.First(x => x == 9);


            ////}
            ////catch (DivideByZeroException ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////    //Console.WriteLine(arr[1]);
            ////    Console.WriteLine("Some process for divide by zero");

            ////}
            ////catch (IndexOutOfRangeException ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////    Console.WriteLine("Some process for index out of range");
            ////}
            ////catch (FormatException ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////    Console.WriteLine("Some process for format");
            ////    throw new NullReferenceException("Kabel uzunlugu kifayet etmir");
            ////}
            //////catch (Exception ex)
            //////{
            //////    Console.WriteLine(ex.Message);
            //////    Console.WriteLine("Some process for format");
            //////}
            ////finally
            ////{
            ////    Console.WriteLine("After catch");
            ////}


            //Student student = new Student(18);
            //try
            //{
            //    student.CheckAge();
            //}
            //catch (StudentAgeOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            //Assembly assembly = Assembly.GetExecutingAssembly();

            //Type[] classes = assembly.GetTypes();
            //foreach (Type clas in classes)
            //{
            //    //Console.WriteLine($"{clas.Name}'s fields:");
            //    //foreach (var field in clas.GetFields())
            //    //{
            //    //    Console.WriteLine(field.Name);
            //    //}
            //    //Console.WriteLine($"{clas.Name}'s properties:");
            //    //foreach (var property in clas.GetProperties())
            //    //{
            //    //    Console.WriteLine(property.Name);
            //    //}
            //    //Console.WriteLine($"{clas.Name}'s methods:");
            //    //foreach (var method in clas.GetMethods())
            //    //{
            //    //    Console.WriteLine(method.Name);
            //    //}
            //}


            //foreach (var item in typeof(Student).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            //{
            //    Console.WriteLine(item.Name);
            //}

            Student student = new Student(30);

            FieldInfo privateField = student.GetType().GetField("PrivateField", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(privateField.GetValue(student));
            privateField.SetValue(student,"Private field value has been changed");
            Console.WriteLine(privateField.GetValue(student));

        }
    }
}