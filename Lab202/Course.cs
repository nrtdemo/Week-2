using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        public string Name
        {
            get; set;
        }
        private string _CourseID;
        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                if (value.Length == 6 && value != CourseID)
                {
                    _CourseID = value;
                }
                else
                    Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
            }
        }
        public string Lecturer
        {
            get; set;
        }
        private int _MaxStudents;
        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {
                if (value >= 0 && value <= 80 && value >= NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!");
                }
            }
        }
        private int _NumStudents;
        public int NumStudents
        {
            get { return _NumStudents; }
            set
            {
                if (value < 0 || value > _MaxStudents)
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No.Students!");
                }
                else
                {
                    _NumStudents = value;
                }
            }
        }
        public override string ToString()
        {
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + _NumStudents + " student, max=" + _MaxStudents;
            return s;
        }
        public Course()
        {
            this.Name = "";
            this.CourseID = "";
            this.Lecturer = "staff";
            this.MaxStudents = 30;
        }
        public Course(string name, string courseid)
        {
            this.Name = name;
            this.CourseID = courseid;
            this.Lecturer = "staff";
            this.MaxStudents = 30;
        }
        public Course(string name, string courseid,string lecturer)
        {
            this.Name = name;
            this.CourseID = courseid;
            this.Lecturer = lecturer;
            this.MaxStudents = 30;
        }
        public Course(string name, string courseid, string lecturer,int maxstudent)
        {
            this.Name = name;
            this.CourseID = courseid;
            this.Lecturer = lecturer;
            this.MaxStudents = maxstudent;
        }
    }
}
