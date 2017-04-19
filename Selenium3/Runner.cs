using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Runner
    {

        public static void qaREOFlow1()
        {
            // REO Main Regression Flow
            Login.qaREO("Yeshh1", "Yeshh1");
            REO.AddNewProperty("Roosevelt");
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
            REOTasks.AssetMGRTasks();
            Logout.REO();
            Global.ConsoleOut("Run Amp Order Sync");
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.OpenREOTasks("BPO task"); REOBPO.BPOtask();
            Agent.OpenREOTasks("BPO Pictures"); REOBPO.BPOPictures();
            Logout.Agent();

        }

        public static void uatREOFlow1()
        {
            // REO Main Regression Flow
            Login.uatREO("prodkath2", "qatest10");
            REO.AddNewProperty("Roosevelt");
            REO.AddAgent();
            Logout.REO(); 
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.OpenREOTasks("Winterization"); REOTasks.Winterization("iben");
            Agent.OpenREOTasks("Occupancy Status Task"); REOTasks.OccupancyStatusTask();
            Agent.OpenREOTasks("Tax Research Task"); REOTasks.TaxResearchTask();
            Agent.OpenREOTasks("Referral Agreement"); REOTasks.ReferralFeeAgreement("iben");
            Agent.OpenREOTasks("HOA information task"); REOTasks.HOAInformation();
            Agent.OpenREOTasks("Listing Addendum"); REOTasks.ListingAddendum("iben");
            Logout.Agent(); 
            Login.uatREO("prodkath2", "qatest10");
            REOTasks.AssetMGRTasks();
            Logout.REO();
            Global.ConsoleOut("Run Amp Order Sync");
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.OpenREOTasks("BPO task"); REOBPO.BPOtask();
            Agent.OpenREOTasks("BPO Pictures"); REOBPO.BPOPictures();
            Logout.Agent();

        }

        public static void PCFlow1()
        {
            // Property Cure Add Property
            Login.qaPropertyCure("qatest1", "Pwd12345678!");
            PropertyCure.AddNewProperty("testing", "Irvine", "California", "92620");
            PropertyCure.AddNewUser("iBen", "Nguyen-Cuu", "ibenPak", "iben@gmail.com", "blue123");

        }

        public static void uatRAFlow1()
        {
            // UAT Org 3 RAFlow1
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.RAExteriorAttachments();
            Logout.Agent();
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void uatRAFlow2()
        {
            // UAT Org 3 RAFlow1
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.RAExteriorAttachments();
            Logout.Agent();
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void PNMACFlow1()
        {
            // Property Cure Add Property
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNEWPNMAC("Rush Lily");
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

        public static void qaFMBFlow1()
        {
            // QA FMB BPO
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewFMBBPO("Great Lawn");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();  
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            Logout.Agent();
            Login.qaValPortal("test", "P@ssw0rd1"); 
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void uatFMBFlow1()
        {
            // UAT FMB BPO
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CreateNewFMBBPO("Great Lawn");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();  
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            Logout.Agent(); 
            Login.uatValPortal("test3", "P@ssw0rd!");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }
        public static void qaAppraisal()
        {
            // QA Appraisal
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewAppraisal("Irvine");
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


    }

}