using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class Course
    {
        public Student student;
        public string title;
        
        public string level;

        public string getInfo()
        {
            string courseinfo = title + "\t" + level + "\t" + Convert.ToString(student.coursefee);
            return courseinfo;
        }

    }
}
