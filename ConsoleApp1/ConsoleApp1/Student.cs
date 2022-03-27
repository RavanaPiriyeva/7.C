using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student(string fullname , int groupno)
        {
            this.FullName = fullname;
            this.GroupNo = groupno;
        }

        public Student(string fullname, int groupno ,int avgpoint)
        {
            this.FullName = fullname;
            this.GroupNo = groupno;
            this.AvgPoint=avgpoint;

        }

        public string FullName;
        public int GroupNo;
        public int AvgPoint;



    }
}
