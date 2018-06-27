using System.Configuration;
using System.Collections.Specialized;
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
using OpenQA.Selenium;

namespace Selenium3
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Global.ReadySetGo();

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            Driver driver = Driver.driver1;

            // Rental Analysis Org1
            ENV environment = ENV.QA;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            // Logins
            string valportalusername = Global.qavalportalusername;
            string valportalpassword = Global.qavalportalpassword;
            string agentportalusername = Global.qaagentportalusername;
            string agentportalpassword = Global.qaagentportalpassword;
            string providersourceid = Global.qaagentsourceid;


            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "searchBar");
            SeleniumGetMethods.DisplayTextValue(driver, ElementType.Id, "Filters_AssignerId", "display saying fitler id");
            SeleniumWindowMethods.Sleep(2);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#OrdersGrid > table > tbody > tr:nth-child(1) > td:nth-child(10)", "something to display");

            SeleniumGetMethods.DisplayIsPresent(driver, ElementType.Id, "searchdBar", "<-- is search bar present?");
            Global.ApplicationPause("testing");

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }
    }
}