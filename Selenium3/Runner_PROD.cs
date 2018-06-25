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
    class Runner_PROD
    {
        public static void FMBFlow1Org1(Driver driver, City city)
        {
            // FMB BPO Org1
            ENV environment = ENV.PROD;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);
            // Global.subjectstreetnumber = "10001";

            // Logins
            string valportalusername = Global.prodvalportalusername;
            string valportalpassword = Global.prodvalportalpassword;
            string agentportalusername = Global.prodagentportalusername;
            string agentportalpassword = Global.prodagentportalpassword;
            string providersourceid = Global.prodagentsourceid;
            string clientid = Global.prodreoclientid;

            // Client, ProductType, Product Details 
            string client = "ACME Inc";
            string producttype = "BPO";
            string productdetails = "Exterior";

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewFMBBPO(driver, client, producttype, productdetails, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_FMBBPO.CompletBPO(driver);
            Form_FMBBPO.Attachments(driver, environment);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.GotoOrder(driver, Global.OrderID);
    
        }
        public static void Unified53Org1(Driver driver, City city)
        {
            // QA Org 1 Unified53Org1
            ENV environment = ENV.PROD;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            TestAddress.Address(city);

            // Logins
            string valportalusername = Global.prodvalportalusername;
            string valportalpassword = Global.prodvalportalpassword;
            string agentportalusername = Global.prodagentportalusername;
            string agentportalpassword = Global.prodagentportalpassword;
            string providersourceid = Global.prodagentsourceid;
            string clientid = Global.prodreoclientid;

            // Client, ProductType, Product Details 
            string client = "5th 3rd Bank";
            string producttype = "BPO";
            string productdetails = "Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewUnified53(driver, client, producttype, productdetails, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_Unified53BPO.CompleteBPO(driver);
            Form_Unified53BPO.Attachments(driver, environment);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.GotoOrder(driver, Global.OrderID);

        }

        public static void ShortSale(Driver driver, City city)
        {
            // FMB BPO Org1
            ENV environment = ENV.PROD;
            Global.OrderID = "0";
            Global.StreetAddress = "";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string shortsaleportalusername = Global.prodshortsaleportalusername;
            string shortsaleportalpassword = Global.prodshortsaleportalpassword;
            string agentportalusername = Global.prodagentportalusername;
            string agentportalpassword = Global.prodagentportalpassword;
            string providersourceid = Global.prodagentsourceid;
            string clientid = Global.prodreoclientid;

            Login.LossMit(driver, environment, shortsaleportalusername, shortsaleportalpassword);
            Portal_LossMit.AddNewPropety(driver);
            //Portal_LossMit.GotoProperty(driver, "SS56108");
            SeleniumWindowMethods.Sleep(3);
            Global.PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, ".contents > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
            Global.ConsoleOutTab("Property ID: " + Global.PropertyID);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "div.contents:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(2) > td:nth-child(2)", "Loan #");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "div.contents:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(3) > td:nth-child(2)", "Borrower");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#spClientName", "Client");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.Id, "spClientId", "Client ID");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "div.contents:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(6) > td:nth-child(2)", "Property Type");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "a.pointer:nth-child(1)", "Current Status");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#roleManager > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(2) > td:nth-child(2) > span:nth-child(1)", "Coordinator");



        }
    }
}