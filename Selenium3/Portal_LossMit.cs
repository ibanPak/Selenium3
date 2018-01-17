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
    class Portal_LossMit
    {

        public static void HODILShortSalePartI(Driver driver)
        {
            // Short Sale Part I
            // Accept Servicer Connection
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".selected > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".selected > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[1]/div[3]/div[1]/form/div[3]/table/tbody/tr[1]/td[2]/a");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[1]/div[3]/div[1]/form/div[3]/table/tbody/tr[1]/td[2]/a");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Accept Servicer Connection");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Accept Servicer Connection");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a.jbtn:nth-child(1) > span:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a.jbtn:nth-child(1) > span:nth-child(1)");
            // Change Client 
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propSummaryContents > div.contents > table:nth-child(2) > tbody > tr:nth-child(1) > td.value > a > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SearchValue_CaseAutoComplete");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SearchValue_CaseAutoComplete", "Bonnie DIL");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#button > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#button > span");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#searchClientsGrid > table > tbody > tr > td:nth-child(1) > input");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#searchClientsGrid > table > tbody > tr > td:nth-child(1) > input");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "button.ui-button-text-only:nth-child(2)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.ui-button-text-only:nth-child(2)");

            // Test Ended Close Window

        }

        public static void HODILShortSalePartII(Driver driver)
        {
            // Short Sale Part II
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".clearFix > li:nth-child(4) > a:nth-child(1) > span:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".clearFix > li:nth-child(4) > a:nth-child(1) > span:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".clearFix > li:nth-child(5) > a:nth-child(1) > span:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Review Deed in Lieu Request 
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Review Deed in Lieu Request");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Review Deed in Lieu Request");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#btnFooterUpdateAsDone");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#btnFooterUpdateAsDone");
            SeleniumWindowMethods.Sleep(3);
            // Homeowner Financials
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Homeowner Financials");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Homeowner Financials");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#btnFooterUpdateAsDone");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#btnFooterUpdateAsDone");
            SeleniumWindowMethods.Sleep(3);
            // Assign Roles
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Assign Roles");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Assign Roles");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "DefaultSSCoordinatorUserID");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultSSCoordinatorUserID", "Brian Lim");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultReviewerUserID", "Windy SS");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultNegotiatorUserID", "Crystal Nguyen");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultSrNegotiatorUserID", "Bonnie Homer");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultLossMitManagerUserID", "Vinh To");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultClosingCoordinatorUserID", "Bryan Nguyen");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DefaultClosingSupervisorUserID", "QA Test");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Comments", "Homeowner DIL Property - Testing Automation");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#btnFooterUpdateAsDone");
            SeleniumWindowMethods.Sleep(3);
            // Order Title
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#content > div > div > div.tabs.ui-tabs-nav > ul > li:nth-child(7) > a > span");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#generalPRData > div:nth-child(5) > div > span > span > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#generalPRData > div:nth-child(5) > div > span > span > a");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "VendorSearch_VendorId");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "VendorSearch_VendorId", "34049");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#searchFormTable > tbody > tr:nth-child(2) > td:nth-child(6) > a");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SelectVendor10498");
            SeleniumSetMethods.Click(driver, ElementType.Id, "SelectVendor10498");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#taskDetailsFooterContent > div.buttons > a.btn.green.btn-primary.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#taskDetailsFooterContent > div.buttons > a.btn.green.btn-primary.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#content > div.col.full > div > div.tabs.ui-tabs-nav.withSubMenu > ul > li:nth-child(5) > a > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#content > div.col.full > div > div.tabs.ui-tabs-nav.withSubMenu > ul > li:nth-child(5) > a > span");
            // Test Ended Close Window

        }

    }

}
