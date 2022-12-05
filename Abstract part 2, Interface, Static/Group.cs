using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Group
    {
        public string No;
        public byte Limit;
        Student[] _students;
        int _index;
        public Group(string no, byte limit)
        {
            _students = new Student[limit];
            No = no;
            Limit = limit;
            _index = default;
        }

        public Student AddStudent(Student student)
        {
            //for (int i = 0; i < Students.Length; i++)
            //{
            //    if (Students[i] != null)
            //    {
            //        continue;
            //    }
            //    if (Students[i] == null)
            //    {
            //        Students[i] = student;
            //        break;
            //    }
            //}

            //return student;

            if(Limit > _index)
            {
                _students[_index++] = student;
                student.Group = this;
            }
            else
            {
                Console.WriteLine("Bu qrup doludur");
            }
            return student;
        }

        public void GetStudents()
        {
            foreach (Student student in _students)
            {
                if (student != null)
                {
                Console.WriteLine(student);

                }
                else
                {
                    Console.WriteLine("Boshdur");
                }
            }
        }
    }
}
