using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Entities
{
    internal class Seat
    {
        public int Row;
        public int Column;
        public bool Status;

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            Status = false;
        }

        public override string ToString()
        {
            return $"Sira: {Row}, Sutun:{Column}, Status :{(Status ? "Doludur" : "Boshdur")}";
        }
    }
}
