using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class EnrollCourse
    {
        public Student student;
        public Course course;
        public string enrollmentdate;
        public string getInfo()
        {
            string enrolledcourseinfo = student.name + "\t" + course.title;
            return enrolledcourseinfo;
        }
    }
}
