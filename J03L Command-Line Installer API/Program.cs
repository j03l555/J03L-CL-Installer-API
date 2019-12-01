using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace J03L_Command_Line_Installer_API
{
    public class J03L_CLIAPI
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
        static bool ShowLicense(string licenseText)
        {
            string newLicenseText = Regex.Replace(licenseText, @"^\s+$[\r\n]*", System.Environment.NewLine + "                                                                                                                       "+System.Environment.NewLine, RegexOptions.Multiline); // I'm sure there is a much better way to get around this, but to make our lives easier, we add an extra 120 whitespaces (the length of a single command-line window at the default window size) after a new line so that we can calculate our pages correctly later on.
            int length = newLicenseText.Length;
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
            decimal dPages = lines / 29;
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
            int currentLine = 1;
            bool userAgree = false;
            bool userDisagree = false;
            bool isLastPage = false;
            do
            {
                StringReader licenseLineReader = new StringReader(newLicenseText);
                Console.Clear();
                do
                {
                    Console.WriteLine(licenseLineReader.ReadLineAsync());
                    currentLine = currentLine + 1;
                }
                while (currentLine <= 29);
                Console.Write("Scroll: UP/DOWN  ");
                if (currentPage == pages)
                {
                    isLastPage = true;
                    Console.Write("Agree: Y  Disagree: N");
                }
                else
                {
                    isLastPage = false;
                }
                ConsoleKey keyPressed = Console.ReadKey(true).Key;
                if (isLastPage == true)
                {
                    if (keyPressed == ConsoleKey.Y)
                    {
                        //They pressed Y
                        userAgree = true;
                    }
                    if (keyPressed == ConsoleKey.N)
                    {
                        userDisagree = true;
                        //They pressed N
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (currentPage != pages)
                    {
                        currentPage = currentPage + 1;
                    }
                }
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (currentPage != 1)
                    {
                        currentPage = currentPage - 1;
                    }
                }
                if (userAgree == true)
                {
                    break;
                }
                if (userDisagree == true)
                {
                    break;
                }


            }
            while (true);
            if (userDisagree != true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
