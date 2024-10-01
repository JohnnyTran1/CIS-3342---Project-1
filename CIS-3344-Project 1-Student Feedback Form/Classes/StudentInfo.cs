using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_Form_Controls_Example
{
    public class StudentInfo
    {
        private string name;
        private string studentID;
        private string course;

        public StudentInfo()
        {
            name = string.Empty;
            studentID = string.Empty;
            course = string.Empty;
        }

        public StudentInfo(string name, string studentID, string course)
        {
            this.name = name;
            this.studentID = studentID;
            this.course = course;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }
    }


}