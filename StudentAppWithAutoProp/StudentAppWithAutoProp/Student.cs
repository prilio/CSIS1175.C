using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppWithAutoProp
{
    internal class Student
    {
        //Auto-Properties
        public string StudentLastName
        {
            //read-write auto property
            get;
            set;
        }

        public string StudentFirstName
        {
            get;
            set;
        }


        public string Major
        {
            get;
            set;
        }

        public int Grade1
        {
            get;
            set;
        }

        public int Grade2
        {
            get;
            set;
        }

        public int Grade3
        {
            get;
            set;
        }

        //read-only auto-property
        //read-only auto property can only be assigned values
        //when object is created using the constructor method
        //cannot be changed at any other point later
        public string StudentId
        {
            get; //no setter, so value cannot be set after the constructor call
            
        }

        //read-only computed property
        //computed properties can never be set up directly either 
        //in the constructor or anytime later
        //they are always computed (dependent) on other properties
        public int MaxGrade
        {
            get
            {
                return Math.Max(Grade1, Math.Max(Grade2, Grade3));
            }
        }

        //Default constructor
        //dummy constructor
        //parameterless constructor
        public Student()
        {
            StudentId = "0000000";
            //int properties not assigned to will get 0 value
            //string property not assigned will initially get
            // "" by default
        }

        //Constructor with one argument
        public Student(string sID)
        {
            StudentId = sID; //note property = parameter
        }

        //Constructor with three arguments
        public Student(string sID, string lastName, string firstName)
        {
            StudentId = sID;
            StudentLastName = lastName;
            StudentFirstName = firstName;
        }

        //Constructor with six arguments
        public Student(string sID, string lastName, string firstName,
                       int s1, int s2, int s3, string maj)
        {
            StudentId = sID;
            StudentLastName = lastName;
            StudentFirstName = firstName;
            Grade1 = s1;
            Grade2 = s2;
            Grade3 = s3;
            Major = maj;
        }

        //Method defined inside the class
        //note that, methods that need to be
        //called with objects outside the class need to be declared as public (non-static)

        public double CalculateAverage()
        {
            return (Grade1 + Grade2 + Grade3) / 3.0;
        }

        //ToString() method is override method that returns a string that combines all the data in some 
        //formatted or concatenated output
        public override string ToString()
        {
            string studString = "Student Id: " + StudentId +
                                    "\nName: " + StudentFirstName + " " + StudentLastName +
                                    "\nMajor: " + Major +
                                    "\nScore Average: " +
                                    CalculateAverage().ToString("F2") +
                                    "\nMaxGrade: " + MaxGrade;
            return studString;
        }

    }
}
