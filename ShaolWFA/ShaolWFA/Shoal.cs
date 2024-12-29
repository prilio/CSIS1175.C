using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaolWFA
{
    class Shoal
    {
        public string Location { get; set; }
        public string State { get; set; }
        public double MileMarker { get; set; }
        public double[] DepthLowTides { get; set; }
        public double[] DepthHighTides { get; set; }

        public Shoal(string location, string state,
                    double mileMarker, double[] low,
                    double[] high)
        {
            Location = location;
            State = state;
            MileMarker = mileMarker;
            DepthLowTides = low;
            DepthHighTides = high;
        }
        public double CalculateAvergage(double[] tides)
        {
            double sum = 0, avg = 0;
            foreach(double val in tides)
            {
                sum += val;
            }
            if (tides.Length > 0)
            {
                avg = sum / tides.Length;
            }
            return avg;
        }
        public double HighTideAvg
        {
            get
            {
                double hSum = 0, hAvg = 0;
                foreach(double val in DepthHighTides)
                {
                    hSum += val;
                }
                if (DepthHighTides.Length > 0)
                {
                    hAvg = hSum / DepthHighTides.Length;
                }
                return hAvg;
            }
        }

        public double LowTideAvg
        {
            get
            {
                double lSum = 0, lAvg = 0;
                foreach (double val in DepthLowTides)
                {
                    lSum += val;
                }
                if (DepthLowTides.Length > 0)
                {
                    lAvg = lSum / DepthLowTides.Length;
                }
                return lAvg;
            }
        }

        public override string ToString()
        {
            string outputStr = Location + "\t" +
                                State + "\t" +
                                MileMarker.ToString("N1") + "\t";
            for (int i = 0; i < DepthLowTides.Length; i++)
            {
                outputStr += DepthLowTides[i].ToString("N1");
                if (i != DepthLowTides.Length - 1)
                {
                    //add - to the tide depths if it is
                    //not the last element
                    outputStr += "-";
                }
            }
            outputStr += "\t\t"; //just added two tabs to separate the low tide depths and high tide depths and the average for more clarity
            for (int i = 0; i < DepthHighTides.Length; i++)
            {
                outputStr += DepthHighTides[i].ToString("N1");
                if (i != DepthHighTides.Length - 1)
                {
                    outputStr += "-";
                }
            }
            outputStr += "\t\t";
            outputStr += LowTideAvg.ToString("F2") + "\t" + HighTideAvg.ToString("F2");
           /* outputStr += CalculateAvergage(DepthLowTides)
                                        .ToString("F2")
                                            + "\t";
            outputStr += CalculateAvergage(DepthHighTides)
                                        .ToString("F2"); */
            return outputStr;
        }

    }
}
