using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Group
    {
        private string _no;
        private Student[] _students;
        private  int _studentLimit;

        public string No
        {
            get { return _no; }
            set
            {
                if (No.Length != 5)
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine(char.IsUpper(No[0]) && char.IsUpper(No[1]) && char.IsDigit(No[2]) && char.IsDigit(No[3]) &&
                            char.IsDigit(No[4]));
                }
            }
        }
        
        public Student[] Students => _students;
        public int StudentLimit

        {
            get { return _studentLimit; }
            set
            {
                if (value >0 || value < 20)

                    _studentLimit = value;
            }
        }
           
        public Group(string no, int studentLimit)



        {
            No = no;
            StudentLimit = studentLimit;
           _students = new Student[0];
        }


        public void Telebeelaveet(Student student)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                {
                    _students[i] = student;


                    Console.WriteLine("qrupa telebe elave et");
                    return;
                }
            }
           
                Console.WriteLine("Bu qrupda telebe limiti kecdi");
            
        }
    }
}
