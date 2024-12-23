using System;

namespace myStudentApp
{
    class myStudentApp
    {
        static void Main(string[] args)
        {
            Student firstStudentObject = new Student();

            firstStudentObject.StudentLastName = AskForSring("LastName");
            firstStudentObject.StudentFirstName = AskForSring("FirstName");
            firstStudentObject.StudentNumber = AskForSring("StudentNumber");
            firstStudentObject.Major = AskForSring("Major");
            firstStudentObject.Score1 = AskForScore(1);
            firstStudentObject.Score2 = AskForScore(2);
            firstStudentObject.Score3 = AskForScore(3);

            Console.WriteLine(firstStudentObject.ToString());
        }

        public static string AskForSring(string info)
        {
            string inputValue;
            Console.Write("Enter Student {0} : ", info);
            inputValue = Console.ReadLine();
            return inputValue;
        }

        public static double AskForScore(int info)
        {
            string inputValue;
            double score;
            Console.Write("Enter Student score{0} : ", info);
            inputValue = Console.ReadLine();

            while(double.TryParse(inputValue,out score) == false)
            {
                Console.Write("Not a valid score! Enter Student score{0} : ", info);
            }

            return score;
        }



    }
}
