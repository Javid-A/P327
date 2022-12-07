using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Entities
{
    internal class Hall
    {
        public string No;
        public Categories Category;
        public Seat[,] Seats;
        static int _count;

        public Hall(int row, int column,Categories category)
        {
            CreateNo(category);
            Category = category;
            Seats = new Seat[row, column];//3,6

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Seats[i, j] = new Seat(i+1,j+1);
                }
            }
        }
        static Hall()
        {
            _count = 0;
        }

        void CreateNo(Categories category)
        {
            switch (category)
            {
                case Categories.Drama:
                    No = $"D-{++_count}";
                    break;
                case Categories.SciFi:
                    No = $"SF-{++_count}";
                    break;
                case Categories.Comedy:
                    No = $"C-{++_count}";
                    break;
                case Categories.Action:
                    No = $"A-{++_count}";
                    break;
                case Categories.Horror:
                    No = $"H-{++_count}";
                    break;
                case Categories.Thriller:
                    No = $"T-{++_count}";
                    break;
                default:
                    break;
            }
        }
    }
}
