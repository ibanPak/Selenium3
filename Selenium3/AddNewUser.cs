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
    class AddNewUser
    {

        public static void ProPlusAgent(Driver driver, ENV environment, CreditCardType cardType)
        {
            Global.ConsoleOut("Add New User: Agent Portal (Pro+ Agent): " + DateTime.Now.ToString());
            SeleniumWindowMethods.Sleep(2);
            if (environment == ENV.QA)
            {
                SeleniumSetMethods.Navigate(driver, "https://qa-agent.res.net/");
            }
            else if (environment == ENV.UAT)
            {
                SeleniumSetMethods.Navigate(driver, "https://uat-agent.res.net/");
            }
            else if (environment == ENV.STG)
            {
                SeleniumSetMethods.Navigate(driver, "https://stg-agent.res.net/");
            }
            else if (environment == ENV.PROD)
            {
                SeleniumSetMethods.Navigate(driver, "https://agent.res.net/");
            }
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/registration/AccountStep']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/registration/AccountStep']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Auto");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", "Mated");
            SeleniumSetMethods.Click(driver, ElementType.Id, "Phone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Phone", "9491234567");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", "Automated" + Global.StreetNum + "@email.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", "blue123");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ConfirmPassword", "blue123");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#wrapperProPlusTier > div.wrapper-tier-box-content > input");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#wrapperProPlusTier > div.wrapper-tier-box-content > input");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CreditCardType_CodeId");
            Global.ConsoleOutTab(cardType + ": " + TestCreditCard.GetCardTestNumber(cardType));
            string cctype = "Drop Down Selection";
            if (cardType == CreditCardType.Visa)
            {
                cctype = "Visa";
            }
            else if (cardType == CreditCardType.Amex)
            {
                cctype = "American Express";
            }
            else if (cardType == CreditCardType.MasterCard1)
            {
                cctype = "Master Card";
            }
            else if (cardType == CreditCardType.MasterCard2)
            {
                cctype = "Master Card";
            }
            else if (cardType == CreditCardType.Discover)
            {
                cctype = "Discover";
            }
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CreditCardType_CodeId", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardNumber", TestCreditCard.GetCardTestNumber(cardType));
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CvvCode", "111");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ExpirationMonth", "01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ExpirationYear", DateTime.Today.AddYears(2).ToString("yyyy"));
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Automated");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingAddress", "100 Main St.");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SelectedBillingState", "California");
            SeleniumSetMethods.Click(driver, ElementType.Id, "BillingZip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingZip", "92620");
            SeleniumSetMethods.Click(driver, ElementType.Id, "saveButton");
            SeleniumWindowMethods.Sleep(3);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#main > div > div:nth-child(1) > div > p:nth-child(2)", "Welcome Message");
            SeleniumWindowMethods.ScreenShot(driver, "New User");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Dashboard']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Dashboard']");

        }

        public static void RegisterAppraiser(Driver driver, string Env1)
        {

            String appnum = DateTime.Today.Date.ToString("MMddyy");
            String appext = Env1 + "APP_" + appnum;

            // SeleniumSetMethods.Navigate("https://qa-vendor.res.net/Account/Profile");

            // Check for already member link
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssName, "#alreadyMember > a:nth-child(1)");
            Global.ConsoleOut("Back To Log in Page");
            Global.ConsoleOut("Window Title:" + PropertiesCollection.driver.Title);

            //Select Vendor Type -- Regristration Step 1
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.ui-button-text");
            Global.ConsoleOut("Window Title:" + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "cbAppraisalServices");
            SeleniumSetMethods.Click(driver, ElementType.Id, "cbAppraisalServices");

            //  Verify if the check boxes are enabled
            Boolean isAppraisalEnabled = PropertiesCollection.driver.FindElement(By.Id("cbAppraisalServices")).Enabled;
            if (isAppraisalEnabled == true)
            { Global.ConsoleOut("Appraisal Enabled"); }
            else { Global.ConsoleOut(" Appraisal not Enabled"); }
            SeleniumWindowMethods.Sleep(1);
            Boolean isEvictionEnabled = PropertiesCollection.driver.FindElement(By.Id("cbEvictionServices")).Enabled;
            if (isEvictionEnabled == true)
            { Global.ConsoleOut("Eviction Enabled"); }
            else { Global.ConsoleOut("Eviction not Enabled"); }
            Boolean isClosingEnabled = PropertiesCollection.driver.FindElement(By.Id("cbRealEstateClosingServices")).Enabled;
            if (isClosingEnabled == true)
            { Global.ConsoleOut("Closing is Enabled"); }
            else { Global.ConsoleOut("Closing is not Enabled"); }
            SeleniumWindowMethods.Sleep(1);
            Boolean isTitleEnabled = PropertiesCollection.driver.FindElement(By.Id("cbTitleServices")).Enabled;
            if (isTitleEnabled == true)
            { Global.ConsoleOut("Title is Enabled"); }
            else { Global.ConsoleOut("Title is not Enabled"); }

            //Company Info
            SeleniumSetMethods.Click(driver, ElementType.Id, "Company");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Company", "AutoAppraisalCO");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Phone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Phone", "714-993-9966");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Fax");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Fax", "7149939977");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", "s.deviqa+" + appext + "@hotmail.com");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PhysicalAddress1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PhysicalAddress1", "25500 Main street");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "City");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "City", "Essex");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SelectedState", "California");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Zip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Zip", "92332");

            // About Me
            SeleniumSetMethods.Clear(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "QAautoappraiser");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "LastName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", "Master");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "AccountTitle");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AccountTitle", "TestAppraiser");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UserPhone1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserPhone1", "7149939966");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UserPhone2");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserPhone2", "7149935555");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UserFax");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserFax", "7149939977");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UserEmail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserEmail", "s.deviqa+" + appext + "@hotmail.com");

            // Create Login Access
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UserName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserName", appext);
            SeleniumWindowMethods.Sleep(2);
            Global.Username = SeleniumGetMethods.GetTextValue(driver, ElementType.Id, "UserName");
            Global.ConsoleOut("Appraiser Username is  " + Global.Username);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Password");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", appext);
            Global.Password = SeleniumGetMethods.GetTextValue(driver, ElementType.Id, "Password");
            Global.ConsoleOut("Appraiser Password is " + Global.Password);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ConfirmPassword");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ConfirmPassword", appext);

            // Submit Create Account 
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.btn");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.btn");


            // Review Fees -- Regristration Step 2
            SeleniumSetMethods.Wait(driver, ElementType.Id, "navReviewTerms");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Terms of Use");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.Id, "reg-step-2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "Accept");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#btnContinue");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, " #btnContinue");

            // Complete profile- Regristration Step 3
            SeleniumSetMethods.Wait(driver, ElementType.Id, "navCompleteProfile");
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.ui-button-text");



            // Vendor Profile 
            SeleniumSetMethods.Wait(driver, ElementType.Id, "sameAddressPayment");
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);
            Global.ConsoleOut("Vendor Id is" + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, ".vendor-id"));

            // payment Info
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PaymentInfo_MakeCheckPayableTo");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PaymentInfo_MakeCheckPayableTo", "QAautoappraiser Tester");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PaymentInfo_PaymentAddress1");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PaymentInfo_PaymentAddress2");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PaymentInfo_City");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PaymentInfo_Zip");
            SeleniumSetMethods.Click(driver, ElementType.Id, "sameAddressPayment");

            // Fee Structure 
            //Global.ConsoleOut(" Fee information :" + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.content-block:nth-child(14) > table:nth-child(3) > tbody:nth-child(2)"));
            Global.ConsoleOut("MAINTENANCE FEE: " + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.content-block:nth-child(14) > table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(3) > span:nth-child(1) > text:nth-child(1)"));
            Global.ConsoleOut("TECHNOLOGY ACCESS FEE: " + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.content-block:nth-child(14) > table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(2) > td:nth-child(3) > span:nth-child(1)"));

            // Check Company info is populated 

            // Vendor Info . Verify the Services provided 

            //SDvendor.ServiceProvided();

            //  	Service Area
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add/Edit Area");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SelectedState");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@onclick='AddTerritories(event);']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SelectedState");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SelectedState", "California");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@onclick='AddTerritories(event);']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SelectedCounty");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SelectedCounty", "San Bernardino");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, " //button[@onclick='AddTerritories(event);']");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.XPath, " //button[@onclick='AddTerritories(event);']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ZipBoxHead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ZipBoxHead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "CityInputchino_hills");
            SeleniumSetMethods.Click(driver, ElementType.Id, "CityInputfontana");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ZipCodeInput92332");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//button[@onclick='AddTerritories(event);']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@onclick='AddTerritories(event);']");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut(" Initial selected Areas are: " + SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "selected_territories_container"));

            // Checking and removing the Zip code 92332 from service area.
            for (int i = 1; i < 10; i++)
            {
                string ServiceArea = (SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedTerritories > li:nth-child(" + i + ")")).Trim();
                // Global.ConsoleOut(" selected ter: " + selter);
                if (ServiceArea == "92332")
                {
                    // Global.ConsoleOut(" i is :  " + i);
                    Global.ConsoleOut(" Zip code 92332 found. Removing the zipcode.");
                    SeleniumSetMethods.Click(driver, ElementType.XPath, "//ul[@id='selectedTerritories']/li[" + i + "]/a");
                    // Global.ConsoleOut("Final selected Areas are: " + SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "selected_territories_container"));
                    break;
                }

            }
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[3] ");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "AreaPreview");
            Global.ConsoleOut("Service Area selected :  " + SeleniumGetMethods.GetTextValue(driver, ElementType.Id, "AreaPreview"));

            // Property Transaction Types
            Global.ConsoleOut(" Property Transaction Types ");
            Boolean IsReotransaction = PropertiesCollection.driver.FindElement(By.Id("TransactionTypes_3")).Selected;
            if (IsReotransaction == true)
            {
                Global.ConsoleOut("REO is checked and unchecked the REO. ");
                SeleniumSetMethods.Click(driver, ElementType.Id, "TransactionTypes_3");
            }
            else { Global.ConsoleOut("REO is not checked"); }

            Boolean IsResaletransaction = PropertiesCollection.driver.FindElement(By.Id("TransactionTypes_2")).Selected;
            if (IsResaletransaction == true)
            {
                Global.ConsoleOut("Resale is checked and unchecked the Resale ");
                SeleniumSetMethods.Click(driver, ElementType.Id, "TransactionTypes_2");
            }
            else { Global.ConsoleOut("Resale is not checked "); }

            Boolean IsLossMittransaction = PropertiesCollection.driver.FindElement(By.Id("TransactionTypes_1")).Selected;
            if (IsLossMittransaction == true)
            {
                Global.ConsoleOut("Loss Mitigation is checked and unchecked the Loss Mitigation ");
                SeleniumSetMethods.Click(driver, ElementType.Id, "TransactionTypes_1");
            }
            else { Global.ConsoleOut("Loss Mitigation is not checked "); }


            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.btn");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.btn");
            Global.ConsoleOut("Error Message: " + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, ".validation-summary-errors > ul:nth-child(1) > li:nth-child(1)"));

            SeleniumSetMethods.Wait(driver, ElementType.Id, "sameAddressPayment");
            SeleniumSetMethods.Click(driver, ElementType.Id, "TransactionTypes_3");
            Global.ConsoleOut("REO Transaction type is Checked");
            SeleniumSetMethods.Click(driver, ElementType.Id, "TransactionTypes_1");
            Global.ConsoleOut("Loss Mitigation Transaction type is Checked");

            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.btn");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.btn");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".ui-dialog");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.primary");
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);


            //   License(s) & Certification(s)     
            SeleniumSetMethods.Wait(driver, ElementType.Id, "LicensesModels_0__LicenseNumber");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "LicensesModels_0__LicenseNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LicensesModels_0__LicenseNumber", "APPLic 123-8555");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "LicensesModels_0__Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LicensesModels_0__Name", "QaAPPAuto tester");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "LicensesModels_0__SelectedLicenseType", "Appraiser Licensed: Certified");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "LicensesModels_0__SelectedState", "California");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "LicensesModels_0__Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LicensesModels_0__Address", "123 Main streeet, Essex, CA 92332");
            SeleniumSetMethods.Click(driver, ElementType.Id, "LicensesModels_0__ExpirationDate");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "LicensesModels_0__ExpirationDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LicensesModels_0__ExpirationDate", Global.NextMonth);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumWindowMethods.Sleep(1);
            // currently there is issue with vendor and chrome uploads
            //SeleniumSetMethods.Wait(driver, ElementType.Id, "LicensesModels_0__LicenseAttachment");
            //SeleniumSetMethods.Clear(driver, ElementType.CssSelector, "#LicensesModels_0__LicenseAttachment");
            // SeleniumWindowMethods.ThrottlingSleep();
            // SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#LicensesModels_0__LicenseAttachment", "\\\\hqfs1\\Public\\IT\\QA\\QA Automation\\Platinum\\TestDoc.pdf");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Add License");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "LicensesModels_1__LicenseNumber");
            SeleniumSetMethods.Click(driver, ElementType.Id, "LicensesModels_1__LicenseNumber");
            //SeleniumSetMethods.EnterText(driver, ElementType.Id, "LicensesModels_1__LicenseNumber","lic1");
            Global.ConsoleOut("Additional License # field added.");

            // Tax info section 
            SeleniumSetMethods.Wait(driver, ElementType.Id, "W9Model_TaxIdNumber");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "W9Model_TaxIdNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "W9Model_TaxIdNumber", "tax123");
            SeleniumSetMethods.Click(driver, ElementType.Id, "W9Model_TaxInformationIsAccurate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "SWFUpload_2");
            Global.ConsoleOut("UPLOAD DOCUMENT- W_9");
            SeleniumWindowMethods.Sleep(15);


            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.btn");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.btn");


            // Back to Dashboard link and click the link from Notice:Update Profile
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");

            // Checking the link from Notice 
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Click here");
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);



            //  SeleniumSetMethods.Navigate("https://qa-vendor.res.net/Account/Profile");

            // Check  Cancel Button 
            SeleniumSetMethods.Wait(driver, ElementType.Id, "EoInsuranceModels_0__Policy");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "EoInsuranceModels_0__Policy");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "EoInsuranceModels_0__Policy", "test");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.ui-button-text");
            Global.ConsoleOut("Page Title: " + PropertiesCollection.driver.Title);
        }

    }

}