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
        public static string isstreetnumbergenerated = ConfigurationManager.AppSettings.Get("IsStreetNumberGenerated");
        public static string streetnumber = ConfigurationManager.AppSettings.Get("StreetNumber");
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

        // QA Credentials
        public static string qareoportalusername = ConfigurationManager.AppSettings.Get("QAREOPortalUsername");
        public static string qareoportalpassword = ConfigurationManager.AppSettings.Get("QAREOPortalpassword");
        public static string qareoclientid = ConfigurationManager.AppSettings.Get("QAREOClientId");
        public static string qavalportalusername = ConfigurationManager.AppSettings.Get("QAValPortalUsername");
        public static string qavalportalpassword = ConfigurationManager.AppSettings.Get("QAValPortalPassword");
        public static string qaagentportalusername = ConfigurationManager.AppSettings.Get("QAAgentPortalUsername");
        public static string qaagentportalpassword = ConfigurationManager.AppSettings.Get("QAAgentPortalPassword");
        public static string qaagentsourceid = ConfigurationManager.AppSettings.Get("QAAgentSourceId");
        public static string qavendorportalusername = ConfigurationManager.AppSettings.Get("QAVendorPortalUsername");
        public static string qavendorportalpassword = ConfigurationManager.AppSettings.Get("QAVendorPortalPassword");
        public static string qavendorsourceid = ConfigurationManager.AppSettings.Get("QAVendorSourceId");

        // UAT Credentials
        public static string uatreoportalusername = ConfigurationManager.AppSettings.Get("UATREOPortalUsername");
        public static string uatreoportalpassword = ConfigurationManager.AppSettings.Get("UATREOPortalpassword");
        public static string uatreoclientid = ConfigurationManager.AppSettings.Get("UATREOClientId");
        public static string uatvalportalusername = ConfigurationManager.AppSettings.Get("UATValPortalUsername");
        public static string uatvalportalpassword = ConfigurationManager.AppSettings.Get("UATValPortalPassword");
        public static string uatagentportalusername = ConfigurationManager.AppSettings.Get("UATAgentPortalUsername");
        public static string uatagentportalpassword = ConfigurationManager.AppSettings.Get("UATAgentPortalPassword");
        public static string uatagentsourceid = ConfigurationManager.AppSettings.Get("UATAgentSourceId");

        // STG Credentials
        public static string stgreoportalusername = ConfigurationManager.AppSettings.Get("STGREOPortalUsername");
        public static string stgreoportalpassword = ConfigurationManager.AppSettings.Get("STGREOPortalpassword");
        public static string stgreoclientid = ConfigurationManager.AppSettings.Get("STGREOClientId");
        public static string stgvalportalusername = ConfigurationManager.AppSettings.Get("STGValPortalUsername");
        public static string stgvalportalpassword = ConfigurationManager.AppSettings.Get("STGValPortalPassword");
        public static string stgagentportalusername = ConfigurationManager.AppSettings.Get("STGAgentPortalUsername");
        public static string stgagentportalpassword = ConfigurationManager.AppSettings.Get("STGAgentPortalPassword");
        public static string stgagentsourceid = ConfigurationManager.AppSettings.Get("STGAgentSourceId");
        public static string stgvendorportalusername = ConfigurationManager.AppSettings.Get("STGVendorPortalUsername");
        public static string stgvendorportalpassword = ConfigurationManager.AppSettings.Get("STGVendorPortalPassword");
        public static string stgvendorsourceid = ConfigurationManager.AppSettings.Get("STGVendorSourceId");
        public static string stgshortsaleportalusername = ConfigurationManager.AppSettings.Get("STGShortSaleUsername");
        public static string stgshortsaleportalpassword = ConfigurationManager.AppSettings.Get("STGShortSalePassword");

        // PROD Credentials
        public static string prodreoportalusername = ConfigurationManager.AppSettings.Get("PRODREOPortalUsername");
        public static string prodreoportalpassword = ConfigurationManager.AppSettings.Get("PRODREOPortalpassword");
        public static string prodreoclientid = ConfigurationManager.AppSettings.Get("PRODREOClientId");
        public static string prodvalportalusername = ConfigurationManager.AppSettings.Get("PRODValPortalUsername");
        public static string prodvalportalpassword = ConfigurationManager.AppSettings.Get("PRODValPortalPassword");
        public static string prodagentportalusername = ConfigurationManager.AppSettings.Get("PRODAgentPortalUsername");
        public static string prodagentportalpassword = ConfigurationManager.AppSettings.Get("PRODAgentPortalPassword");
        public static string prodagentsourceid = ConfigurationManager.AppSettings.Get("PRODAgentSourceId");
        public static string prodvendorportalusername = ConfigurationManager.AppSettings.Get("PRODVendorPortalUsername");
        public static string prodvendorportalpassword = ConfigurationManager.AppSettings.Get("PRODVendorPortalPassword");
        public static string prodvendorsourceid = ConfigurationManager.AppSettings.Get("PRODVendorSourceId");
        public static string prodshortsaleportalusername = ConfigurationManager.AppSettings.Get("PRODShortSaleUsername");
        public static string prodshortsaleportalpassword = ConfigurationManager.AppSettings.Get("PRODShortSalePassword");

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



