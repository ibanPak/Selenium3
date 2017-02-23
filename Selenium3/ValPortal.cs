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
    class ValPortal
    {

        public static void ManualProviderAssign(string sourceid)
        {
            // Provider Assign
            SeleniumSetMethods.Wait(ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumSetMethods.Click(ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumSetMethods.Wait(ElementType.Id, "Filters_Radius");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "Filters_Radius", "50+");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_ProviderHasLocationZip");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_SourceId", sourceid);  // Assign your provider
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchProviderAssignment");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#ProviderAssignmentTGrid > table:nth-child(1) > tbody:nth-child(3) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#ProviderAssignmentTGrid > table:nth-child(1) > tbody:nth-child(3) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.Assertion(Alert.Accept);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");

        }

        public static void CreateNewAppraisal(string StreetName)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "acme");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductType", "Appraisal");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductDetails", "2055 Exterior Residential");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "Purpose", "New Loan Purchase");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(ElementType.Id, "Portfolio", "Automated");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "LoanType", "Conv");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SubjectState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectPostalCode", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(ElementType.CssName, "img.lookupPopupIcon");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("Acme Appraisal");

        }

        public static void CreateNEWPNMAC(string StreetName)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "PNMAC");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductType", "BPO");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductDetails", "Exterior");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SubjectState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectPostalCode", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(ElementType.CssName, "img.lookupPopupIcon");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("PNMAC BPO");

        }


        public static void CreateNewRentalAnalysis(string StreetName)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "Beatrice Rental Survey Co");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductType", "Rental Analysis");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductDetails", "Rental Analysis Exterior");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SubjectState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectPostalCode", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(ElementType.CssName, "img.lookupPopupIcon");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("Rental Analysis");
            
        }

        public static void CreateNewOrderU53(string StreetName)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "Unified 53");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductType", "BPO");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductDetails", "Broker Price Opinion Exterior Inspection");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SubjectState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectPostalCode", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(ElementType.CssName, "img.lookupPopupIcon");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("U53BPO");

        }

        public static void CompleteU53Order()
        {
         
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, Global.OrderID);
            SeleniumSetMethods.Wait(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.AlertWait();
            SeleniumWindowMethods.Assertion(Alert.Accept);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Logout");


        }

        public static void CompleteRAOrder()
        {

            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, Global.OrderID);
            SeleniumSetMethods.Wait(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Generate PDF");
            SeleniumSetMethods.AlertWait();
            SeleniumWindowMethods.Assertion(Alert.Accept);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Logout");


        }

        public static void CompleteAppraisal()
        {

            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, Global.OrderID);
            SeleniumSetMethods.Wait(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderDetailMainUpdate");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Audit");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Audit");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumSetMethods.Click(ElementType.Id, "btnTabsAuditSendToClient");
            SeleniumSetMethods.AlertWait();
            SeleniumWindowMethods.Assertion(Alert.Accept);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "CustomerServiceGradeModal_0");
            SeleniumSetMethods.Click(ElementType.Id, "CustomerServiceGradeModal_0");
            SeleniumSetMethods.Wait(ElementType.Id, "CustomerQualityGradeModal_0");
            SeleniumSetMethods.Click(ElementType.Id, "CustomerQualityGradeModal_0");
            SeleniumSetMethods.Wait(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(15);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Logout");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Logout");


        }

        public static void CreateNewFMBBPO(string StreetName)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "New Chase");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductType", "BPO");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ProductDetails", "Exterior");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SubjectState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubjectPostalCode", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerName", "Hello Kitty");
            SeleniumSetMethods.EnterText(ElementType.Id, "BorrowerPhone", "9493335432");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "TenderTypeCode", "Invoice");
            SeleniumSetMethods.Click(ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(ElementType.CssName, "img.lookupPopupIcon");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.OrderID = OrderID;
            Global.ConsoleOut("Order ID: " + OrderID);

            // Screen Capture
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.ScreenShot("FMB BPO");

        }


    }


}