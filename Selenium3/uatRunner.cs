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
    class uatRunner
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
            REO.AddNewProperty("Lawnwood", "Irvine", "California", "92620");
            REO.AddAgent();
            REO.PreMarket();
            Logout.Portal(Portals.REO);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.OpenREOTasks("Winterization"); REOTasks.Winterization("iben");
            Agent.OpenREOTasks("Occupancy Status Task"); REOTasks.OccupancyStatusTask();
            Agent.OpenREOTasks("Tax Research Task"); REOTasks.TaxResearchTask();
            Agent.OpenREOTasks("Referral Agreement"); REOTasks.ReferralFeeAgreement("iben");
            Agent.OpenREOTasks("HOA information task"); REOTasks.HOAInformation();
            Agent.OpenREOTasks("Listing Addendum"); REOTasks.ListingAddendum("iben");
            Logout.Portal(Portals.Agent);
            Login.REO(ENV.UAT, "prodkath2", "qatest10");
            IfExists.Id_Refresh("globalPropertySearch");
            REOTasks.AssetMGRTasks();
            Logout.Portal(Portals.REO);
            Global.ConsoleOut("Run Amp Order Sync");
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.OpenREOTasks("BPO task"); REOBPO.BPOtask();
            Agent.OpenREOTasks("BPO Pictures"); REOBPO.BPOPictures();
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
            ValPortal.CreateNewRentalAnalysis("Anita Rental Survey Co.", "Rental Analysis", "Rental Analysis Exterior", "Trabuco", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.uatAttachments();
            Logout.Portal(Portals.Agent); 
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteRAOrder(Global.OrderID);
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
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.uatAttachments();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteRAOrder(Global.OrderID);
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
            ValPortal.CreateNEWPNMAC("PNMAC", "BPO", "Exterior", "Lamplighter", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            PNMACBPO.CompleteBPO();
            PNMACBPO.uatPNMACAttachments();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteBPOOrder(Global.OrderID);
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
            ValPortal.CreateNewFMBBPO("ACME Inc", "BPO", "Exterior", "Rose Arch", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            FMBBPO.uatFMBAttachments();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteBPOOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.DisputeOrder(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.ReturnToProvider(Global.OrderID);
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.OpenBPO();
            Agent.SendToClient();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteBPOOrder(Global.OrderID);
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
            ValPortal.CreateNewUnified53("Unified 53", "BPO", "Broker Price Opinion Exterior Inspection", "Ridge Valley", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "250418");
            Logout.Portal(Portals.ValPortal);
            Login.Agent(ENV.UAT, "QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            Unified53BPO.U53Order();
            Unified53BPO.uatAttachments();
            Logout.Portal(Portals.Agent);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteBPOOrder(Global.OrderID);
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
            ValPortal.CreateNewAppraisal("ACME Inc", "Appraisal", "1004 Interior Residential", "Dublin", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign(Global.OrderID, "30005");
            Logout.Portal(Portals.ValPortal);
            Login.Vendor(ENV.UAT, "qaappraisalvendor", "P@ssw0rd1");
            Vendor.AcceptScheduleAppointment();
            Vendor.UploadAppraisal();
            Logout.Portal(Portals.Vendor);
            Login.ValPortal(ENV.UAT, "bryan", "qatest10");
            ValPortal.CompleteAppraisal(Global.OrderID);
            Logout.Portal(Portals.ValPortal);

        }

        public static void PCAddDefaultUsers()
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(ENV.UAT, "ditechadmin", "Pwd12345678!");
            PropertyCure.AddNewUser("Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(3);
            PropertyCure.AddNewUser("George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(Portals.PropertyCure);
        }

        public static void PCFlow1()
        {
            // Property Cure Regresssion Flow 1
            Login.PropertyCure(ENV.UAT, "ibenPn", "Green!23");
            PropertyCure.AddNewProperty("Roosevelt", "Irvine", "California", "92620", "CSFB 2");
            PropertyCure.AddNewViolation(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewUtility(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewOTABid(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewSE(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewInspection(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewHazardClaim(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewPropertyRegistration(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewNote(Global.PropertyID);
            PropertyCure.FileUpload(Global.PropertyID, "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            Logout.Portal(Portals.PropertyCure);

        }

    }

}