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

        public static void REOFlowOrg1(Driver driver, City city)
        {
            // REO Flow Org1
            ENV environment = ENV.STG;
            Global.PropertyID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            TestAddress.Address(city);

            // Logins
            string reoportalusername = "Yeshh1";
            string reoportalpassword = "Yeshh1";
            string agentportalusername = "QATest23@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250922";
            string clientid = "7225";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.REO(driver, environment, reoportalusername, reoportalpassword);
            Portal_REO.AddNewProperty(driver, clientid, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_REO.AddAgent(driver, Global.PropertyID, providersourceid);
            Portal_REO.PreMarket(driver);
            Logout.Portal(driver, Portals.REO);
            Login.Agent(driver, environment, "QATest23@usres.com", "blue123");
            Portal_Agent.OpenREOTasks(driver, "Winterization"); Form_REOTasks.Winterization(driver, "iben");
            Portal_Agent.OpenREOTasks(driver, "Occupancy Status Task"); Form_REOTasks.OccupancyStatusTask(driver);
            Portal_Agent.OpenREOTasks(driver, "Tax Research Task"); Form_REOTasks.TaxResearchTask(driver);
            Portal_Agent.OpenREOTasks(driver, "Referral Agreement"); Form_REOTasks.ReferralFeeAgreement(driver, "iben");
            Portal_Agent.OpenREOTasks(driver, "HOA information task"); Form_REOTasks.HOAInformation(driver);
            Portal_Agent.OpenREOTasks(driver, "Listing Addendum"); Form_REOTasks.ListingAddendum(driver, "iben");
            Logout.Portal(driver, Portals.Agent);
            Login.REO(driver, environment, reoportalusername, reoportalpassword);
            IfExists.Id_Refresh(driver, "globalPropertySearch", "TEXT!!!");
            Form_REOTasks.AssetMGRTasks(driver);
            Logout.Portal(driver, Portals.REO);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.OpenREOTasks(driver, "BPO task"); Form_REOBPO.BPOtask(driver);
            Portal_Agent.OpenREOTasks(driver, "BPO Pictures"); Form_REOBPO.BPOPictures(driver, 36);
            Logout.Portal(driver, Portals.Agent);

        }

        public static void REOFlowOrg2(Driver driver)
        {
            // REO Flow Org1
            Global.PropertyID = "858340";
            Global.StreetAddress = "500 Townsend";
            Global.ThrottleSleep = 3 * (100);

            string clientid = "7225";
            string subjectstreetnumber = "500";        // "Random";
            string subjectstreetname = "Townsend";
            string subjectcity = "Irvine";
            string subjectstate = "California";
            string subjectzip = "92620";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            // Log into the REO portal, add property and assign agent.
            Login.REO(driver, ENV.STG, "sdqaam15", "P@ssw0rd2");
            Portal_REO.AddNewProperty(driver, clientid, subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_REO.AddAgent(driver, Global.PropertyID, "250922");
            Logout.Portal(driver, Portals.REO);
            SeleniumWindowMethods.Sleep(2);

            // Log into the agent portal and complete the Occupancy task. 

            Login.Agent(driver, ENV.STG, "QATest23@usres.com", "blue123");
            Portal_Agent.Agentsearch(driver, Global.PropertyID);
            Portal_Agent.OccupancyStatusTask(driver);
            SeleniumWindowMethods.Sleep(1);
            Logout.Portal(driver, Portals.Agent);

            // Log back to REO portal.complete occupancy task.
            // List the Property
            SeleniumWindowMethods.Sleep(2);
            Login.REO(driver, ENV.STG, "sdqaam15", "P@ssw0rd2");  // QA login 
            Portal_REO.PropertySerach(driver, Global.PropertyID);
            Portal_REO.AMOccupancyStatusTask(driver);
            Portal_REO.AMListing2(driver);
            Logout.Portal(driver, Portals.REO);

            // Listing Agent places the order 
            Login.Agent(driver, ENV.STG, "QATest23@usres.com", "blue123");     // QA Login 
            Portal_Agent.Agentsearch(driver, Global.PropertyID);
            Portal_Agent.ListAgentOffer(driver);
            Logout.Portal(driver, Portals.Agent);

            // Asset manager accepts the offer placed by Listing Agent          
            SeleniumWindowMethods.Sleep(3);
            Login.REO(driver, ENV.STG, "sdqaam15", "P@ssw0rd2");   // QA login
            Portal_REO.PropertySerach(driver, Global.PropertyID);
            Portal_REO.AMAcceptOffer2(driver, 1);
            SeleniumWindowMethods.Sleep(1);
            Logout.Portal(driver, Portals.REO);

            // Listing Agent uploads the signed contact 
            Login.Agent(driver, ENV.STG, "QATest23@usres.com", "blue123");
            Portal_Agent.Agentsearch(driver, Global.PropertyID);
            Portal_Agent.UploadSignedContract(driver, Global.PropertyID);
            Logout.Portal(driver, Portals.Agent);

            // Adding REO BPO Pictures
            Login.REO(driver, ENV.STG, "sdqaam15", "P@ssw0rd2");   // QA login
            Portal_REO.OpenTaskReo(Driver.driver1, Global.PropertyID, "BPO Pictures"); Form_REOBPO.BPOPictures(Driver.driver1, 24);
            Logout.Portal(driver, Portals.REO);

        }

        public static void RAFlow1Org1(Driver driver, City city)
        {
            // Rental Analysis Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "Bryan";
            string valportalpassword = "P@ssw0rd1";
            string agentportalusername = "QATest25@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "318923";

            // Client, ProductType, Product Details 
            string client = "Beatrice Rental Survey Co";
            string producttype = "Rental Analysis";
            string productdetails = "Rental Analysis Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewRentalAnalysis(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenRentalAnalysis(driver);
            Form_RentalAnalysis.CompleteRA(driver);
            Form_RentalAnalysis.Attachments(driver, ENV.STG);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteRAOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void RAFlow1Org3(Driver driver, City city)
        {
            // Rental Analysis Org3
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "test3";
            string valportalpassword = "P@ssw0rd1";
            string agentportalusername = "QATest25@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250418";

            // Client, ProductType, Product Details 
            string client = "Bonnie Org 3";
            string producttype = "Rental Analysis";
            string productdetails = "Rental Analysis Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewRentalAnalysis(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenRentalAnalysis(driver);
            Form_RentalAnalysis.CompleteRA(driver);
            Form_RentalAnalysis.Attachments(driver, ENV.STG);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteRAOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void Unified53Org1(Driver driver, City city)
        {
            // QA Org 1 Unified53Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "test";
            string valportalpassword = "P@ssw0rd1";
            string agentportalusername = "QATest23@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250922";

            // Client, ProductType, Product Details 
            string client = "Unified 53";
            string producttype = "BPO";
            string productdetails = "Broker Price Opinion Exterior Inspection";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewUnified53(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_Unified53BPO.CompleteBPO(driver);
            Form_Unified53BPO.Attachments(driver, environment);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void PNMACFlow1Org1(Driver driver, City city)
        {
            // PNMAC BPO Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "bryan";
            string valportalpassword = "qatest10";
            string agentportalusername = "QATest25@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250418";

            // Client, ProductType, Product Details 
            string client = "PNMAC";
            string producttype = "BPO";
            string productdetails = "Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNEWPNMAC(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_PNMACBPO.CompleteBPO(driver);
            Form_PNMACBPO.Attachments(driver, environment);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void FMBFlow1Org1(Driver driver, City city)
        {
            // FMB BPO Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "bryan";
            string valportalpassword = "qatest10";
            string agentportalusername = "QATest25@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250418";

            // Client, ProductType, Product Details 
            string client = "ACME Inc";
            string producttype = "BPO";
            string productdetails = "Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewFMBBPO(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
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

        public static void FMBFlow1Org3(Driver driver, City city)
        {
            // FMB BPO Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "test3";
            string valportalpassword = "P@ssw0rd1";
            string agentportalusername = "QATest25@usres.com";
            string agentportalpassword = "blue123";
            string providersourceid = "250418";

            // Client, ProductType, Product Details 
            string client = "ACME Inc";
            string producttype = "BPO";
            string productdetails = "Exterior";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewFMBBPO(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
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

        public static void AppraisalOrg1(Driver driver, City city)
        {
            // Appraisal Org1
            ENV environment = ENV.STG;
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string valportalusername = "bryan";
            string valportalpassword = "qatest10";
            string vendorportalusername = "qaappraisalvendor";
            string vendorportalpassword = "P@ssw0rd1";
            string providersourceid = "30005";

            // Client, ProductType, Product Details 
            string client = "acme";
            string producttype = "Appraisal";
            string productdetails = "1004 Interior Residential";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CreateNewAppraisal(driver, client, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, providersourceid);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Vendor(driver, environment, vendorportalusername, vendorportalpassword);
            Portal_Vendor.AcceptScheduleAppointment(driver);
            Portal_Vendor.UploadAppraisal(driver);
            Logout.Portal(driver, Portals.Vendor);
            Login.ValPortal(driver, environment, valportalusername, valportalpassword);
            Portal_Val.CompleteAppraisal(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void ValClient(Driver driver, City city)
        {
            // Appraisal Org1
            // ValClient
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            TestAddress.Address(city);

            // Logins
            string valclientusername = "testclient";
            string valclientpassword = "P@ssw0rd1";

            // ProductType, Product Details 
            ProductTypes producttype = ProductTypes.Appraisal;
            string productdetails = "2055 Exterior Residential";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValClient(driver, ENV.QA, valclientusername, valclientpassword);
            Portal_ValClient.CreateNewOrder(driver, producttype, productdetails, Global.subjectstreetnumber, Global.subjectstreetname, Global.subjectcity, Global.subjectstate, Global.subjectzipcode, CreditCardType.MasterCard1);

        }

        public static void PCAddDefaultUsers(Driver driver)
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(driver, ENV.STG, "ditechadmin", "Pwd12345678!");
            SeleniumWindowMethods.Sleep(2);
            Portal_PropertyCure.AddNewUser(driver, "Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(2);
            Portal_PropertyCure.AddNewUser(driver, "George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(driver, Portals.PropertyCure);
        }

        public static void PCFlow1(Driver driver)
        {
            // Property Cure Regresssion Flow 1
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

        public static void ProAgentSearchAllListing(Driver driver)
        {
            Login.Agent(driver, ENV.STG, "qa12270935@usres.com", "testing");
            Portal_Agent.ProAgent(driver);

        }

        public static void HomeownerDILFlow(Driver driver)
        {
            Login.Homeowner(driver, ENV.STG, "AutoHome", "testing");
            Portal_Homeowner.CreateDILProperty(driver);
            Login.LossMit(Driver.driver1, ENV.STG, "qaservicer", "P@ssw0rd1");
            Portal_LossMit.HODILShortSalePartI(Driver.driver1);
            Portal_Homeowner.HODILHomeownerPartII(driver);
            Portal_LossMit.HODILShortSalePartII(Driver.driver1);
            Login.Vendor(driver, ENV.STG, "qatitlevendor", "P@ssw0rd1");
            Portal_Vendor.HODILVendorPartI(driver);

        }

        public static void CreditCard(Driver driver)
        {
            ENV environment = ENV.STG;

            // Logins
            string buyerportalusername = "ibanPn";
            string buyerportalpassword = "yellow123";
            string agentportalusername = "qaevictionvendor";
            string agentportalpassword = "P@ssw0rd1";
            string vendorportalusername = "qaevictionvendor";
            string vendorportalpassword = "P@ssw0rd1";

            Login.Buyer(driver, environment, buyerportalusername, buyerportalpassword);
            TestCreditCard.BuyerProfile(driver, CreditCardType.Visa);
            TestCreditCard.BuyerProfile(driver, CreditCardType.Amex);
            TestCreditCard.BuyerProfile(driver, CreditCardType.MasterCard1);
            TestCreditCard.BuyerProfile(driver, CreditCardType.MasterCard2);
            TestCreditCard.BuyerProfile(driver, CreditCardType.Discover);
            Logout.Portal(driver, Portals.Buyer);
            Login.Agent(driver, environment, agentportalusername, agentportalpassword);
            TestCreditCard.AgentProfile(driver, CreditCardType.Visa);
            TestCreditCard.AgentProfile(driver, CreditCardType.Amex);
            TestCreditCard.AgentProfile(driver, CreditCardType.MasterCard1);
            TestCreditCard.AgentProfile(driver, CreditCardType.MasterCard2);
            TestCreditCard.AgentProfile(driver, CreditCardType.Discover);
            Logout.Portal(driver, Portals.Agent);
            Login.Vendor(driver, environment, vendorportalusername, vendorportalpassword);
            TestCreditCard.VendorProfile(driver, CreditCardType.Visa);
            TestCreditCard.VendorProfile(driver, CreditCardType.Amex);
            TestCreditCard.VendorProfile(driver, CreditCardType.MasterCard1);
            TestCreditCard.VendorProfile(driver, CreditCardType.MasterCard2);
            TestCreditCard.VendorProfile(driver, CreditCardType.Discover);
            Logout.Portal(driver, Portals.Vendor);

        }

        public static void NewUser(Driver driver)
        {
            AddNewUser.ProPlusAgent(driver, ENV.STG, CreditCardType.MasterCard1);

        }

    }

}