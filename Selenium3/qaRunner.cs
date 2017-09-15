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
    class qaRunner
    {

        public static void qaREOFlowOrg1()
        {
            // REO Flow Org1
            Login.REO(ENV.QA, "Yeshh1", "Yeshh1");
            IfExists.Id_Refresh("globalPropertySearch");
            REO.AddNewProperty("Irvine");
            REO.AddAgent();
            REO.PreMarket();
            Logout.REO();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.OpenREOTasks("Winterization"); REOTasks.Winterization("iben");
            Agent.OpenREOTasks("Occupancy Status Task"); REOTasks.OccupancyStatusTask();
            Agent.OpenREOTasks("Tax Research Task"); REOTasks.TaxResearchTask();
            Agent.OpenREOTasks("Referral Agreement"); REOTasks.ReferralFeeAgreement("iben");
            Agent.OpenREOTasks("HOA information task"); REOTasks.HOAInformation();
            Agent.OpenREOTasks("Listing Addendum"); REOTasks.ListingAddendum("iben");
            Logout.Agent();
            Login.REO(ENV.QA, "Yeshh1", "Yeshh1");
            IfExists.Id_Refresh("globalPropertySearch");
            REOTasks.AssetMGRTasks();
            Logout.REO();
            Global.ConsoleOut("Run Amp Order Sync");
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.OpenREOTasks("BPO task"); REOBPO.BPOtask();
            Agent.OpenREOTasks("BPO Pictures"); REOBPO.BPOPictures();
            Logout.Agent();

        }

        public static void RAFlow1Org1()
        {
            // Rental Analysis Org1
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CreateNewRentalAnalysis("Beatrice Rental Survey Co", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.qaAttachments();
            Logout.Agent();
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void RAFlow1Org3()
        {
            // Rental Analysis Org3
            Login.ValPortal(ENV.QA,"test3", "P@ssw0rd4");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.qaAttachments();
            Logout.Agent();
            Login.ValPortal(ENV.QA,"test3", "P@ssw0rd4");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void Unified53Org1()
        {
            // QA Org 1 Unified53Org1
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CreateNewUnified53("Unified 53", "BPO", "Broker Price Opinion Exterior Inspection", "Meadowood", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            Unified53BPO.U53Order();
            Unified53BPO.uatAttachments();
            Logout.Agent();
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void PNMACFlow1Org1()
        {
            //PNMAC BPO Org1
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CreateNEWPNMAC("PNMAC", "BPO", "Exterior", "Meadowood", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            PNMACBPO.CompleteBPO();
            Logout.Agent();
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void FMBFlow1Org1()
        {
            // FMB BPO Org1
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CreateNewFMBBPO("acme", "BPO", "Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            FMBBPO.qaFMBAttachments();
            Logout.Agent();
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }
        public static void AppraisalOrg1()
        {
            // Appraisal Org1
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CreateNewAppraisal("acme", "Appraisal", "2055 Exterior Residential", "Encore", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("30005");
            Logout.ValPortal();
            Login.Vendor(ENV.QA, "qaappraisalvendor", "P@ssw0rd1");
            Vendor.AcceptScheduleAppointment();
            Vendor.UploadAppraisal();
            Logout.Vendor();
            Login.ValPortal(ENV.QA, "test", "P@ssw0rd1");
            ValPortal.CompleteAppraisal();
            Logout.ValPortal();

        }

        public static void PCAddDefaultUsers()
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(ENV.QA, "ditechadmin", "Pwd12345678!");
            SeleniumWindowMethods.Sleep(2);
            PropertyCure.AddNewUser("Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(2);
            PropertyCure.AddNewUser("George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.PropertyCure();
        }

        public static void PCFlow1()
        {
            // Property Cure Regresssion Flow 1
            Login.PropertyCure(ENV.QA, "ibenPn", "Green!23");
            PropertyCure.AddNewProperty("Encore", "Irvine", "California", "92620", "CSFB 2");
            PropertyCure.AddNewViolation(Global.PropteryID, "George Washington (DollarBill)");
            PropertyCure.AddNewUtility(Global.PropteryID, "George Washington (DollarBill)");
            PropertyCure.AddNewOTABid(Global.PropteryID, "George Washington (DollarBill)");
            PropertyCure.AddNewSE(Global.PropteryID, "George Washington (DollarBill)");
            PropertyCure.AddNewInspection(Global.PropteryID, "George Washington (DollarBill)");
            PropertyCure.AddNewHazardClaim(Global.PropteryID, "George Washington (DollarBill)"); 
            PropertyCure.AddNewPropertyRegistration(Global.PropteryID, "George Washington (DollarBill)"); 
            PropertyCure.AddNewNote(Global.PropteryID);
            PropertyCure.FileUpload(Global.PropteryID, "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            Logout.PropertyCure();

        }

    }

}