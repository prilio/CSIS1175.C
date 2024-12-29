using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentAppWithAutoProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice Exercise: After reviewing the example given below, and create a
            //Console project for Carpet Calculator Demo using Classes
            //Using Carpet class - Add a Carpet Class to your project with
            //CarpetName and CarpetPrice ($ amount per sq. yd - double data) - read-only properties
            //CarpetLength, CarpetWidth - read-write auto properties in ft (double)
            //AreaInSqYds - read-only computed property 
            //CarpetCost - read-only computed property (AreaInSqYds*CarpetPrice)

            //In the main program, then create berberCarpet, pileCarpet objects
            //Get User input for all the needed properties,
            //display the details including cost for each of these objects

            Console.WriteLine("Hello World!");
            Student firstStudentObject = new Student();
            GetStudentName(out string firstName, out string lastName);

            WriteLine("First name is {0}, last name is {1}", firstName, lastName);
            WriteLine("First Student Id = " + firstStudentObject.StudentId);
            WriteLine("First Student's grade 1 = " + firstStudentObject.Grade1);
            WriteLine("First Student Details...");
            WriteLine(firstStudentObject); //automatically calls firstStudentObject.ToString()

            firstStudentObject.StudentFirstName = firstName;
            firstStudentObject.StudentLastName = lastName;


            firstStudentObject.Major = GetMajor(); //GetMajor() returns a string,
                                                   //and that string value is assigned to the Major property
                                                   //of the first object
            WriteLine(firstStudentObject);

            firstStudentObject.Grade1 = GetGrade(1);
            firstStudentObject.Grade2 = GetGrade(2);
            firstStudentObject.Grade3 = GetGrade(3);

            WriteLine(firstStudentObject);

            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString()); //this is the same as WriteLine(firstStudentObject);
            firstStudentObject.StudentId = "300123"; //read-only property cannot be set

            WriteLine("\n\nSecond student: Using 1-parameter constructor to set student id");
            Student secondStudentObject = new Student(GetStudentId());
            WriteLine(secondStudentObject);

            secondStudentObject.Grade1 = 95;
            secondStudentObject.Grade2 = 62;
            secondStudentObject.Grade3 = 87;
            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + secondStudentObject.StudentId +
                               "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());

            WriteLine("\n\nThird student: Using 3 parameter constructor");
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Grade1 = 95;
            thirdStudentObject.Grade2 = 87;
            thirdStudentObject.Grade3 = 72;
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);


            WriteLine("\n\nFourth Student: setting 6 properties for the object with constructor");
            Student fourthStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");
            WriteLine("\n\nFourth Student");
            WriteLine(fourthStudentObject);


            //We will go over this concept next class, but take a look at the demo
            //and see its output

            WriteLine("\n\nFifth Student: passing objects as parameter for methods..");
            Student fifthStudentObject = new Student(GetStudentId());

            WriteLine("Looking at fifth student details after id is set...");
            WriteLine(fifthStudentObject);

            WriteLine("Npw let us pass this object to Load Student Details method and see what happens to the argument object...");
            LoadStudentDetails(fifthStudentObject);
            WriteLine("\n\nFifth Student after method is executed.....argument object properties values have changed now...");
            WriteLine(fifthStudentObject);

            Write("Enter the student number you would like to view (1/2/3/4/5): ");
            int option = int.Parse(ReadLine());

            if (option == 1)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(firstStudentObject);
            }
            else if (option == 2)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(secondStudentObject);
            }
            else if (option == 3)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(thirdStudentObject);
            }
            else if (option == 4)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(fourthStudentObject);
            }
            else if (option == 5)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(fifthStudentObject);
            }
            else
            {
                WriteLine("Student view options can only 1, 2, 3 or 4");
            }
        }
        private static void LoadStudentDetails(Student fifthStudentObject)
        {
            string fName, lName;
            GetStudentName(out fName, out lName);
            fifthStudentObject.StudentFirstName = fName;
            fifthStudentObject.StudentLastName = lName;
            fifthStudentObject.Major = GetMajor();
            fifthStudentObject.Grade1 = GetGrade(1);
            fifthStudentObject.Grade2 = GetGrade(2);
            fifthStudentObject.Grade3 = GetGrade(3);
        }

        static int GetGrade(int gradeNumber)
        {
            Write("Enter a value for Grade {0}: ", gradeNumber);
            int grade = int.Parse(ReadLine());
            return grade;
        }

        static void GetStudentName(out string studFirstName, out string studLastName)
        {
            Write("Enter Student First Name: ");
            studFirstName = ReadLine();
            Write("Enter Student Last Name: ");
            studLastName = ReadLine();
        }
        static string GetMajor()
        {
            Write("Enter Major: ");
            string major = ReadLine();
            return major;
        }
        static string GetStudentId()
        {
            Write("Enter Student Id: ");
            string id = ReadLine();
            return id;
        }


    }
}
