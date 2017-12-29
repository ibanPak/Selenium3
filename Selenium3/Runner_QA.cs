﻿using OpenQA.Selenium;
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
    class Runner_QA
    {
        public static void REOFlowOrg1(Driver driver)
        {
            // REO Flow Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.REO(driver, ENV.QA, "Yeshh1", "Yeshh1");
            Portal_REO.AddNewProperty(driver, "Lawnwood", "Irvine", "California", "92620");
            Portal_REO.AddAgent(driver);
            Portal_REO.PreMarket(driver);
            Logout.Portal(driver, Portals.REO);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.OpenREOTasks(driver, "Winterization"); Form_REOTasks.Winterization(driver, "iben");
            Portal_Agent.OpenREOTasks(driver, "Occupancy Status Task"); Form_REOTasks.OccupancyStatusTask(driver);
            Portal_Agent.OpenREOTasks(driver, "Tax Research Task"); Form_REOTasks.TaxResearchTask(driver);
            Portal_Agent.OpenREOTasks(driver, "Referral Agreement"); Form_REOTasks.ReferralFeeAgreement(driver, "iben");
            Portal_Agent.OpenREOTasks(driver, "HOA information task"); Form_REOTasks.HOAInformation(driver);
            Portal_Agent.OpenREOTasks(driver, "Listing Addendum"); Form_REOTasks.ListingAddendum(driver, "iben");
            Logout.Portal(driver, Portals.Agent);
            Login.REO(driver, ENV.QA, "Yeshh1", "Yeshh1");
            IfExists.Id_Refresh(driver, "globalPropertySearch");
            Form_REOTasks.AssetMGRTasks(driver);
            Logout.Portal(driver, Portals.REO);
            Global.ConsoleOut("Run Amp Order Sync");
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.OpenREOTasks(driver, "BPO task"); Form_REOBPO.BPOtask(driver);
            Portal_Agent.OpenREOTasks(driver, "BPO Pictures"); Form_REOBPO.BPOPictures(driver);
            Logout.Portal(driver, Portals.Agent);

        }

        public static void RAFlow1Org1(Driver driver)
        {
            // Rental Analysis Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            string subjectstreetnumber = "10950";
            string subjectstreetname = "MODENA DR";     // "Random";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Global.ThrottleSleep = 3 * (100);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CreateNewRentalAnalysis(driver, "Beatrice Rental Survey Co", "Rental Analysis", "Rental Analysis Exterior", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenRentalAnalysis(driver);
            Form_RentalAnalysis.CompleteRA(driver);
            Form_RentalAnalysis.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteRAOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void RAFlow1Org3(Driver driver)
        {
            // Rental Analysis Org3
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            string subjectstreetnumber = "10950";
            string subjectstreetname = "MODENA DR";     // "Random";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.QA, "test3", "P@ssw0rd1");
            Portal_Val.CreateNewRentalAnalysis(driver, "Bonnie Org 3", "Rental Analysis", "Rental Analysis Exterior", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenRentalAnalysis(driver);
            Form_RentalAnalysis.CompleteRA(driver);
            Form_RentalAnalysis.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test3", "P@ssw0rd1");
            Portal_Val.CompleteRAOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void Unified53Org1(Driver driver)
        {
            // QA Org 1 Unified53Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);

            string subjectstreetnumber = "6800";       //  "Random";
            string subjectstreetname = "Daniels Rd";
            string subjectcity = "NAPLES";
            Global.State = "Florida";
            string subjectzip = "34109";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CreateNewUnified53(driver, "Unified 53", "BPO", "Broker Price Opinion Exterior Inspection", subjectstreetnumber, subjectstreetname, subjectcity, Global.State, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_Unified53BPO.CompleteBPO(driver);
            Form_Unified53BPO.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void PNMACFlow1Org1(Driver driver)
        {
            // PNMAC BPO Org1
            Global.OrderID = "30853";
            Global.StreetAddress = "1211 Rush Lily";     // "Random";
            Global.ThrottleSleep = 3 * (1000);

            string subjectstreetnumber = "10950";
            string subjectstreetname = "MODENA DR";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CreateNEWPNMAC(driver, "PNMAC", "BPO", "Exterior", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_PNMACBPO.CompleteBPO(driver);
            Form_PNMACBPO.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void FMBFlow1Org1(Driver driver)
        {
            // FMB BPO Org1
            Global.OrderID = "30913";
            Global.StreetAddress = "1228 MODENA DR";
            Global.ThrottleSleep = 3 * (1000);

            string subjectstreetnumber = "Random";      //  "Random"; 
            string subjectstreetname = "MODENA DR";
            string subjectcity = "PHILADELPHIA";
            string subjectstate = "Pennsylvania";
            string subjectzip = "19154";

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CreateNewFMBBPO(driver, "acme", "BPO", "Exterior", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "250922");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_FMBBPO.CompletBPO(driver);
            Form_FMBBPO.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.DisputeOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.ReturnToProvider(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            Portal_Agent.OpenBPO(driver);
            Portal_Agent.SendToClient(driver);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

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

            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CreateNewAppraisal(driver, "acme", "Appraisal", "2055 Exterior Residential", subjectstreetnumber, subjectstreetname, subjectcity, subjectstate, subjectzip);
            Portal_Val.ManualProviderAssign(driver, Global.OrderID, "30005");
            Logout.Portal(driver, Portals.ValPortal);
            Login.Vendor(driver, ENV.QA, "qaappraisalvendor", "P@ssw0rd1");
            Portal_Vendor.AcceptScheduleAppointment(driver);
            Portal_Vendor.UploadAppraisal(driver);
            Logout.Portal(driver, Portals.Vendor);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteAppraisal(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);

        }

        public static void ValClient(Driver driver)
        {
            // Appraisal Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);

            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValClient(Driver.driver1, ENV.QA, "testclient", "P@ssw0rd1");
            Portal_ValClient.CreateNewOrder(Driver.driver1, ProductTypes.BPO, Products.Interior, "Rose Arch", "Irvine", "California", "92614");

        }

        public static void PCAddDefaultUsers(Driver driver)
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(driver, ENV.QA, "ditechadmin", "Pwd12345678!");
            SeleniumWindowMethods.Sleep(2);
            Portal_PropertyCure.AddNewUser(driver, "Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(2);
            Portal_PropertyCure.AddNewUser(driver, "George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(driver, Portals.PropertyCure);
        }

        public static void PCFlow1(Driver driver)
        {
            // Global.PropertyID = "30584";
            // Property Cure Regresssion Flow 1
            Login.PropertyCure(driver, ENV.QA, "ibenPn", "Green!23");
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
            Login.Agent(driver, ENV.QA, "qa12270935@usres.com", "testing");
            Portal_Agent.ProAgent(driver);

        }

    }

}