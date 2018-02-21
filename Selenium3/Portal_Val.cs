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
    class Portal_Val
    {

        public static void GotoOrder(Driver driver, string orderid)
        {
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Orders");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Orders");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Filters_OrderId", orderid);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, orderid);
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, orderid);

        }

        public static void ManualProviderAssign(Driver driver, string orderid, string sourceid)
        {
            // Provider Assign
            Global.ConsoleOut("Manual Assign Provider: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsSuccessful = false;
            while (IsSuccessful == false)
            {
                try
                {
                    tries = tries + 1;
                    GotoOrder(driver, orderid);
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "img.lookupPopupIcon");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img.lookupPopupIcon");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "Filters_SourceId");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Filters_SourceId", sourceid);  // Assign your provider
                    SeleniumSetMethods.Click(driver, ElementType.Id, "Filters_ProviderHasLocationZip");
                    SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Filters_PayableStatus", "All");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Filters_Radius");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Filters_Radius", "50000");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchProviderAssignment");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchProviderAssignment");
                    SeleniumWindowMethods.Sleep(5);
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "td.actions > a:nth-child(1)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "td.actions > a:nth-child(1)");
                    SeleniumWindowMethods.Sleep(5);
                    SeleniumWindowMethods.Assertion(driver, Alert.Accept);
                    SeleniumWindowMethods.Sleep(3);
                    IsSuccessful = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOut("Manual Assignment is not successful: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    PropertiesCollection.driver.Navigate().Refresh();
                }
                if (tries == 5)
                {
                    Global.ConsoleOut("Manual Assignment was not successful, " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void CreateNewAppraisal(Driver driver, string clientid, string producttype, string productdetails, string streetnumber, string streetname, string city, string fullstate, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }

            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            Global.ConsoleOut("Create New Appraisal: " + DateTime.Now.ToString());
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", clientid);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", producttype);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", productdetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Purpose", "New Loan Purchase");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "LoanType", "Conv");
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", fullstate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", zipcode);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(driver, ElementType.CssName, "img.lookupPopupIcon");
            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "Acme Appraisal");

        }

        public static void CreateNEWPNMAC(Driver driver, string clientid, string producttype, string productdetails, string streetnumber, string streetname, string city, string fullstate, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }

            // Order Queue Page
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            // Add New Order
            Global.ConsoleOut("Create New PNMAC Order: " + DateTime.Now.ToString());
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", clientid);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", producttype);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", productdetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", fullstate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", zipcode);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(driver, ElementType.CssName, "img.lookupPopupIcon");
            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "PNMAC BPO");

        }

        public static void CreateNewRentalAnalysis(Driver driver, string clientid, string producttype, string productdetails, string streetnumber, string streetname, string city, string fullstate, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }
           
            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            // Add New Order
            Global.ConsoleOut("Create New Rental Analysis Order: " + DateTime.Now.ToString());
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", clientid);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", producttype);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", productdetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", fullstate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", zipcode);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(driver, ElementType.CssName, "img.lookupPopupIcon");
            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "Rental Analysis");

        }

        public static void CreateNewUnified53(Driver driver, string clientid, string producttype, string productdetails, string streetnumber, string streetname, string city, string fullstate, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }

            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            // Add New Order
            Global.ConsoleOut("Create New Unified 5th 3rd Order: " + DateTime.Now.ToString());
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", clientid);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", producttype);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", productdetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut(Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", fullstate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", zipcode);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(driver, ElementType.CssName, "img.lookupPopupIcon");
            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "U53BPO");

        }

        public static void CreateNewFMBBPO(Driver driver, string clientid, string producttype, string productdetails, string streetnumber, string streetname, string city, string fullstate, string zipcode)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }

            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            // Add New Order
            Global.ConsoleOut("Create New FMB Order: " + DateTime.Now.ToString());
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", clientid);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", producttype);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", productdetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + streetname);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", city);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", fullstate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", zipcode);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.Wait(driver, ElementType.CssName, "img.lookupPopupIcon");
            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);
            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot(driver, "FMB BPO");

        }

        public static void CompleteBPOOrder(Driver driver, string orderid)
        {
            // Order Queue Page
            Random r = new Random();
            int n = 0;
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("Complete: BPO Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Generate PDF");
            SeleniumWindowMethods.Assertion(driver, Alert.Wait);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ui-id-4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ui-id-4");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumWindowMethods.Assertion(driver, Alert.Wait);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(1);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(15);

        }

        public static void CompleteRAOrder(Driver driver, string orderid)
        {
            // Order Queue Page
            Random r = new Random();
            int n = 0;
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("Complete: Rental Analysis Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Generate PDF");
            SeleniumWindowMethods.Assertion(driver, Alert.Wait);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ui-id-4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ui-id-4");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumWindowMethods.Assertion(driver, Alert.Wait);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(1);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(15);

        }

        public static void CompleteAppraisal(Driver driver, string orderid)
        {
            // Order Queue Page
            Random r = new Random();
            int n = 0;
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("Complete: Appraisal Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Audit");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Audit");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumWindowMethods.Assertion(driver, Alert.Wait);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(1);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOutTab("CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(15);

        }

        public static void DisputeOrder(Driver driver, string orderid)
        {
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("Disupte Order");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "lnkDisputeTab");
            SeleniumSetMethods.Click(driver, ElementType.Id, "lnkDisputeTab");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Dispute Order");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Dispute Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "comment");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "comment", "testing");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "ul.chosen-choices");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "ul.chosen-choices");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#Reason_LookupIds_chosen > div > ul > li:nth-child(4)");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmitModal");
            SeleniumWindowMethods.Sleep(1);

        }

        public static void ReturnToProvider(Driver driver, string orderid)
        {
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("Return Order to Provider");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ui-id-4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ui-id-4");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Return to Provider");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Return to Provider");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "selReason", "Incomplete Information");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txaComment", "Testing Return to Provider " + DateTime.Now.ToString());
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(3);

        }

        public static void ViewAssignmentHistory(Driver driver, string orderid)
        {
            GotoOrder(driver, orderid);
            Global.ConsoleOutTab("View Assignment History");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#Content > form > h2");
            string a = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#Content > form > h2");
            int dash = a.IndexOf('-');
            string b = a;
            if (dash != -1)
            {
                b = a.Substring(0, dash).Trim();
            }
            Global.ConsoleOut("Order Type: " + b);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#tabsAssignment > div.panel-footer > div > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#tabsAssignment > div.panel-footer > div > a");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSubmitModal");
            SeleniumWindowMethods.Sleep(1);
            if (b == "Appraisal")
            {
                try
                {
                    string displayme = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr > td:nth-child(9) > a");
                    Global.ConsoleOutTab("Engagement Letter: " + displayme);
                }
                catch (NoSuchElementException)
                {
                    Global.ConsoleOutAlert("Engagement is NOT Present");
                }
            }
            try
            {
                // Assignment History Page
                Global.ConsoleOutTab("Verifying Assignment History Page");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.XPath, "//*[@id=\"ProviderAssignmentHistoryGrid\"]/table/tbody/tr/td[2]/a", "Assiged Date");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr > td:nth-child(3)", "Provider Id");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr > td:nth-child(4)", "Provider Name");
                SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id=\"ProviderAssignmentHistoryGrid\"]/table/tbody/tr/td[2]/a");
                // Order Snapshot History Page
                Global.ConsoleOutTab("Verifying Order Snapshot History Page");
                SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#OrderSnapshot > h4 > small");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#OrderSnapshot > h4 > small", "Snapshot Assigned Date");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#OrderSnapshot > table > tbody > tr:nth-child(2) > td:nth-child(1)", "Order Id");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#OrderSnapshot > table > tbody > tr:nth-child(2) > td:nth-child(2)", "Address");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderDetail > div > table > tbody > tr:nth-child(2) > td:nth-child(1)", "Provider Id");
                SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderDetail > div > table > tbody > tr:nth-child(2) > td:nth-child(2)", "Provider Name");
                // Providers Considers
                try
                {
                    Global.ConsoleOutTab("Verifying Order Snapshot History Page (Providers Considered)");
                    SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr:nth-child(1) > td:nth-child(2)", "Provider Id");
                    SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr:nth-child(1) > td:nth-child(3)", "Invite Date");
                    SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ProviderAssignmentHistoryGrid > table > tbody > tr:nth-child(1) > td:nth-child(4)", "Provider Name");
                }
                catch (NoSuchElementException)
                {
                    Global.ConsoleOutAlert("No Providers Considered");
                }
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert("Assignment date is NOT Present");
            }

        }

    }

}