﻿namespace Abstract_part_2__Interface__Static
{
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
            Category category1 = new Category("Furniture", "fur.jpg");
            //Category category2 = new Category("Furniture", "fur.jpg");
            //Category category3 = new Category("Furniture", "fur.jpg");
            //category2.NonStaticMethod();
            //Category.StaticMethod();
            string name = " Shahin";
            int num = 5;
            num.Add(100);

            string info = name.CustomConcat("Sherifzade","18","P327");

            Console.WriteLine(info);
            category1.CustomCreateCategory("Electronics","elec.jpg");
            Console.WriteLine(category1.Name);
            Console.WriteLine(category1.Image);
            string test = "TEST";

            Console.WriteLine(test.ToLower());
            Console.WriteLine(test);

            Test(test);
            Console.WriteLine(test);
        }
        static void Test(string test)
        {
            test = "100";
            Console.WriteLine(test);
        }
    }
}