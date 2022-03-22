using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            using (var reader = new System.IO.StreamReader(@"F:\SWE4201MarkSheet.csv"))
            {
                InitializeListBoxValues();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    Student dummy_student = new Student();
                    try
                    {
                        dummy_student.ID = Convert.ToInt32(values[0]);
                    }
                    catch
                    {
                        dummy_student.ID = 0;
                    }
                    dummy_student.Name = values[1];
                    
                    try
                    {
                        dummy_student.Attendance = Convert.ToInt32(values[2]);
                    }
                    catch
                    {
                        dummy_student.Attendance = 0;
                    }
                    try
                    {
                        dummy_student.Quiz1 = Convert.ToInt32(values[3]);
                    }
                    catch
                    {
                        dummy_student.Quiz1 = 0;
                    }
                    try
                    {
                        dummy_student.Quiz2 = Convert.ToInt32(values[4]);
                    }
                    catch
                    {
                        dummy_student.Quiz2 = 0;
                    }
                    try
                    {
                        dummy_student.Quiz3 = Convert.ToInt32(values[5]);
                    }
                    catch
                    {
                        dummy_student.Quiz3 = 0;
                    }
                    try
                    {
                        dummy_student.Quiz4 = Convert.ToInt32(values[6]);
                    }
                    catch
                    {
                        dummy_student.Quiz4 = 0;
                    }
                    try
                    {
                        dummy_student.Mid = Convert.ToInt32(values[7]);
                    }
                    catch
                    {
                        dummy_student.Mid = 0;
                    }
                    try
                    {
                        dummy_student.Final = Convert.ToInt32(values[8]);
                    }
                    catch
                    {
                        dummy_student.Final = 0;
                    }
                    try
                    {
                        dummy_student.Viva = Convert.ToInt32(values[9]);
                    }
                    catch
                    {
                        dummy_student.Viva = 0;
                    }
                    dummy_student.Minimum(dummy_student.Quiz1,dummy_student.Quiz2,dummy_student.Quiz3,dummy_student.Quiz4);

                    dummy_student.Percentage();

                    dummy_student.Grades();
                    List_of_Students.students.Add(dummy_student);
                    

                }
            }
            InitializeListBoxValues();
        }
        private void InitializeListBoxValues()
        {
            IUTRPSlistbox.Items.Clear();
            foreach (Student temp in List_of_Students.students)
            {
                IUTRPSlistbox.Items.Add(temp.GetInfo());
            }
        }

        private void IUTRPSlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            foreach(Student dummy in List_of_Students.students)
            {
                var Student = from student in List_of_Students.students
                              select dummy.ID;
                if (dummy.ID == Convert.ToInt32(IDsearchtextbox.Text))
                {
                    Attendancelabel.Text = Convert.ToString(dummy.Attendance);
                    Quiz1label.Text = Convert.ToString(dummy.Quiz1);
                    Quiz2label.Text = Convert.ToString(dummy.Quiz2);
                    Quiz3label.Text = Convert.ToString(dummy.Quiz3);
                    Quiz4label.Text = Convert.ToString(dummy.Quiz4);
                    Quiztotallabel.Text = Convert.ToString(dummy.Quiztotal);
                    Midlabel.Text =  Convert.ToString(dummy.Mid);
                    Finallabel.Text = Convert.ToString(dummy.Final);
                    Vivalabel.Text = Convert.ToString(dummy.Viva);
                    Totallabel.Text = Convert.ToString(dummy.Total);
                    Percentagelabel.Text = Convert.ToString(dummy.percentage);
                    Gradelabel.Text = Convert.ToString(dummy.grades);
                }
                
            } 
        }
    }
}
