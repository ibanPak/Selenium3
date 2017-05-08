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
    class uatRunner
    {

        public static void REOFlowOrg1()
        {
            // REO Flow Org1
            Login.uatREO("prodkath2", "qatest10");
            REO.AddNewProperty("Bay Tree");
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

        public static void RAFlow1Org1()
        {
            // UAT Org 1 RAFlow1
            Login.uatValPortal("bryan", "qatest16"); ;
            ValPortal.CreateNewRentalAnalysis("Anita Rental Survey Co.", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.uatAttachments();
            Logout.Agent(); 
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void RAFlow1Org3()
        {
            // UAT Org 3 RAFlow1
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CreateNewRentalAnalysis("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Great Lawn", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenRentalAnalysis();
            RentalAnalysis.CompleteRentalAnalysis();
            RentalAnalysis.uatAttachments();
            Logout.Agent();
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteRAOrder();
            Logout.ValPortal();

        }

        public static void PNMACFlow1Org1()
        {
            // PNMAC BPO Org1
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CreateNEWPNMAC("Rental Analysis Co.", "Rental Analysis", "Rental Analysis Exterior", "Roosevelt", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250922");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            PNMACBPO.CompleteBPO();
            Logout.Agent();
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void FMBFlow1Org1()
        {
            // FMB BPO Org1
           Login.uatValPortal("bryan", "qatest16");
            ValPortal.CreateNewFMBBPO("ACME Inc", "BPO", "Exterior", "Viola", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();  
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            FMBBPO.FMB();
            FMBBPO.uatFMBAttachments();
            Logout.Agent();  
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void Unified53Org1()
        {
            // UAT Org 1 RAFlow1
            Login.uatValPortal("bryan", "qatest16"); ;
            ValPortal.CreateNewUnified53("Unified 53", "BPO", "Broker Price Opinion Exterior Inspection", "Meadowood", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("250418");
            Logout.ValPortal();
            Login.uatAgent("QATest25@usres.com", "blue123");
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            Unified53BPO.U53Order();
            Unified53BPO.uatAttachments();
            Logout.Agent();  
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteBPOOrder();
            Logout.ValPortal();

        }

        public static void AppraisalOrg1()
        {
            // Appraisal Org1
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CreateNewAppraisal("ACME Inc", "Appraisal", "1004 Interior Residential", "Dublin", "Irvine", "California", "92620");
            ValPortal.ManualProviderAssign("30005");
            Logout.ValPortal();
            Login.uatVendor("qaappraisalvendor", "P@ssw0rd1");
            Vendor.AcceptScheduleAppointment();
            Vendor.UploadAppraisal();
            Logout.Vendor();
            Login.uatValPortal("bryan", "qatest16");
            ValPortal.CompleteAppraisal();
            Logout.ValPortal();

        }

        public static void PCFlow1Org1()
        {
            // Property Cure Add Property
            Login.uatPropertyCure("qatest1", "Pwd12345678!");
            PropertyCure.AddNewProperty("testing", "Irvine", "California", "92620");
            PropertyCure.AddNewUser("iBen", "Nguyen-Cuu", "ibenPak", "iben@gmail.com", "blue123");

        }


    }

}