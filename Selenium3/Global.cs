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
        public static string LastMonth = DateTime.Today.AddMonths(-1).ToString("MM/dd/yyyy");
        public static string LastYear = DateTime.Today.AddYears(-1).ToString("MM/dd/yyyy");
        public static string NextMonth = DateTime.Today.AddMonths(1).ToString("MM/dd/yyyy");
        public static string MMddyyDate = DateTime.Today.ToString("MM/dd/yyyy");
        public static string StreetNum = DateTime.Today.Date.ToString("MMdd").TrimStart('0');
        public static string LoanNum = DateTime.Now.ToString("MMddHHmmss").TrimStart('0');
        public static string UniqueNum = DateTime.Now.ToString("ddHHmmss").TrimStart('0');
        public static string OrderID = "0";
        public static string PropertyID = "0";
        public static string UniversalID = "0";
        public static string Value = "0";
        public static string StreetAddress = "0";
        public static int ThrottleSleep = 2*(1000);
        public static DateTime StartDT;
        public static DateTime EndDT;

        public static void ReadySetGo()
        {
            IWebDriver driver = new ChromeDriver(); PropertiesCollection.driver = driver;
            // IWebDriver driver2 = new InternetExplorerDriver(); PropertiesCollection.driver2 = driver2;
            // IWebDriver driver = new InternetExplorerDriver(); PropertiesCollection.driver = driver;
            // IWebDriver driver = new FirefoxDriver(); PropertiesCollection.driver = driver;

            SeleniumWindowMethods.WindowActions(ActType.Maximize);
            Global.StartDT = DateTime.Now;
            Global.ConsoleOut("Test started @ " + Global.StartDT);

        }

        public static void Cooldown()
        {
            Global.EndDT = DateTime.Now;
            var seconds = (Global.EndDT - Global.StartDT).TotalSeconds;
            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;

            Global.ConsoleOut("Test took " + hour + " Hours, " + min + " minutes, " + sec + " seconds to run");
        }

        public static void Done()
        {
            Global.ConsoleOut("Test was completed successfully");
            SeleniumWindowMethods.Sleep(5);
            SeleniumWindowMethods.WindowActions(ActType.Close);

        }

        public static void ConsoleOut(string displaytext)
        {
            Console.WriteLine(" ");
            Console.WriteLine(displaytext);

        }


    }


}



