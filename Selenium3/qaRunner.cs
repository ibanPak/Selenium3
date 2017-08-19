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
            Login.qaREO("Yeshh1", "Yeshh1");
            IfExists.Id_Refresh("globalPropertySearch");
            REO.AddNewProperty("Rincon");
            REO.AddAgent();
            Logout.REO();
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.OpenREOTasks("Winterization"); REOTasks.Winterization("iben");
            Agent.OpenREOTasks("Occupancy Status Task"); REOTasks.OccupancyStatusTask();
            Agent.OpenREOTasks("Tax Research Task"); REOTasks.TaxResearchTask();
            Agent.OpenREOTasks("Referral Agreement"); REOTasks.ReferralFeeAgreement("iben");
            Agent.OpenREOTasks("HOA information task"); REOTasks.HOAInformation();
            Agent.OpenREOTasks("Listing Addendum"); REOTasks.ListingAddendum("iben");
            Logout.Agent();
            Login.qaREO("Yeshh1", "Yeshh1");
            IfExists.Id_Refresh("globalPropertySearch");
            REOTasks.AssetMGRTasks();
            Logout.REO();
            Global.ConsoleOut("Run Amp Order Sync");
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.OpenREOTasks("BPO task"); REOBPO.BPOtask();
            Agent.OpenREOTasks("BPO Pictures"); REOBPO.BPOPictures();
            Logout.Agent();

        }

        public static void RAFlow1Org1()
        {
            // Rental Analysis Org1
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.qaAttachments();
            Logout.Agent();
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void RAFlow1Org3()
        {
            // Rental Analysis Org3
            Login.qaValPortal("test3", "P@ssw0rd4");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.qaAttachments();
            Logout.Agent();
            Login.qaValPortal("test3", "P@ssw0rd4");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void PNMACFlow1Org1()
        {
            // PNMAC BPO Org1
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNEWPNMAC("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            PNMACBPO.CompleteBPO();
            Logout.Agent();
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void FMBFlow1Org1()
        {
            // FMB BPO Org1
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewFMBBPO("acme", "BPO", "Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal(); 
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            FMBBPO.qaFMBAttachments();
            Logout.Agent();
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }
        public static void AppraisalOrg1()
        {
            // Appraisal Org1
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewAppraisal("ACME Inc", "BPO", "Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("30005");
            Logout.ValPortal();
            Login.qaVendor("qaappraisalvendor", "P@ssw0rd1");
            Vendor.AcceptScheduleAppointment();
            Vendor.UploadAppraisal();
            Logout.Vendor();
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CompleteAppraisal();
            Logout.ValPortal();

        }

        public static void PCFlow1()
        {
            // Property Cure Regresssion Flow 1
            Login.qaPropertyCure("ibenPn", "Green!23");
            PropertyCure.AddNewProperty("Irvine", "Irvine", "California", "92620", "CSFB 2");
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

        public static void PcCleanSlate()
        {
            // Property Cure Regresssion Flow 1
            Login.uatPropertyCure("ibenPn", "Green!23");
            PropertyCure.AddNewUser("Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            PropertyCure.AddNewUser("George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");

            Logout.PropertyCure();

        }




    }


}