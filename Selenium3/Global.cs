using System.Configuration;
using System.Collections.Specialized;
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
        public static string NextYear = DateTime.Today.AddYears(1).ToString("MM/dd/yyyy");
        public static string MMddyyDate = DateTime.Today.ToString("MM/dd/yyyy");
        public static string StreetNum = DateTime.Today.Date.ToString("MMdd").TrimStart('0');
        public static string LoanNum = DateTime.Now.ToString("MMddHHmmss").TrimStart('0');
        public static string UniqueNum = DateTime.Now.ToString("ddHHmmss").TrimStart('0');
        public static float passcount = 0;
        public static float failcount = 0;
        public static string OrderID = "0";
        public static string PropertyID = "0";
        public static string UniversalID = "0";
        public static string Value = "0";
        public static string StreetAddress = "0";
        public static string Display;
        public static bool IsPresent = false;
        public static int ThrottleSleep = 2 * (1000);
        public static DateTime StartDT;
        public static DateTime EndDT;
        public static string Username;
        public static string Password;

        // App Config
        public static string folderpath = ConfigurationManager.AppSettings.Get("PublicFolder");
        public static string buildenv = ConfigurationManager.AppSettings.Get("BuildENV");
        public static string valportal = ConfigurationManager.AppSettings.Get("ValPortal");
        public static string valclientportal = ConfigurationManager.AppSettings.Get("ValClientPortal");
        public static string propertycure = ConfigurationManager.AppSettings.Get("PropertyCure");
        public static string agentportal = ConfigurationManager.AppSettings.Get("AgentPortal");
        public static string vendorportal = ConfigurationManager.AppSettings.Get("VendorPortal");
        public static string reoportal = ConfigurationManager.AppSettings.Get("REOPortal");
        public static string lossmitportal = ConfigurationManager.AppSettings.Get("LossMitPortal");
        public static string buyerportal = ConfigurationManager.AppSettings.Get("BuyerPortal");
        public static string homeownerportal = ConfigurationManager.AppSettings.Get("HomeOwnerPortal");

        public static string qavalportaluser = ConfigurationManager.AppSettings.Get("QAValPortalUser");
        public static string qavalportalpassword = ConfigurationManager.AppSettings.Get("QAValPortalPassword");
        public static string qaagentportaluser = ConfigurationManager.AppSettings.Get("QAAgentPortalUser");
        public static string qaagentportalpassword = ConfigurationManager.AppSettings.Get("QAAgentPortalPassword");
        public static string qaprovidersourceid = ConfigurationManager.AppSettings.Get("QAProviderSourceId");

        // Test Address
        public static string subjectstreetnumber;
        public static string subjectstreetname;
        public static string subjectcity;
        public static string subjectzipcode;
        public static string subjectstate;

        public static string sc1street;
        public static string sc1city;
        public static string sc1zipcode;
        public static string sc1state;

        public static string sc2street;
        public static string sc2city;
        public static string sc2zipcode;
        public static string sc2state;

        public static string sc3street;
        public static string sc3city;
        public static string sc3zipcode;
        public static string sc3state;

        public static string lc1street;
        public static string lc1city;
        public static string lc1zipcode;
        public static string lc1state;

        public static string lc2street;
        public static string lc2city;
        public static string lc2zipcode;
        public static string lc2state;

        public static string lc3street;
        public static string lc3city;
        public static string lc3zipcode;
        public static string lc3state;

        public static void ReadySetGo(NumBrowsers numbrowsers)
        {
            // IWebDriver driver = new InternetExplorerDriver(); PropertiesCollection.driver = driver;
            // IWebDriver driver = new FirefoxDriver(); PropertiesCollection.driver = driver;

            if (numbrowsers == NumBrowsers.One)
            {
                IWebDriver driver = new ChromeDriver(); PropertiesCollection.driver = driver;
                SeleniumWindowMethods.WindowActions(Driver.driver1, ActType.Maximize);
            }
            else if (numbrowsers == NumBrowsers.Two)
            {
                IWebDriver driver = new ChromeDriver(); PropertiesCollection.driver = driver;
                var options = new InternetExplorerOptions();
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                IWebDriver driver2 = new InternetExplorerDriver(options);
                PropertiesCollection.driver2 = driver2;
            }
            // Start Time Stamp
            StartDT = DateTime.Now;
            ConsoleOut("Test started @ " + Global.StartDT);

        }

        public static void Cooldown()
        {
            Global.EndDT = DateTime.Now;
            var seconds = (Global.EndDT - Global.StartDT).TotalSeconds;
            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;
            ConsoleOut("Test took " + hour + " Hours, " + min + " minutes, " + sec + " seconds to run");
        }

        public static void Done()
        {
            ConsoleOut("Test was completed successfully");
            SeleniumWindowMethods.Sleep(5);

        }

        public static void ConsoleOut(string displaytext)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ");
            Console.WriteLine(" " + displaytext);

        }

        public static void ConsoleOutTab(string displaytext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("     " + displaytext);

        }

        public static void ConsoleOutAlert(string displaytext)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.WriteLine("     " + displaytext);

        }

        public static void ApplicationPause(string displaytext)
        {
            ConsoleOutTab(displaytext + ": " + DateTime.Now.ToString());
            ConsoleOutTab("Press ESC to proceed");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        public static void PassFailCalc()
        {
            double per = passcount / (passcount + failcount);

            ConsoleOutTab("Passed %: " + per.ToString(".00").Replace(".", "") + "%");
        }

    }

}



