using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingApp_Solution
{
    internal class Ticket
    {
        public string StudentId { get; set; }
        public char StudentCategory { get; set; }
        public int SpeedLimit { get; set; }
        public int SpeedReported { get; set; }
        public double Fine
        {
            get
            {
                int speedDiff = SpeedReported - SpeedLimit; //local variable inside get method
                if (speedDiff > 0)
                {
                    double fine = 75.0 + (speedDiff / 5) * 87.5;
                    if (StudentCategory == '4' && speedDiff > 20)
                    {
                        fine += 200; //same as fine = fine + 200
                    }
                    else if (StudentCategory == '4' && speedDiff <= 20)
                    {
                        fine += 50;
                    }
                    else if (StudentCategory == '1' && speedDiff < 20)
                    {
                        fine -= 50; //same as fine = fine - 50
                    }
                    else if (speedDiff >= 20)
                    {
                        fine += 100;
                    }
                    return fine; //puts value of fine in Fine property
                }
                else
                {
                    return 0; //Fine is set to 0
                }
            }
        }
        public string CategoryName
        {
            get
            {
                if (StudentCategory == '1')
                {
                    return "Freshman";
                }
                else if (StudentCategory == '2')
                {
                    return "Sophomore";
                }
                else if (StudentCategory == '3')
                {
                    return "Junior";
                }
                else if (StudentCategory == '4')
                {
                    return "Senior";
                }
                else
                {
                    return "Error";
                }
            }
        }

        public Ticket(string sId, char sCat, int speedLimit,
                        int speedReported)
        {
            StudentId = sId;
            StudentCategory = sCat;
            SpeedLimit = speedLimit;
            SpeedReported = speedReported;
        }
        public override string ToString()
        {
            string outputStr = "Ticket Details" +
                               "\n" + "Student Id: " + StudentId +
                               "\n" + "Student Category: "
                               + StudentCategory.ToString() +
                               "\n" + CategoryName +
                               "\n" + "Speed Limit: " + SpeedLimit +
                               "\n" + "Speed Reported: " + SpeedReported +
                               "\n" + "Fine: " + Fine.ToString("C");
            return outputStr;


        }

    }
}
