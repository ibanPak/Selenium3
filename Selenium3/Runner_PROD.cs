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
        public static void AppraisalOrg1(Driver driver)
        {
            // Appraisal Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);

            string subjectstreetnumber = "10950";       // "Generated";
            string subjectstreetname = "MODENA DR";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.STG, "bryan", "Pr0dPa$$121917");
            Portal_Val.CreateNewAppraisal(driver, "ACME II QA Inc", "Appraisal", "Uniform Residential Appraisal (FNMA 1004)", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "30005");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Vendor(driver, ENV.UAT, "qaappraisalvendor", "P@ssw0rd1");
            Portal_Vendor.AcceptScheduleAppointment(driver);
            Portal_Vendor.UploadAppraisal(driver);
            Logout.Portal(driver, Portals.Vendor);
            Login.ValPortal(driver, ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteAppraisal(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void PCAddDefaultUsers(Driver driver)
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(driver, ENV.STG, "ditechadmin", "Pwd12345678!");
            Portal_PropertyCure.AddNewUser(driver, "Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(3);
            Portal_PropertyCure.AddNewUser(driver, "George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(driver, Portals.PropertyCure);

        }

        public static void PCFlow1(Driver driver)
        {
            // Property Cure Regresssion Flow 1
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(driver, ENV.STG, "ibenPn", "Green!23");
            Portal_PropertyCure.AddNewProperty(driver, "Encore", "Irvine", "California", "92620", "CSFB 2");
            Portal_PropertyCure.AddNewViolation(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewUtility(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewOTABid(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewSE(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewInspection(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewHazardClaim(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewPropertyRegistration(driver, Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewNote(driver, Global.PropertyID);
            Portal_PropertyCure.FileUpload(driver, Global.PropertyID, Global.folderpath + "AUpload.pdf");
            Logout.Portal(driver, Portals.PropertyCure);

        }

        public static void Unified53Org1(Driver driver)
        {
            // QA Org 1 Unified53Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            string subjectstreetname = "Bougainvillea Rd";
            string subjectcity = "Naples";
            string subjectstate = "Florida";
            string subjectzip = "34102";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.PROD, "Bryan", "Pr0dPa$$021518");
            Portal_Val.CreateNewUnified53(driver, "5th 3rd Bank", "BPO", "Exterior", subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "318923");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.PROD, "Automated214@email.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_Unified53BPO.CompleteBPO(driver);
            Form_Unified53BPO.Attachments(driver, ENV.PROD);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.PROD, "Bryan", "Pr0dPa$$021518");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void FMBFlow1Org1(Driver driver)
        {
            // FMB BPO Org1
            ENV environment = ENV.PROD;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);

            // Logins
            string valportalusername = "bryan";
            string valportalpassword = "Pr0dPa$$021518";
            string agentportalusername = "bryan";
            string agentportalpassword = "Pr0dPa$$021518";
            string providersourceid = "78832";

            // New Address
            string subjectstreetname = "GreatLawn";
            string subjectcity = "Irvine";
            string subjectstate = "California";
            string subjectzip = "92620";

            // Client, ProductType, Product Details 
            string client = "ACME Inc"; 
            string producttype = "BPO";
            string productdetails = "Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewFMBBPO(driver, client, producttype, productdetails, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_FMBBPO.CompletBPO(driver);
            Form_FMBBPO.Attachments(driver, environment);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.DisputeOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.ReturnToProvider(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.OpenBPO(driver);
            Portal_Agent.SendToClient(driver);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }
       
    }

}