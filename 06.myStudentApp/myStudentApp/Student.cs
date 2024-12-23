using System;
using System.Collections.Generic;
using System.Text;

namespace myStudentApp
{
    class Student
    {
        private string studentNumber;
        private string studentLastName;
        private string studentFirstName;
        private double score1;
        private double score2;
        private double score3;
        private string major;

        public Student()
        {
            
        }

        public  Student(string stuNum, string lName, string fName)
        {
            studentNumber       = stuNum;
            studentLastName     = lName;
            studentFirstName    = fName;
        }

        public  Student(string stuNum,string lName,string fName, double s1, double s2, double s3, string maj)
        {
            studentNumber       = stuNum;
            studentLastName     = lName;
            studentFirstName    = fName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major  = maj;
        }

        public  string StudentFirstName
        {
            get 
            {
                return studentFirstName;
            }
            set 
            {
                studentFirstName = value;
            }
        }
        public string StudentLastName
        {
            get
            {
                return studentLastName;
            }
            set
            {
                studentLastName = value;
            }
        }


        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public double Score1
        {
            get
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }

        public double Score2
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
            }
        }

        public double Score3
        {
            get
            {
                return score3;
            }
            set
            {
                score3 = value;
            }
        }

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " +
                studentFirstName + " " + studentLastName +
                "\nMajor: " + major +
                "\nScore Average: " +
                CalculateAverage().ToString("F2");
        }
    }
}
