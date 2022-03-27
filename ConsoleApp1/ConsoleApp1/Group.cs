using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Group
    {
        public Group()
        {

        }
        public Group ( string no , int studentlimit)

        {
            this.No = no;
            this.StudentLimit = studentlimit;
        }
        public string No;
        public Student [] Students;
        public int StudentLimit;
        int j=0;
        public void AddStudent(Student students)
        {
            
            

                Students[j++] = students;
           
            
            
        }


        public Student[] GetFiltired ( string fullname)
        {
            int count = 0;
            foreach (var item in Students)
            {
                if(item != null) { 
                if (item.FullName == fullname)
                {
                    count++;
                }
                }
            }
            Student[] newfullname = new Student[count];
            int x = 0;
            foreach (var item in Students)
            {
                if (item != null)
                {
                    if (item.FullName == fullname)
                    {
                        newfullname[x++] = item;
                    }
                }
            }
            return newfullname;
        }


        public Student[] GelFilteredPoint(int minprice, int maxprice)
        {
            int count = 0;
            foreach (var item in Students)
            {
                if (item != null) { 
                if (item.AvgPoint > minprice && item.AvgPoint < maxprice)
                {
                    count++;
                }
            }
            }
            Student[] newarr = new Student[count];
            int x = 0;
            foreach (var item in Students)
            {
                if (item != null)
                {
                    if (item.AvgPoint > minprice && item.AvgPoint < maxprice)
                    {
                        newarr[x++] = item;
                    }
                }
            }
            return newarr;
        }

        public Student[] GelFilteredGroup(int groupno)
        {
            int count = 0;
            foreach (var item in Students)
            {
                if (item != null) { 
                    if (item.GroupNo == groupno)
                    {
                        count++;
                    }
            } }
            Student[] newarr = new Student[count];
            int x = 0;
          
                foreach (var item in Students)
            {
                if (item != null)
                {
                    if (item.GroupNo == groupno)
                    {
                        newarr[x++] = item;
                    }
                }
            }
            return newarr;
        }
        public void GetInfo ( Student[] student1)
        {
            Console.WriteLine("==========TELEBELERIN SIYAHISI=========== \n");
            int count = 0;
            foreach (var item in student1)
            {
                if (item == null)
                {
                    count++;
                    Console.WriteLine(count + " nomreli yer bosdur ");
                }
            }
            foreach (var item in student1)
                    {
                if (item == null)
                { 
                }
                else
                {
                   
                    Console.WriteLine($" FULLNAME:{item.FullName}        GROUPNO: {item.GroupNo}      AVGPOINT:{item.AvgPoint}");
                }
                    }
        }
    }
}
