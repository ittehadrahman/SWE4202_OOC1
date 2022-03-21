using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management
{
    public partial class Form1 : Form
    {
        List <Student> student = new List<Student>();
        List <Teacher> teacher = new List<Teacher>();
        List <Admin> admin = new List<Admin>();
        public Form1()
        {
            InitializeComponent();
        }


        private void studentclearbutton_Click(object sender, EventArgs e)
        {
            studentIDtextbox.Text = String.Empty;
            studentnametextbox.Text = String.Empty;
            studentdepartmenttextbox.Text = String.Empty;
            studentsemestertextbox.Text = String.Empty;
            MessageBox.Show("Cleared Succesfully!");

        }

        private void studentlistbutton_Click(object sender, EventArgs e)
        {
            studentlistbox.Items.Clear();

            for(int i=0; i < student.Count ; i++)
            {
                studentlistbox.Items.Add(student[i].getInfo());
            }
        }

        private void studentsavebutton_Click(object sender, EventArgs e)
        {
            int studentid = Convert.ToInt32(studentIDtextbox.Text);
            string studentname = studentnametextbox.Text;
            string studentdepartment = studentdepartmenttextbox.Text;
            int studentsemester = Convert.ToInt32(studentsemestertextbox.Text);

            Student dummy_student = new Student();
            dummy_student.studentid = studentid;
            dummy_student.studentname = studentname;
            dummy_student.studentdepartment = studentdepartment;
            dummy_student.studentsemester = studentsemester;

            student.Add(dummy_student);

            MessageBox.Show("Student has been added succesfully!"); 
        }

        private void teachersavebutton_Click(object sender, EventArgs e)
        {
            int teacherid = Convert.ToInt32(teacherIDtextbox.Text);
            string teachername = teachernametextbox.Text;
            string teacherdepartment = teacherdepartmenttextbox.Text;
            string teacherdesignation = teacherdesignationtextbox.Text;
            int teachersalary = Convert.ToInt32(teachersalarytextbox.Text);

            Teacher dummy_teacher = new Teacher();
            dummy_teacher.teacherid = teacherid;
            dummy_teacher.teachername = teachername;
            dummy_teacher.teacherdepartment = teacherdepartment;
            dummy_teacher.teacherdesignation = teacherdesignation;
            dummy_teacher.teachersalary = teachersalary;

            teacher.Add(dummy_teacher);

            MessageBox.Show("Teacher has been added succesfully!");
        }

        private void teacherclearbutton_Click(object sender, EventArgs e)
        {
            teacherIDtextbox.Text = String.Empty;
            teachernametextbox.Text = String.Empty;
            teacherdepartmenttextbox.Text = String.Empty;
            teacherdesignationtextbox.Text = String.Empty;
            teachersalarytextbox.Text = String.Empty;
            MessageBox.Show("Cleared Succesfully!");

        }

        private void teacherlistbutton_Click(object sender, EventArgs e)
        {
            teacherlistbox.Items.Clear();

            for (int i = 0; i < teacher.Count; i++)
            {
                teacherlistbox.Items.Add(teacher[i].getInfo());
            }
        }

        private void adminsavebutton_Click(object sender, EventArgs e)
        {
            int adminid = Convert.ToInt32(adminIDtextbox.Text);
            string adminname = adminnametextbox.Text;
            string admindesignation = admindesignationtextbox.Text;
            int adminsalary = Convert.ToInt32(adminsalarytextbox.Text);

            Admin dummy_admin = new Admin();
            dummy_admin.adminid = adminid;
            dummy_admin.adminname = adminname;
            dummy_admin.admindesignation = admindesignation;
            dummy_admin.adminsalary = adminsalary;

            admin.Add(dummy_admin);

            MessageBox.Show("Admin has been added succesfully!");
        }

        private void adminclearbutton_Click(object sender, EventArgs e)
        {
            adminIDtextbox.Text = String.Empty;
            adminnametextbox.Text = String.Empty;
            admindesignationtextbox.Text = String.Empty;
            adminsalarytextbox.Text = String.Empty;
            MessageBox.Show("Cleared Succesfully!");

        }

        private void adminlistbutton_Click(object sender, EventArgs e)
        {

            adminlistbox.Items.Clear();

            for (int i = 0; i < admin.Count; i++)
            {
                adminlistbox.Items.Add(admin[i].getInfo());
            }
        }

        private void teacherlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
