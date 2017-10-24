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
    class Portal_REO
    {

        public static void AddNewProperty(Driver driver, string streetname, string city, string state, string zipcode)
        {
            // Properties - Add New Property
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.ui-button-text");
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);

            // Add New Property iFrame
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_CLIENTPA']");
            Global.ConsoleOut("Open Popup - New Property");

            // Client - Popup
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "csClientId");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "csClientId", "7224");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnRedraw");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img");
            Global.ConsoleOut("Popup closing");

            // Switch back to main window - Asset Manager Popup
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_AMGRPA']");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "msAmId");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "msAmId", "3287");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img");

            // Switch back to main window - File Manager Popup
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_AMGRPA2']");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "msAmId");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "msAmId");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'Jon1']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'Jon1']");

            // Switch back to main window - Asset Manager Popup
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "paPropAddr");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "paPropAddr", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "paPropCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "paPropState", state);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "paPropZip", zipcode);

            // Loan Information
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Loan_Number", Global.LoanNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Borrower_First", "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Borrower_Last", "LastName");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "paPropType", "SFR");

            // Add Attorney - Popup
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_FCATTNYPA']");
            Global.ConsoleOut("Open Popup - Attorney");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'Just']");

            // Switch back to main window 
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Fc_Saledt", Global.LastMonth);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Unpd_Bal", "250000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Fc_Apr_Value", "500000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Fc_Apr_Dte", Global.LastYear);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtpaNote", "Do you want to build a snowman?");
            SeleniumSetMethods.Click(driver, ElementType.Name, "txtpaNote");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnAdd");
            SeleniumWindowMethods.Sleep(3);

            // Get Property ID from Property Details page

            try
            {
                string PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
                Global.OrderID = PropertyID;
                Global.ConsoleOut("Property ID: " + PropertyID); ;
            }
            catch
            {
                SeleniumWindowMethods.Sleep(2);
                SeleniumSetMethods.Wait(driver, ElementType.Name, "btnAdd");
                SeleniumSetMethods.Click(driver, ElementType.Name, "btnAdd");
                SeleniumWindowMethods.Sleep(2);
                string PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
                Global.OrderID = PropertyID;
                Global.ConsoleOut("Property ID: " + PropertyID); ;

            }
            
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "REO New Property");

        }

        public static void AddAgent(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Dashboard");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Dashboard");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "globalPropertySearchSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "globalPropertySearchSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPEDIT']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPEDIT']");

            // Add Edit this Property iFrame
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "pdUpb");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "pdUpb");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pdUpb", "350000");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");

            // Focus Main page
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPINS']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPINS']");
            Global.ConsoleOut("The value for this field should be ($350,000): "
                   + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "piFcBal"));
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#column2 > tbody:nth-child(1) > tr:nth-child(3) > td:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#column2 > tbody:nth-child(1) > tr:nth-child(3) > td:nth-child(1) > a:nth-child(1)");

            // Assign Agent
            SeleniumWindowMethods.iFrame(driver, "imsb-iframe");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "apsFirst");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "apsFirst", "ivan");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.btnGreen");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnAssign_250922");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnAssign_250922");
            try
            {
                SeleniumWindowMethods.Assertion(driver, Alert.Accept);
                // Alert present; set the flag
                Global.ConsoleOut("Accepted Confirmation Message");
            }
            catch
            {
                // Alert not present
                Global.ConsoleOut("Confirmation Message: Not Present");
            }

        }

        public static void PreMarket(Driver driver)
        {
            //Pre Marketing Tab
            SeleniumSetMethods.Wait(driver, ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "qsAddress");
            SeleniumSetMethods.Click(driver, ElementType.Id, "qsAddress");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPPREMKT']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPPREMKT']");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "pmBpoOrdDt");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pmBpoOrdDt", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Clear(driver, ElementType.Name, "pmBpoDueDt");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pmBpoOrdDt", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Clear(driver, ElementType.Name, "pmBpoDueDt");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pmBpoDueDt", Global.NextMonth);
            SeleniumWindowMethods.Sleep(1);            
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");

        }


    }


}