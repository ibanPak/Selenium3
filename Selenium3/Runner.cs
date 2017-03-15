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

        public static void Sample()
        {
            // Sample Code to Execute
            String PropertyID = "507635";
            Global.OrderID = PropertyID;

            Login.qaBuyer("qapaidbuyer03", "P@ssw0rd1");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "Atlanta, GA");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "searchPropertyID");
            SeleniumSetMethods.EnterText(ElementType.Id, "searchPropertyID", Global.OrderID);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.searchbtn > #propertiesSubmit > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.searchbtn > #propertiesSubmit > span > b");
            // Click on Property Returned
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Properties/Details/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Properties/Details/']");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#tab_offers > a > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#tab_offers > a > span > b");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.expandable");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.expandable");
            // Click on First Offer
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#poffer_tbl > tbody > tr > td > a");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#poffer_tbl > tbody > tr > td > a");
            SeleniumSetMethods.Wait(ElementType.Id, "offerAction");
            SeleniumSetMethods.EnterText(ElementType.Id, "offerAction", "Counter");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(ElementType.Id, "offerAction", "Counter");
            SeleniumSetMethods.Wait(ElementType.Id, "copyRecentOfferLink");
            SeleniumSetMethods.Click(ElementType.Id, "copyRecentOfferLink");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Clear(ElementType.CssSelector, "td[id=\"Offer#2\"] input[id$=\"__LoanAmount\"]");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "td[id=\"Offer#2\"] input[id$=\"__LoanAmount\"]", "300000.00");
    


        }

    }

}