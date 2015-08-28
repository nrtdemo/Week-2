using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        public string Name
        {
            get; set;
        }
        public string Student_id
        {
            get; set;
        }

        private int _YearOfBirth;
        public int YearOfBirth
        {
            get
            {
                return _YearOfBirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    //throw new OverflowException(Student_id + ": error try setting invalid year-of-birth value!");
                    Console.WriteLine(Student_id + ": error try setting invalid year-of-birth value!");
                }
                else
                    _YearOfBirth = value;
            }
        }
        public bool isActive
        {
            get; set;
        }

        public Student()
        {
            this.Name = "John Doe";
            this.Student_id = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = true;
        }
        public Student(string name, string student_id)
        {
            this.Name = name;
            this.Student_id = student_id;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }
        public Student(string name, string student_id, int yearofbirth)
        {
            this.Name = name;
            this.Student_id = student_id;
            this.YearOfBirth = yearofbirth;
            this.isActive = true;
        }
        public Student(string name, string student_id, int yearofbirth, bool isactive)
        {
            this.Name = name;
            this.Student_id = student_id;
            this.YearOfBirth = yearofbirth;
            this.isActive = isactive;
        }
        public int getAge
        {
            get
            {
                return Convert.ToInt32(DateTime.Now.Year.ToString()) - _YearOfBirth;
            }
        }
        public override string ToString()
        {
            string s = "Student: " + Name + " (" + Student_id + "), age=" + getAge + ", is "+(this.isActive? "active student " : "NOT active student ");
            return s;
        }
    }
}
