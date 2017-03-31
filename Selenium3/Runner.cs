using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Runner
    {

        public static void REOFlow1()
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

        public static void PCFlow1()
        {
            // Property Cure Add Property
            Login.qaPropertyCure("qatest1", "Pwd12345678!");
            PropertyCure.AddNewProperty("testing", "Irvine", "California", "92620");
            PropertyCure.AddNewUser("iBen", "Nguyen-Cuu", "ibenPak", "iben@gmail.com", "blue123");

        }

        public static void RAvalFlow1()
        {
            // Property Cure Add Property
            Login.qaValPortal("test", "P@ssw0rd1");
            ValPortal.CreateNewRentalAnalysis("Roosevelt");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.qaAgent("QATest23@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.RAExteriorAttachments();
            Logout.Agent();
            Login.qaValPortal("test", "P@ssw0rd1");
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

        public static void FMBFlow1()
        {
            // Property Cure Add Property
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


    }

}