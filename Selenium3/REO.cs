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
    class REO
    {

        public static void AddNewProperty(string StreetName)
        {
            // Properties - Add New Property
            SeleniumSetMethods.Wait(ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.LinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.ui-button-text");
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);

            // Add New Property iFrame
            SeleniumWindowMethods.iFrame("externalSite");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_POP_CLIENTPA']");
            Global.ConsoleOut("Open Popup - New Property");

            // Client - Popup
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Name, "csClientId");
            SeleniumSetMethods.EnterText(ElementType.Name, "csClientId", "7224");
            SeleniumSetMethods.Wait(ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(ElementType.Name, "btnRedraw");
            SeleniumWindowMethods.WindowType(WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(ElementType.CssSelector, "img");
            Global.ConsoleOut("Popup closing");

            // Switch back to main window - Asset Manager Popup
            SeleniumWindowMethods.WindowType(WinType.Main);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame("externalSite");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_POP_AMGRPA']");
            SeleniumWindowMethods.WindowType(WinType.Popup);
            SeleniumSetMethods.Wait(ElementType.Name, "msAmId");
            SeleniumSetMethods.EnterText(ElementType.Name, "msAmId", "3287");
            SeleniumSetMethods.Wait(ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(ElementType.CssSelector, "img");

            // Switch back to main window - File Manager Popup
            SeleniumWindowMethods.WindowType(WinType.Main);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame("externalSite");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_POP_AMGRPA2']");
            SeleniumWindowMethods.WindowType(WinType.Popup);
            SeleniumSetMethods.Wait(ElementType.Name, "msAmId");
            SeleniumSetMethods.Clear(ElementType.Name, "msAmId");
            SeleniumSetMethods.Wait(ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'Jon1']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'Jon1']");

            // Switch back to main window - Asset Manager Popup
            SeleniumWindowMethods.WindowType(WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame("externalSite");
            
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Name, "paPropAddr");
            SeleniumSetMethods.EnterText(ElementType.Name, "paPropAddr", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Name, "paPropCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "paPropState", "California");
            SeleniumSetMethods.EnterText(ElementType.Name, "paPropZip", "92620");

            // Loan Information
            SeleniumSetMethods.EnterText(ElementType.Name, "Loan_Number", Global.LoanNum);
            SeleniumSetMethods.EnterText(ElementType.Name, "Borrower_First", "FirstName");
            SeleniumSetMethods.EnterText(ElementType.Name, "Borrower_Last", "LastName");
            SeleniumSetMethods.SelectDropDown(ElementType.Name, "paPropType", "SFR");

            // Add Attorney - Popup
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_POP_FCATTNYPA']");
            Global.ConsoleOut("Open Popup - Attorney");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(WinType.Popup);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'Just']");

            // Switch back to main window 
            SeleniumWindowMethods.WindowType(WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame("externalSite");
            SeleniumSetMethods.EnterText(ElementType.Name, "Fc_Saledt", Global.LastMonth);
            SeleniumSetMethods.EnterText(ElementType.Name, "Unpd_Bal", "250000");
            SeleniumSetMethods.EnterText(ElementType.Name, "Fc_Apr_Value", "500000");
            SeleniumSetMethods.EnterText(ElementType.Name, "Fc_Apr_Dte", Global.LastYear);
            SeleniumSetMethods.EnterText(ElementType.Name, "txtpaNote", "Do you want to build a snowman?");
            SeleniumSetMethods.Click(ElementType.Name, "txtpaNote");
            SeleniumSetMethods.Click(ElementType.Name, "btnAdd");
            SeleniumWindowMethods.Sleep(3);

            // Get Property ID from Property Details page

            try
            {
                string PropertyID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
                Global.OrderID = PropertyID;
                Global.ConsoleOut("Property ID: " + PropertyID); ;
            }
            catch
            {
                SeleniumWindowMethods.Sleep(2);
                SeleniumSetMethods.Wait(ElementType.Name, "btnAdd");
                SeleniumSetMethods.Click(ElementType.Name, "btnAdd");
                SeleniumWindowMethods.Sleep(2);
                string PropertyID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
                Global.OrderID = PropertyID;
                Global.ConsoleOut("Property ID: " + PropertyID); ;

            }
            

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("REO New Property");

        }

        public static void AddAgent()
        {
           
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPEDIT']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPEDIT']");

            // Add Edit this Property iFrame
            SeleniumWindowMethods.iFrame("externalSite");
            SeleniumSetMethods.Clear(ElementType.Name, "pdUpb");
            SeleniumSetMethods.EnterText(ElementType.Name, "pdUpb", "350000");
            SeleniumSetMethods.Click(ElementType.Name, "btnUpdate");

            // Focus Main page
            SeleniumWindowMethods.WindowType(WinType.Main);
            Global.ConsoleOut("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPINS']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPINS']");
            Global.ConsoleOut("The value for this field should be ($350,000): "
                   + SeleniumGetMethods.GetTextValue(ElementType.Name, "piFcBal"));
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#column2 > tbody:nth-child(1) > tr:nth-child(3) > td:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#column2 > tbody:nth-child(1) > tr:nth-child(3) > td:nth-child(1) > a:nth-child(1)");

            // Assign Agent
            SeleniumWindowMethods.iFrame("imsb-iframe");
            SeleniumSetMethods.Wait(ElementType.Name, "apsFirst");
            SeleniumSetMethods.EnterText(ElementType.Name, "apsFirst", "ivan");
            SeleniumSetMethods.Click(ElementType.CssSelector, "input.btnGreen");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Name, "btnAssign_250922");
            SeleniumSetMethods.Click(ElementType.Name, "btnAssign_250922");
            try
            {
                SeleniumWindowMethods.Assertion(Alert.Accept);
                // Alert present; set the flag
                Global.ConsoleOut("Accepted Confirmation Message");
            }
            catch
            {
                // Alert not present
                Global.ConsoleOut("Confirmation Message: Not Present");
            }

        //Pre Marketing Tab
        SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_PROPPREMKT']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_PROPPREMKT']");

            SeleniumSetMethods.Clear(ElementType.Name, "pmBpoOrdDt");
            SeleniumSetMethods.Click(ElementType.Id, "InputForm");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Clear(ElementType.Name, "pmBpoDueDt");
            SeleniumSetMethods.Click(ElementType.Id, "InputForm");

            SeleniumSetMethods.EnterText(ElementType.Name, "pmBpoOrdDt", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "InputForm");
            SeleniumSetMethods.EnterText(ElementType.Name, "pmBpoDueDt", Global.NextMonth);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "InputForm");

            SeleniumSetMethods.Click(ElementType.Name, "btnUpdate");

        }


    }


}