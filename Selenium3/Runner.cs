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
            REO.AddNewProperty("Rush Lily");
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
            REOTasks.CancelTasks();
            Logout.REO();

        }

        public static void PCFlow1()
        {
            // Property Cure Add Property
            Login.qaPropertyCure("qatest1", "Pwd12345678!");
            PropertyCure.AddNewProperty("testing", "Irvine", "California", "92620");
            PropertyCure.AddNewUser("iBen", "Nguyen-Cuu", "ibenPak", "iben@gmail.com", "blue123");

        }

    }

}