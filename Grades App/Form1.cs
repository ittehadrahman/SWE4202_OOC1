using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatedGradeButton_Click(object sender, EventArgs e)
        {
            double attendance = Convert.ToDouble(attededclasstextbox.Text);
            double attendancetotal = (attendance / 28) * 30;
            double attendancevalue = attendancetotal / 3;
            string attendanceshow = Convert.ToString(attendancetotal);
            AttendanceValueLabel.Text = attendanceshow + "/30";

            double mid = Convert.ToDouble(midtextbox.Text);
            double MidValue = (mid / 75) * 25;
            string Midvalueshow = Convert.ToString(mid);
            MidValueLabel.Text = Midvalueshow + "/75";

            double Final = Convert.ToDouble(Finaltextbox.Text);
            double FinalValue = (Final / 150) * 50;
            string Finalshow = Convert.ToString(Final);
            FinalValueLabel.Text = Finalshow + "/150";

            double Quiz1 = Convert.ToDouble(QuizItextbox.Text);
            double Quiz2 = Convert.ToDouble(QuizIItextbox.Text);
            double Quiz3 = Convert.ToDouble(QuizIIItextbox.Text);
            double Quiz4 = Convert.ToDouble(QuizIVtextbox.Text);
            double[] Sortingarray = { Quiz1, Quiz2, Quiz3, Quiz4 };
            Array.Sort(Sortingarray);
            double sum = 0;
            for(int i = 1; i < 4; i++)
            {
                sum = sum + Sortingarray[i];
            }
            double quiztotal = sum;
            sum = (sum / 45) * 15;
            string sumshow = Convert.ToString(quiztotal);
            QuizValueLabel.Text = sumshow + "/45";

            double percentage = attendancevalue + MidValue + FinalValue + sum;

            if (percentage >= 80)
            {
                GradeLabel.Text = "A+";
            }
            if (percentage >= 75 && percentage < 80)
            {
                GradeLabel.Text = "A";
            }
            if (percentage >= 70 && percentage < 75)
            {
                GradeLabel.Text = "A-";
            }
            if (percentage >= 65 && percentage < 70)
            {
                GradeLabel.Text = "B+";
            }
            if (percentage >= 60 && percentage < 65)
            {
                GradeLabel.Text = "B";
            }
            if (percentage >= 55 && percentage < 60)
            {
                GradeLabel.Text = "B-";
            }
            if (percentage >= 50 && percentage < 55)
            {
                GradeLabel.Text = "C+";
            }
            if (percentage >= 45 && percentage < 50)
            {
                GradeLabel.Text = "C";
            }
            if (percentage >= 40 && percentage < 45)
            {
                GradeLabel.Text = "D";
            }
            if (percentage < 40)
            {
                GradeLabel.Text = "F";
            }

            string name = Convert.ToString(Nametextbox.Text);
            LastLineTextbox.Text = name + " obtained " + percentage + "% marks.";
            percentage = percentage * 3;
            string totalshow = Convert.ToString(percentage);
            TotalValueLabel.Text = totalshow + "/300";
        }
    }
}
