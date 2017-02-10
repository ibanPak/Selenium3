using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace Selenium3
{
    class Global
    {
        public static string MMddyyMinus1 = DateTime.Today.AddMonths(-1).ToString("MM-dd-yy");
        public static string MMddyyDate = DateTime.Today.ToString("MM-dd-yy");
        public static string StreetNum = DateTime.Today.Date.ToString("MMdd").TrimStart('0');
        public static string LoanNum = DateTime.Now.ToString("MMddyyHHmm").TrimStart('0');
        public static string UniqueNum = DateTime.Now.ToString("ddHHmmss").TrimStart('0');
        public static string OrderID = "0";
        public static string StreetAddress = "0";

        public static void ConsoleOut(string displaytext)
        {
            Console.WriteLine(" ");
            Console.WriteLine(displaytext);

        }


    }


}



