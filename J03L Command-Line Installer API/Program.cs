using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J03L_Command_Line_Installer_API
{
    class Program
    {
        // ASSIGN MAIN VARIABLES.
        static string VERSION = "0.0.1-initial";
        static void Main(string[] args)
        {
            Console.WriteLine(@"====[J03L Command-Line Installer API]====
Version " + VERSION + @"
Author: Joel Astley
Author's GitHub:
https://github.com/joelastley555
Project's GitHub:
https://github.com/joelastley555/J03L-CL-Installer-API
License:
https://github.com/joelastley555/J03L-CL-Installer-API/blob/master/LICENSE");   
        }
        static void CreateInstaller(string installName, bool installFromInternet, bool hasLicense, bool mustScrollToAccept, string licenseText)
        {

        }
        static ShowLicense(string licenseText)
        {
            int length = licenseText.Length;
            decimal dLines = length / 120;
            int lines = new int();
            if (Math.Round(dLines) != dLines) // A useful hack that checks whether or not a number is whole. We round the number. If the number is whole, it will stay the same, but if it is not whole, it will be rounded and therefore be different from the original number.
            {
                //Our dLines number was not a whole number, so we round it. We then add 1 to it because Math.Round always rounds down which would result in us missing a line.
                lines = decimal.ToInt32(Math.Round(dLines)) + 1;
            }
            else
            {
                lines = decimal.ToInt32(dLines);
            }
            decimal dPages = lines / 30;
            int pages = new int();
            if (Math.Round(dPages) != dPages) // A useful hack that checks whether or not a number is whole. We round the number. If the number is whole, it will stay the same, but if it is not whole, it will be rounded and therefore be different from the original number.
            {
                //Our fPages number was not a whole number, so we round it. We then add 1 to it because Math.Round always rounds down which would result in us missing a page.
                pages = decimal.ToInt32(Math.Round(dPages)) + 1;
            }
            else
            {
                pages = decimal.ToInt32(dPages);
            }
            int currentPage = 1;
            do
            {

            }
            while (true);
            
        }
    }
}
