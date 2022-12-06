using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal static class Extensions
    {
        public static void Add(this int number,int number2)
        {
            Console.WriteLine(number + number2);
        }

        public static string CustomConcat(this string word,params string[] words)
        {
            StringBuilder result = new StringBuilder(word + " ");
            foreach (string item in words)
            {
                result.Append(item + " ");
            }
            return result.ToString().Trim();
        }

        public static Category CustomCreateCategory(this Category category, string name, string image)
        {
            category.Name = name;
            category.Image = image;
            return category;
        }
    }
}
