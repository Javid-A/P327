using Cinema_application.Entities;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal class CinemaService : ICinemaService
    {
        Hall[] _halls;
        public Hall[] Halls =>_halls;

        public CinemaService()
        {
            _halls = new Hall[0];
        }
        public string CreateHall(int row, int column, Categories category)
        {
            
            Hall hall = new Hall(row,column,category);
            Array.Resize(ref _halls, _halls.Length + 1);
            _halls[_halls.Length - 1] = hall;
            return hall.No;
        }

        public bool? EditHallNo(string oldNo, string newNo)
        {
            Hall existed = FindHall(oldNo);
           
            if(existed == null)
            {
                return null;
            }
            foreach (Hall hall in _halls)
            {
                if(newNo.ToUpper() == hall.No.ToUpper())
                {
                    return false;
                }
            }
            existed.No = newNo.ToUpper();
            return true;
        }

        Hall FindHall(string oldNo)
        {
            foreach (Hall hall in _halls)
            {
                if (hall.No.ToUpper() == oldNo.ToUpper())
                {
                    return hall;
                }
            }
            return null;
        }

        public void GetHalls()
        {
            if (_halls.Length > 0)
            {
                foreach (Hall hall in _halls)
                {
                    Console.WriteLine(hall);
                }
            }
            else
            {
                Console.WriteLine("There is no hall");
            }
        }

        public void GetSeatsByHall(string no)
        {
            Hall existed = FindHall(no);
            if(existed == null)
            {
                Console.WriteLine("There is no hall");
                return;
            }
            foreach (Seat seat in existed.Seats)
            {
                Console.WriteLine(seat);
            }
        }

        public bool? Reserve(int row, int column, string no)
        {
            Hall existed = FindHall(no);
            if(existed == null)
            {
                return null;
            }

            if(row>existed.Seats.GetLength(0) || column > existed.Seats.GetLength(1))
            {
                return false;
            }

            Seat seat = existed.Seats[row - 1, column - 1];//Problemli ola biler
            if (seat.Status)
            {
                GetSeatsByHall(no);
                return false;
            }
            seat.Status = true;
            return true;
        }
    }
}
