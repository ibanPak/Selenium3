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
    class Runner_STG
    {
        public static void AppraisalOrg1(Driver driver)
        {
            // Appraisal Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);

            string subjectstreetnumber = "10950";
            string subjectstreetname = "MODENA DR";     // "Random";
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
            Portal_PropertyCure.FileUpload(driver, Global.PropertyID, "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            Logout.Portal(driver, Portals.PropertyCure);

        }

        public static void Unified53Org1(Driver driver)
        {
            // QA Org 1 Unified53Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            string subjectstreetnumber = "Random";      //  "Random"; 
            string subjectstreetname = "MODENA DR";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.STG, "test", "P@ssw0rd1");
            Portal_Val.CreateNewUnified53(driver, "ACME II QA Inc", "BPO", "Broker Price Opinion Exterior Inspection", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.STG, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_Unified53BPO.CompleteBPO(driver);
            Form_Unified53BPO.Attachments(driver, ENV.STG);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.STG, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

    }

}