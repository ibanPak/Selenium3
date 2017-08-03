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
        public static string StreetAddress = "0";
        
        public static DateTime StartDT;
        public static DateTime EndDT;

        public static void ReadySetGo()
        {
            IWebDriver driver = new ChromeDriver();
            IWebDriver driver2 = new ChromeDriver();
            // IWebDriver driver = new InternetExplorerDriver();
            // IWebDriver driver = new FirefoxDriver();

            PropertiesCollection.driver = driver;
            PropertiesCollection.driver2 = driver2;
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
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowActions(ActType.Close);

        }

        public static void ConsoleOut(string displaytext)
        {
            Console.WriteLine(" ");
            Console.WriteLine(displaytext);

        }


    }


}



