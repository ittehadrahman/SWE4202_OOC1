using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Processing_System
{
    public class Student
    {
        public int ID;
        public string Name;
        public int Attendance, Quiz1, Quiz2, Quiz3, Quiz4, Mid, Final, Viva;
        public string grades;
        public int Quiztotal;
        public int temp1, temp2, minimum, percentage;
        public int Total;
            
    public Student(int ID, string Name, int Attendance, int Quiz1, int Quiz2, int Quiz3, int Quiz4, int Mid, int Final, int Viva)
        {
            this.ID = ID;
            this.Name = Name;
            this.Attendance = Attendance;
            this.Quiz1 = Quiz1;
            this.Quiz2 = Quiz2;
            this.Quiz3 = Quiz3;
            this.Quiz4 = Quiz4;
            this.Mid = Mid;
            this.Final = Final;
            this.Viva = Viva;

        }

        public Student()
        {

        }

        public void Minimum(int a, int b, int c, int d)
        {
            if (Quiz1 > Quiz2)
            {
                temp1 = Quiz2;
            }
            else
            {
                temp1 = Quiz1;
            }
            if (Quiz3 > Quiz4)
            {
                temp2 = Quiz4;
            }
            else
            {
                temp2 = Quiz3;
            }
            if (temp1 > temp2)
            {
                minimum = temp2;
            }
            else
            {
                minimum = temp1;
            }
        }
        
        
        public void Percentage()
        {
            Quiztotal = Quiz1 + Quiz2 + Quiz3 + Quiz4 - minimum;
            Total = Attendance +  Quiztotal + Mid + Final + Viva;
            percentage = Total / 3;
            
        }
        public void Grades()
        {
            if (percentage >= 80 && percentage <= 100)
            {
                grades = "A+";
            }
            else if (percentage >= 75 && percentage < 80)
            {
                grades = "A";
            }
            else if (percentage >= 70 && percentage < 75)
            {
                grades = "A-";
            }
            else if (percentage >= 65 && percentage < 70)
            {
                grades = "B+";
            }
            else if (percentage >= 60 && percentage < 65)
            {
                grades = "B";
            }
            else if (percentage >= 55 && percentage < 60)
            {
                grades = "B-";
            }
            else if (percentage >= 50 && percentage < 55)
            {
                grades = "C+";
            }
            else if (percentage >= 45 && percentage < 50)
            {
                grades = "C";
            }
            else if (percentage >= 40 && percentage < 45)
            {
                grades = "D";
            }
            else if (percentage >= 0 && percentage < 40)
            {
                grades = "F";
            }
        }

        public string GetInfo()
        {
            return Convert.ToString(ID)+"\t"+ Name + "\t"+grades+ "\t" + percentage;
        }
    }
}
