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
using OpenQA.Selenium;

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

        public static void AssetMGRTasks()
        {

            SeleniumSetMethods.Wait(ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "qsAddress");
            SeleniumSetMethods.Click(ElementType.Id, "qsAddress");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("SCRA Referral (Custom)");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[3]"); 

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Sivad Custom task (Custom)");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.Id, "Test1");
            SeleniumSetMethods.EnterText(ElementType.Id, "Test1", "yellow");
            SeleniumSetMethods.Click(ElementType.Name, "btnUpdate");
            SeleniumSetMethods.Wait(ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Click(ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("122314 Custom Task (Custom)");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Click(ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateAsDone");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Sivad Custom task (Custom)");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.EnterText(ElementType.Id, "Test1", "Enter Comment");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateAsDone");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Home Owners Assoc Information Request");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Tax Research Request");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Listing Acknowledgement");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Referral Agreement");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Winterization Requirements Request");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back("Occupancy Status Request");
            IfExists.Id_Refresh("globalPropertySearch");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

        }

    

        public static void PropertyInspection()
        {

       /*   SeleniumSetMethods.Wait(ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "qsAddress");
            SeleniumSetMethods.Click(ElementType.Id, "qsAddress");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Wait(ElementType.LinkText, "Property Inspection");
            SeleniumSetMethods.Click(ElementType.LinkText, "Property Inspection");  */
            SeleniumSetMethods.Wait(ElementType.Name, "inspDate_visit");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspDate_visit", Global.LastMonth);
            SeleniumSetMethods.Click(ElementType.Name, "inspStatus_vacant");
            SeleniumSetMethods.Click(ElementType.Name, "inspStatus_Personal_No");
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "#form-questions > table > tbody > tr > td:nth-child(1) > ul > li:nth-child(1) > div > ul > li:nth-child(1) > input[type=\"file\"]"
                , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B1.jpg");

            //    SeleniumSetMethods.EnterText(ElementType.Name, "insp_23446296_5", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B1.jpg");
            SeleniumSetMethods.Click(ElementType.Name, "inspRe_keyed_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspLockBox_Yes");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspLockBox_Code", "12345");
            SeleniumSetMethods.Click(ElementType.Name, "inspEvid_MOLD_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspSmoke_Yes");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspSmoke_How_many", "6");
            SeleniumSetMethods.Click(ElementType.Name, "inspAir_cond_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspAir_cond_Opt_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspEvid_Hazardous_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspPool_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspCarpet_Yes");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspCarpet_Location", "Everywhere I look");
            SeleniumSetMethods.Click(ElementType.Name, "inspCarpet_Recom_Clean_Yes");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspCarpet_Why", "Yes it's pretty dirty");
            SeleniumSetMethods.Click(ElementType.Name, "inspSprinkler_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspSprinkler_Time_Pres_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspSprinkler_Oper_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspWater_Heater_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspWater_Heater_CA_Yes");
            SeleniumSetMethods.Click(ElementType.Name, "inspRegulations_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspSafety_Hazards_No");
            SeleniumSetMethods.Click(ElementType.Name, "inspEvid_Damage_No");
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "#form-questions > table > tbody > tr > td:nth-child(2) > ul > li:nth-child(7) > div > ul > li:nth-child(1) > input[type=\"file\"]"
                , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B2.jpg");
            SeleniumSetMethods.EnterText(ElementType.Name, "inspsignature_name", "iben");
            SeleniumSetMethods.Click(ElementType.Name, "btnSaveSubmit");
            SeleniumSetMethods.Click(ElementType.XPath, "xpath=(//input[@name='btnUpdate'])[2]");


        }


       

    }


}
