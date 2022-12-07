namespace Abstract_part_2__Interface__Static
{
    public enum Categories : byte
    {
        Electronics = 1,
        Furniture,
        Machine = 254,
        Food
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 50)
            //    {
            //        //Console.WriteLine(i);
            //        return;
            //    }
            //    Console.WriteLine("Ededdir");
            //}

            //Console.WriteLine("After for loop");
            //Group group = new("P327",1);
            //Student student1 = new("Asiman","Qasimzade");
            //Student student2 = new("Shahin","Sherifzade");
            //group.AddStudent(student1);
            //group.AddStudent(student2);
            //group.GetStudents();

            //Student student1 = new("Asiman", "Qasimzade");// Firstname, Surname, Group
            //Student student2 = new("Shahin", "Sherifzade");// Firstname, Surname, Group
            //Console.WriteLine(student1.Firstname);
            //Console.WriteLine(student2.Firstname);


            //Console.WriteLine(Category.count);
            //Category category = new Category("Electronics", "elec.jpg");
            //Category category1 = new Category("Furniture", "fur.jpg");
            //Category category2 = new Category("Furniture", "fur.jpg");
            //Category category3 = new Category("Furniture", "fur.jpg");
            //category2.NonStaticMethod();
            //Category.StaticMethod();
            #region Extensions
            //string name = " Shahin";
            //int num = 5;
            //num.Add(100);

            //string info = name.CustomConcat("Sherifzade","18","P327");

            //Console.WriteLine(info);
            //category1.CustomCreateCategory("Electronics","elec.jpg");
            //Console.WriteLine(category1.Name);
            //Console.WriteLine(category1.Image);
            //string test = "TEST";

            //Console.WriteLine(test.ToLower());
            //Console.WriteLine(test);

            //Test(test);
            //Console.WriteLine(test); 
            #endregion

            //Console.WriteLine((int)Categories.Food);

            //foreach (var item in Enum.GetValues(typeof(Categories)))
            //{
            //    //Console.WriteLine((int)item);
            //}

            //Estimate estimate = new Estimate();
            //estimate.Id = "";
            //estimate.arr[0] = 10; 
            //int? number = null;

            //int[] arr = new int[3] { 1, 2, 3 };//1          2               3
            //int[,] arr2D = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 2, 3 } };
            //int[,,] arr3D = new int[4, 3, 2] { { { 1, 2 }, { 555, 444 }, { 1, 2 } }, { { 1, 2 }, { 1, 2 }, { 1, 2 } }, { { 1, 2 }, { 1, 2 }, { 1, 2 } }, { { 1, 2 }, { 1, 2 }, { 1, 2 } } };

            //Console.WriteLine(arr3D.GetLength(2));
            //Console.WriteLine(arr.Rank);
          
        }

        //static void CheckEnum(Categories category)
        //{
        //    switch (category)
        //    {
        //        case Categories.Electronics:
        //            break;
        //        case Categories.Furniture:
        //            break;
        //        case Categories.Machine:
        //            break;
        //        case Categories.Food:
        //            break;
        //        default:
        //            break;
        //    }
        //}
        static void Test(string test)
        {
            test = "100";
            Console.WriteLine(test);
        }
    }

    class Estimate
    {
        public string Id;
        public int[] arr;

        public Estimate()
        {
            arr = new int[1];
        }
    }
}