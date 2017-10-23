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
    class Runner_UAT
    {

        public static void REOFlowOrg1()
        {
            // REO Flow Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.REO(ENV.UAT, "prodkath2", "qatest10");
            Portal_REO.AddNewProperty("Lawnwood", "Irvine", "California", "92620");
            Portal_REO.AddAgent();
            Portal_REO.PreMarket();
            Logout.Portal(Portals.REO);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.OpenREOTasks("Winterization"); Form_REOTasks.Winterization("iben");
            Portal_Agent.OpenREOTasks("Occupancy Status Task"); Form_REOTasks.OccupancyStatusTask();
            Portal_Agent.OpenREOTasks("Tax Research Task"); Form_REOTasks.TaxResearchTask();
            Portal_Agent.OpenREOTasks("Referral Agreement"); Form_REOTasks.ReferralFeeAgreement("iben");
            Portal_Agent.OpenREOTasks("HOA information task"); Form_REOTasks.HOAInformation();
            Portal_Agent.OpenREOTasks("Listing Addendum"); Form_REOTasks.ListingAddendum("iben");
            Logout.Portal(Portals.Agent);
            Login.REO(ENV.UAT, "prodkath2", "qatest10");
            IfExists.Id_Refresh("globalPropertySearch");
            Form_REOTasks.AssetMGRTasks();
            Logout.Portal(Portals.REO);
            Global.ConsoleOut("Run Amp Order Sync");
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.OpenREOTasks("BPO task"); Form_REOBPO.BPOtask();
            Portal_Agent.OpenREOTasks("BPO Pictures"); Form_REOBPO.BPOPictures();
            Logout.Portal(Portals.Agent);

        }

        public static void RAFlow1Org1()
        {
            // UAT Org 1 RAFlow1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(ENV.UAT, "bryan", "qatest10"); ;
            Portal_Val.CreateNewRentalAnalysis("Anita Rental Survey Co.", "Rental Analysis", "Rental Analysis Exterior", "Trabuco", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment();
            Portal_Agent.OpenRentalAnalysis();
            Form_RentalAnalysis.CompleteRentalAnalysis();
            Form_RentalAnalysis.Attachments(ENV.UAT);
            Logout.Portal(Portals.Agent); 
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteRAOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void RAFlow1Org3()
        {
            // UAT Org 3 RAFlow1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment();
            Portal_Agent.OpenRentalAnalysis();
            Form_RentalAnalysis.CompleteRentalAnalysis();
            Form_RentalAnalysis.Attachments(ENV.UAT);
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteRAOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void PNMACFlow1Org1()
        {
            // PNMAC BPO Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Global.ThrottleSleep = 2 * (1000);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CreateNEWPNMAC("PNMAC", "BPO", "Exterior", "Lamplighter", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment();
            Portal_Agent.OpenBPO();
            Form_PNMACBPO.CompleteBPO();
            Form_PNMACBPO.Attachments(ENV.UAT);
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteBPOOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void FMBFlow1Org1()
        {
            // FMB BPO Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CreateNewFMBBPO("ACME Inc", "BPO", "Exterior", "Rose Arch", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment();
            Portal_Agent.OpenBPO();
            Form_FMBBPO.CompletBPO();
            Form_FMBBPO.Attachments(ENV.UAT);
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteBPOOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.DisputeOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.ReturnToProvider(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.OpenBPO();
            Portal_Agent.SendToClient();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteBPOOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void Unified53Org1()
        {
            // UAT Org 1 RAFlow1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (100);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(ENV.UAT, "bryan", "qatest10"); 
            Portal_Val.CreateNewUnified53("Unified 53", "BPO", "Broker Price Opinion Exterior Inspection", "Townsend", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Portal_Agent.AcceptScheduleAppointment();
            Portal_Agent.OpenBPO();
            Form_Unified53BPO.CompleteBPO();
            Form_Unified53BPO.Attachments(ENV.UAT);
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteBPOOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void AppraisalOrg1()
        {
            // Appraisal Org1
            Global.OrderID = "0";
            Global.StreetAddress = "0";
            Global.ThrottleSleep = 3 * (1000);
            /*                                                  */
            /*              Make changes to above               */
            /*                                                  */

            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CreateNewAppraisal("ACME Inc", "Appraisal", "1004 Interior Residential", "Dublin", "Irvine", "California", "92620");
            Portal_Val.ManualProviderAssign(Global.OrderID, "30005");
            Logout.Portal(Portals.ValPortal);
            Login.Vendor(ENV.UAT, "qaappraisalvendor", "P@ssw0rd1");
            Portal_Vendor.AcceptScheduleAppointment();
            Portal_Vendor.UploadAppraisal();
            Logout.Portal(Portals.Vendor);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            Portal_Val.CompleteAppraisal(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void PCAddDefaultUsers()
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(ENV.UAT, "ditechadmin", "Pwd12345678!");
            Portal_PropertyCure.AddNewUser("Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(3);
            Portal_PropertyCure.AddNewUser("George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(Portals.PropertyCure);
        }

        public static void PCFlow1()
        {
            // Property Cure Regresssion Flow 1
            Login.PropertyCure(ENV.UAT, "ibenPn", "Green!23");
            Portal_PropertyCure.AddNewProperty("Roosevelt", "Irvine", "California", "92620", "CSFB 2");
            Portal_PropertyCure.AddNewViolation(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewUtility(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewOTABid(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewSE(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewInspection(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewHazardClaim(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewPropertyRegistration(Global.PropertyID, "George Washington (DollarBill)");
            Portal_PropertyCure.AddNewNote(Global.PropertyID);
            Portal_PropertyCure.FileUpload(Global.PropertyID, "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            Logout.Portal(Portals.PropertyCure);

        }

    }

}