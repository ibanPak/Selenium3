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
    class Portal_Homeowner
    {

        public static void CreateDILProperty(Driver driver)
        {
            // Create DIL Property
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propSummary > div > a:nth-child(2)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propSummary > div > a:nth-child(2)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "TransactionType_CodeID");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "TransactionType_CodeID", "Deed In Lieu");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyAddress", "11 Florence St");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "City", "East Haven");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "State_Code", "CT");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Zip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Zip", "06512");
            SeleniumSetMethods.Click(driver, ElementType.Id, "chkCopyAddress");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyType_CodeId", "SFR");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerFirstName", "Second");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerLastName", "Borrower");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "CoBorrowerPhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerPhone", "9999999999");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerPhoneTypeCodeId", "Cell");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "CoBorrowerPhone2");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerPhone2", "9999999990");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerPhone2TypeCodeId", "Home");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CoBorrowerEmail", "secondone@hotesting.com");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertyForm > div.bottom-controls > a:nth-child(2) > span");
            // Connect to Servicer
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_tasks");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_tasks");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Connect to Servicer");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Connect to Servicer");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "LenderID");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LenderID", "Wells Fargo SA");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Mortgage1_LoanNumber", "54321");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Mortgage1_LoanBalance", "75200");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a.btn:nth-child(2) > span:nth-child(1) > b:nth-child(1)");

            // Test Ended Close Window

        }

        public static void HODILHomeownerPartII(Driver driver)
        {
            // Homeowner Tasks
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#tab_miscforms > a:nth-child(1) > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#tab_miscforms > a:nth-child(1) > span:nth-child(1) > b:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#tab_tasks > a:nth-child(1) > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#tab_tasks > a:nth-child(1) > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Submit Deed in Lieu Request");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Submit Deed in Lieu Request");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "MailingAddress_Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileFirst_Required_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\H5.jpg");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileSecond_Required_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C5.jpg");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a.btn:nth-child(2) > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a.btn:nth-child(2) > span:nth-child(1) > b:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Submit Homeowner Financials
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Homeowner Financials");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Homeowner Financials");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "MonthlyHouseholdIncomeInfo_MonthlyGrossWages");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileHardshipLetter_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\H5.jpg");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileTaxReturns_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\H5.jpg");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileBankStatements_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C5.jpg");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "FileBankStatementsMostRecentDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileBankStatementsMostRecentDate", "01012018");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FileW2and1099_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FilePaycheckStubs_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B5.jpg");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "FilePaycheckStubsMostRecentDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FilePaycheckStubsMostRecentDate", "01012018");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a.btn:nth-child(2) > span:nth-child(1) > b:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Logout");

            // Test Ended Close Window

        }

    }

}
