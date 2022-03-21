using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<EnrollCourse> enrolledcourses = new List<EnrollCourse>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Nametextbox.Text;
            int regno = Convert.ToInt32(Regnotextbox.Text);
            int contactno = Convert.ToInt32(contactnotextbox.Text);
            string email = emailtextbox.Text;
           

            Student dummy_student = new Student();
            dummy_student.name = name;
            dummy_student.regno = regno;
            dummy_student.contactno = contactno;
            dummy_student.email = email;
            if (studentrb1.Checked == true)
            {
                dummy_student.type = "Student";
            }
            else
            {
                dummy_student.type = "Professional";
            }
            if (beginnerrb1.Checked == true)
            {
                dummy_student.level = "Beginner";
            }
            else if(intermediaterb1.Checked == true)
            {
                dummy_student.level = "Intermediate";
            }
            else if(advancedrb1.Checked == true)
            {
                dummy_student.level = "Advanced";
            }
            else
            {
                dummy_student.level = "Beginner";
            }
            students.Add(dummy_student);
            studentcombobox.Items.Add(regno);
            selectedstudentcombobox.Items.Add(regno);
            MessageBox.Show("Participant Info Added Successfully!!");

        }

        private void enrollinacoursegroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void entercourseinfobutton_Click(object sender, EventArgs e)
        {
            string title = titletextbox.Text;
            double coursefee = Convert.ToInt32(coursefeetextbox.Text);

            Course dummy_course = new Course();
            dummy_course.student = new Student();
            dummy_course.title = title;
            dummy_course.student.coursefee = coursefee;
            if (beginnerrb2.Checked == true)
            {
                dummy_course.level = "Beginner";
            }
            else if (intermediaterb2.Checked == true)
            {
                dummy_course.level = "Intermediate";
            }
            else if (advancedrb2.Checked == true)
            {
                dummy_course.level = "Advanced";
            }
            else if(beginnerrb2.Checked == false && intermediaterb2.Checked == false && advancedrb2.Checked == false)
            {
                dummy_course.level = "Beginner";
            }
            courses.Add(dummy_course);
            selectcousecombobox.Items.Add(title);
            MessageBox.Show("Course Added Successfully!!");
        }

        private void payandenrollbutton_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;

            EnrollCourse dummy_enrollcourse = new EnrollCourse();
            dummy_enrollcourse.enrollmentdate = date;

            foreach(Student dummy in students)
            {
                if (dummy.regno == Convert.ToInt32(studentcombobox.Text))
                {
                    dummy.coursefee = 500;
                    if (dummy.level == "Professional")
                    {
                        dummy.coursefee = dummy.coursefee * 1.10;
                    }
                }
                showcoursefeelabel.Text = Convert.ToString(dummy.coursefee);
                MessageBox.Show("Course has been added!!");
            }
        }

        private void viewenrolledcousebutton_Click(object sender, EventArgs e)
        {

            foreach (Course dummy in courses)
            {

                enrolledcourselistbox.Items.Add(dummy.getInfo());
            }
        }
    }
}
