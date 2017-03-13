using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class REOTasks
    {

        public static void Winterization(string AgentName)
        {
            SeleniumSetMethods.Wait(ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.Click(ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.EnterText(ElementType.Name, "wsrSigned", AgentName);
            SeleniumSetMethods.Click(ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void OccupancyStatusTask()
        {
            SeleniumSetMethods.Wait(ElementType.Name, "osCurChkDt");
            SeleniumSetMethods.EnterText(ElementType.Name, "osCurChkDt", "03/02/17");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osVacant", "Yes");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osPropType", "SFR");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osList", "Yes");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osUnCoop", "No");
            SeleniumSetMethods.EnterText(ElementType.Name, "osBox", "1234");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osLegal", "1");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "osLegal1", "Vacant Secure");
            SeleniumSetMethods.EnterText(ElementType.Id, "txtosAgentNote", "It's good to go");
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "#tabStandards > tbody:nth-child(1) > tr:nth-child(6) > td:nth-child(1) > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > input:nth-child(3)", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void TaxResearchTask()
        {
            SeleniumSetMethods.EnterText(ElementType.Name, "taxCounty", "Orange");
            SeleniumSetMethods.EnterText(ElementType.Name, "taxParcel", "1234567");
            SeleniumSetMethods.EnterText(ElementType.Name, "taxTaxContact", "995422");
            SeleniumSetMethods.EnterText(ElementType.Name, "taxTaxContactPh", "9493331234");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "tax1Yr", "2017");
            SeleniumSetMethods.Clear(ElementType.Name, "tax1AmtDue");
            SeleniumSetMethods.Clear(ElementType.Name, "tax1Penalties");
            SeleniumSetMethods.EnterText(ElementType.Name, "tax1AmtDue", "500.00");
            SeleniumSetMethods.EnterText(ElementType.Name, "tax1Penalties", "7.00");
            SeleniumSetMethods.EnterText(ElementType.Name, "taxTaxExpDt", "01/02/18");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='taxLiens'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='taxTaxSale'])[2]");
            SeleniumSetMethods.EnterText(ElementType.Name, "txtTaxCheck", "USRES");
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void ReferralFeeAgreement(string AgentName)
        {
            SeleniumSetMethods.Wait(ElementType.Name, "raSigned");
            SeleniumSetMethods.EnterText(ElementType.Name, "raSigned", AgentName);
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void ListingAddendum(string AgentName)
        {
            SeleniumSetMethods.Wait(ElementType.Name, "laSigned");
            SeleniumSetMethods.EnterText(ElementType.Name, "laSigned", AgentName);
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void HOAInformation()
        {
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "hoaReq", "Yes");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaName", "Irvine Company");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaContact", "Big Bird");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaPhone", "949-333-5432");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaPayment", "350");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaPaymentDt", "01/01/17");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaPastDue", "0");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "hoaFreq", "Monthly");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaHoaAddr", "20 Pacifica");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaHoaCity", "Irvine");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaHoaState", "CA");
            SeleniumSetMethods.EnterText(ElementType.Name, "hoaHoaZip", "92618");

            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");

        }

        public static void CancelTasks()
        {

            SeleniumSetMethods.Wait(ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "qsAddress");
            SeleniumSetMethods.Click(ElementType.Id, "qsAddress");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Wait(ElementType.LinkText, "SCRA Referral (Custom)");
            SeleniumSetMethods.Click(ElementType.LinkText, "SCRA Referral (Custom)");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumSetMethods.Wait(ElementType.LinkText, "Sivad Custom task (Custom)");
            SeleniumSetMethods.Click(ElementType.LinkText, "Sivad Custom task (Custom)");
            SeleniumSetMethods.Wait(ElementType.Id, "Test1");
            SeleniumSetMethods.EnterText(ElementType.Id, "Test1", "yellow");
            SeleniumSetMethods.Click(ElementType.Name, "btnUpdate");
            SeleniumSetMethods.Wait(ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Click(ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(ElementType.LinkText, "122314 Custom Task (Custom)");
            SeleniumSetMethods.Click(ElementType.LinkText, "122314 Custom Task (Custom)");
            SeleniumSetMethods.Wait(ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Click(ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateAsDone");

        }


    }


}
