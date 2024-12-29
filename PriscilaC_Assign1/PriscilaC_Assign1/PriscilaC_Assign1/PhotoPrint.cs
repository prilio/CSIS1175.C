using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaC_Assign1
{
    internal class PhotoPrint
    {
        //Read-only auto properties
        public string SizeName
        {
            get;
        }

        public double PrintUnitPrice
        {
            get;
        }

        //Read-write auto property
        public int NumPrints
        {
            get;
            set;
        }
       


        //Read-only computer property
        public double PrintTotal
        {
            get
            {
                return NumPrints * PrintUnitPrice;
            }
        }

        //Constructors
        public PhotoPrint(string sizeName, double unitPrice)
        {
            SizeName = sizeName;
            PrintUnitPrice = unitPrice;
        }

        //First try
        //public override string ToString()
        //{
        //    string photoString = SizeName + PrintUnitPrice + NumPrints + PrintTotal;

        //    return photoString;
        //}


        //Second try
        //public override string ToString()
        //{
        //    string photoString =
        //        "*                   SizeName: " + SizeName +
        //        "\n*                  UnitPrice: " + PrintUnitPrice.ToString("C") +
        //        "\n*                  NumPrints: " + NumPrints + 
        //        "\n*                 PrintTotal: " + PrintTotal.ToString("C") + 
        //        "\n*                                              *";
        //    return photoString;
        //}

        //Third try
        public override string ToString()
        {
            string photoString;
            photoString = String.Format("*{0,36}: {1,-24:C}*" +
            "\n*{2,36}: {3,-24:C}*" +
            "\n*{4,36}: {5,-24:C}*" +
            "\n*{6,36}: {7,-24:C}*", 
            "Photo Size", SizeName, "Unit Price", PrintUnitPrice, "Number of Prints", 
            NumPrints, "Total for this Print Size", PrintTotal);
            return photoString;
        }


    }

}
