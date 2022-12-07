using Cinema_application.Entities;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal interface ICinemaService
    {
        Hall[] Halls { get; }
        string CreateHall(int row, int column, Categories category);
        bool EditHallNo(string oldNo, string newNo);
        void GetHalls();
        void GetSeatsByHall(string no);
        bool Reserve(int row, int column, string no);
    }
}
