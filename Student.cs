using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Student
    {
        public string fullname;
        public int groupNo;
        public double avgPoint;


        public string Fullname

        {
            get { return fullname; }
            set { fullname = value; }
        }


        public int GroupNo
        {
            get { return groupNo; }
            set { groupNo = value; }
        }


        public double AvgPoint
        {
            get { return avgPoint; }
            set { avgPoint = value; }
        }
        public Student(string fullname, int groupNo, double avgPoint)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            AvgPoint = avgPoint;

        }
    }

}
