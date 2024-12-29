/* CSIS 1175
 * Section #001
 * Prof: Priya
 *Student: Priscila Lio Crudi
 *ID: 300358805 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriscilaC_Assign2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Responsible for Run the program.
            Application.Run(new Form1());
        }
    }
}
