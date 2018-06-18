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
        public static string PropSaveFilterName = "0";
        public static string PropResults = "0";

        public static void GotoPropertyId(Driver driver, string propertyid)
        {
            try
            {
                SeleniumWindowMethods.Sleep(2);
                SeleniumSetMethods.Wait(driver, ElementType.Id, "globalPropertySearch");
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "globalPropertySearch", propertyid);
                SeleniumWindowMethods.Sleep(5);
                SeleniumSetMethods.Click(driver, ElementType.Id, "link0");
            }
            catch(NoSuchElementException)
            {
                SeleniumWindowMethods.Sleep(5);
                SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
                SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
                SeleniumWindowMethods.Sleep(2);
                SeleniumSetMethods.Wait(driver, ElementType.Name, "btnResetFilters");
                SeleniumSetMethods.Click(driver, ElementType.Name, "btnResetFilters");
                SeleniumSetMethods.EnterText(driver, ElementType.Name, "pfPropID", propertyid);
                SeleniumSetMethods.Click(driver, ElementType.Name, "btnSearchProp");
                SeleniumWindowMethods.Sleep(2);
                SeleniumSetMethods.Wait(driver, ElementType.XPath, "//*[@id=\"resultsHere\"]/span/table/tbody[1]/tr/td[1]/a");
                SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id=\"resultsHere\"]/span/table/tbody[1]/tr/td[1]/a");

            }

        }

        public static void AddNewProperty(Driver driver, string clientid, string streetnumber, string streetname, string city, string state, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.streetnumber;
            }
            else
            {
                Global.streetnumber = streetnumber;
            }

            // Properties - Add New Property
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.ui-button-text");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.ui-button-text");
            // Add New Property iFrame
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_POP_CLIENTPA']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_CLIENTPA']");
            Global.ConsoleOutTab("Open Popup - New Property");
            // Client - Popup
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "csClientId");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "csClientId", clientid);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnRedraw");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnRedraw");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img");
            Global.ConsoleOutTab("Popup closing");
            // Switch back to main window - Asset Manager Popup
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
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
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
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
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.iFrame(driver, "externalSite");
            Global.StreetAddress = (Global.streetnumber + " " + streetname);
            Global.ConsoleOutTab("Street Address: " + Global.StreetAddress);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "paPropAddr");
            Global.StreetAddress = (Global.streetnumber + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
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
            Global.ConsoleOutTab("Open Popup - Attorney");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'Just']");
            // Switch back to main window 
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
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
            SeleniumGetMethods.IsPresent(Driver.driver1, ElementType.Id, "#InputForm > table > tbody > tr > td > table > tbody > tr:nth-child(3) > td");
            if (Global.IsPresent == true)
            {
                SeleniumSetMethods.Wait(driver, ElementType.Name, "btnAdd");
                SeleniumSetMethods.Click(driver, ElementType.Name, "btnAdd");
            }
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)");
            string PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();
            Global.PropertyID = PropertyID;
            Global.ConsoleOut("Property ID: " + PropertyID); ;
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            // SeleniumWindowMethods.ScreenShot(driver, "REO New Property");

        }

        public static void AddAgent(Driver driver, string propertyid, string agentid)
        {
            GotoPropertyId(driver, propertyid);
            Global.ConsoleOutTab("Adding Agent");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_POP_AGENTNB1']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_POP_AGENTNB1']");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.iFrame(driver, "imsb-iframe");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "apsAgentId");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "apsAgentId");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "apsAgentId", agentid);
            SeleniumSetMethods.Clear(driver, ElementType.Name, "apsZip");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".btnGreen");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnAssign_" + agentid);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnAssign_" + agentid);
            SeleniumWindowMethods.Sleep(2);
            try
            {
                SeleniumWindowMethods.Assertion(driver, Alert.Accept);
                Global.ConsoleOutTab("Alert displayed- Agent Verification required");
            }
            catch
            {
                Global.ConsoleOutAlert("NO AGENT VERIFICATION AlERT DISPLAYED");

            }
            Global.ConsoleOut("Agent Assigned");
            Global.ConsoleOut("Window Title:" + PropertiesCollection.driver.Title);

        }

        public static void PreMarket(Driver driver, string propertyid)
        {
            //Pre Marketing Tab
            GotoPropertyId(driver, propertyid);
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

        public static void PropertySerach(Driver driver, string PropertyID)
        {
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Properties");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "pfPropID");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pfPropID", PropertyID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchProp");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "tr.colorRow > td > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "tr.colorRow > td > a");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "address");
            // Global.ConsoleOut("Property address :" + SeleniumGetMethods.GetTextContent(ElementType.Id, "address"));
            Global.ConsoleOut("PropertyID is: " + SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)"));

        }

        public static void PropertySaveSearch(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Properties");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnResetFilters");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "pfCid");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pfCid", "7224");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "pfStatus", "PreMarketing");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pfZipCode", "92620");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "savedFilterName", "Auto" + DateTime.Now.ToString("MMddyy"));
            PropSaveFilterName = SeleniumGetMethods.GetTextValue(driver, ElementType.Id, "savedFilterName");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "saveFilter");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchProp");
            SeleniumWindowMethods.Sleep(1);
            PropResults = SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "results");
            Global.ConsoleOut("Property search results: " + SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "results"));

        }

        // Open Save search 
        public static void OpensaveSearch(Driver driver, string tabname, string filtername)
        {
            // works for property tab and task tab 
            // Search button in approvael is filter properties; filter in offer - need to figure out how to generalized the query
            SeleniumSetMethods.Click(driver, ElementType.LinkText, tabname);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, filtername);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, filtername);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnFilterTask");

        }

        public static void AMOccupancyStatusTask(Driver driver)
        {
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AM_PROPTASKS:']");
            Global.ConsoleOut("Window: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Occupancy Status Request");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "osCurChkDt");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//input[@name='btnUpdate' and @value='Update as Done']");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Eviction");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Eviction");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "VacantDate");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Eviction");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "VacantDate");
            SeleniumGetMethods.DisplayTextValue(driver, ElementType.Id, "VacantDate", "Vacant date updated in Eviction tab");
            String Propstatus = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(5) > td:nth-child(2)");
            Global.ConsoleOut("Property status is : " + Propstatus);

        }

        // Adding Listing Price and updating it for client with no Approval ID
        public static void AMListing2(Driver driver)
        {
            // To update list price for property without approval engine
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Listing");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Listing");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "pmNewLP");
            string Listprice = "500000";
            int i = 0;
            while (i > 2)
            {
                i = i + 1;
                SeleniumSetMethods.EnterText(driver, ElementType.Name, "pmNewLP", Listprice);
                SeleniumSetMethods.Click(driver, ElementType.CssName, "div.status-panel:nth-child(2) > input:nth-child(2)");
                SeleniumWindowMethods.Sleep(1);
                SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");
                SeleniumWindowMethods.Sleep(1);
                SeleniumWindowMethods.Sleep(2);
                Global.ConsoleOut("Listing profile updates");
                Global.ConsoleOut("Original List price:" + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "plOrigLp"));
                Global.ConsoleOut("Current List price:" + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "plCurLp"));
                Global.ConsoleOut("List Date " + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "plListDt"));
                Global.ConsoleOut("Expire Date:" + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "plExpDt"));
                Global.ConsoleOut("Reduced Date:" + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "plLpRedDt"));

                Listprice = "495000";

            }

            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".form > li:nth-child(4) > div:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".form > li:nth-child(4) > div:nth-child(1)");
            SeleniumWindowMethods.ScreenShot(driver, "Approval History_" + Global.PropertyID);

        }

        public static void AMAcceptOffer2(Driver driver, int OfferNum)
        {
            // Offer approval for client Id NOT associated with Approval engine. For example Client ID 7225

            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            Global.ConsoleOut("Window: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "omApplyCtr" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.Name, "omApplyCtr" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//a[contains(text(),'Copy')])[" + OfferNum + "]");
            Global.ConsoleOut("Countering offer# " + SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "ofrNumber"));
            SeleniumSetMethods.Wait(driver, ElementType.Id, "omClosingCosts");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "omClosingCosts");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "omClosingCosts", "3000");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtomComments");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtomComments", "AM Enter comments & increased the closing cost to $3000.00 ");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnCounter");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "releaseCounter_" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.Id, "releaseCounter_" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//a[contains(text(),'Accept')])[" + OfferNum + "]");
            SeleniumWindowMethods.ScreenShot(driver, "AcceptOffer" + Global.PropertyID);

        }

        // For the AssetManager to accept the offer with approval engine - three steps(AMAcceptOffer_Counter,AMAcceptOffer_Approved,AMAcceptOffer_Done) should be completed
        // Offer approval for client Id associated with Approval engine. For example Client ID 7224

        public static void AMAcceptOffer_Counter(Driver driver, int OfferNum)
        {

            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            Global.ConsoleOut("Window: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "omApplyCtr" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.Name, "omApplyCtr" + OfferNum);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//a[contains(text(),'Copy')])[" + OfferNum + "]");
            Global.ConsoleOut("Countering offer# " + SeleniumGetMethods.GetTextContent(driver, ElementType.Id, "ofrNumber"));
            SeleniumSetMethods.Wait(driver, ElementType.Id, "omClosingCosts");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "omClosingCosts");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "omClosingCosts", "3000");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtomComments");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtomComments", "AM Enter comments & increased the closing cost to $3000.00 ");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".section-counter-offer-actions>input:nth-child(2)");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnCounter");
            SeleniumWindowMethods.Sleep(1);

        }

        public static void AMAcceptOffer_Approved(Driver driver, int OfferNum)
        {
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            Global.ConsoleOut("Window: " + PropertiesCollection.driver.Title);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ("#ofra" + OfferNum + " > td:nth-child(2) > a:nth-child(6)"));
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ("#ofra" + OfferNum + " > td:nth-child(2) > a:nth-child(6)"));
            SeleniumSetMethods.Wait(driver, ElementType.Name, "rbStatNew");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "rbStatNew", "Approved");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtapoNote", "Am Approved Offer");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Offers Tab");
            SeleniumWindowMethods.Sleep(1);

        }

        public static void AMAcceptOffer_Done(Driver driver, int OfferNum)
        {
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPOFRHIST:']");
            Global.ConsoleOut("Window: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ("#ofra" + OfferNum + " > td:nth-child(2) > a:nth-child(6)"));
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ("#ofra" + OfferNum + " > td:nth-child(2) > a:nth-child(6)"));
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "txtapoNote");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "rbStatNew", "Done");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtapoNote", "Am Updated as Done");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdApvRequest");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Offers Tab");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ("#ctra" + OfferNum + " > td:nth-child(2) > a:nth-child(4)"));
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ("#ctra" + OfferNum + " > td:nth-child(2) > a:nth-child(4)"));
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "AcceptOffer" + Global.PropertyID);
            SeleniumWindowMethods.Sleep(1);

        }

        public static void CancelReoTask(Driver driver, string TaskName, string displayname)
        {
            // Cancelling the REo task (update as Canceled)
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AM_PROPTASKS:']");

            int tries = 0;
            bool Istaskpresent = false;
            while (Istaskpresent == false)
            {
                try
                {
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Element: " + TaskName + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, TaskName);
                    SeleniumSetMethods.Find(driver, ElementType.PartialLinkText, TaskName, displayname);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, TaskName);
                    Global.ConsoleOut("Task found: " + TaskName);
                    SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
                    SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
                    break;
                }
                catch
                {
                    Global.ConsoleOut("Task not found: " + TaskName);
                    SeleniumWindowMethods.Sleep(1);
                }

                if (tries == 2)
                {
                    Global.ConsoleOut(TaskName + " not found and " + tries + " maxmium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void OpenTaskReo(Driver driver, string propertyid, string TaskName)
        {
            GotoPropertyId(driver, propertyid);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AM_PROPTASKS:']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "note_id");

            int tries = 0;
            bool IsTaskPresent = false;
            while (IsTaskPresent == false)
            {
                try
                {

                    SeleniumWindowMethods.Sleep(5);
                    // SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AM_PROPTASKS:']");
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Task " + TaskName + ":" + tries + " Attempt(s)");
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, TaskName);
                    Global.ConsoleOut("Task: " + TaskName + " Found");
                    IsTaskPresent = true;
                    break;
                }
                catch (Exception)
                {
                    Global.ConsoleOut(TaskName + " not present");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AM_PROPTASKS:']");

                }
                if (tries == 3)
                {
                    Global.ConsoleOut(TaskName + " not found and " + tries + " maximum attempts has been reached");
                    break; // handle error and break/return

                }

            }

        }

    }

}