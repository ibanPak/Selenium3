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

        public static void GotoOrder(Driver driver, string OrderId)
        {
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Orders");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Orders");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Filters_OrderId", OrderId);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, OrderId);
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, OrderId);

        }

        public static void ManualProviderAssign(Driver driver, string orderid, string sourceid)
        {
            // Provider Assign
            GotoOrder(driver, orderid);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Filters_SourceId");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Filters_SourceId", sourceid);  // Assign your provider
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchProviderAssignment");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchProviderAssignment");
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "td.actions > a:nth-child(1)");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "td.actions > a:nth-child(1)");
            SeleniumWindowMethods.Sleep(5);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumWindowMethods.Sleep(3);

        }

        public static void CreateNewAppraisal(Driver driver, string ClientID, string ProductType, string ProductDetails, string StreetName, string City, string FullState, string ZipCode)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", ClientID);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", ProductType);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", ProductDetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Purpose", "New Loan Purchase");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "LoanType", "Conv");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", ZipCode);
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

        public static void CreateNEWPNMAC(Driver driver, string ClientID, string ProductType, string ProductDetails, string StreetName, string City, string FullState, string ZipCode)
        {
            // Order Queue Page
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", ClientID);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", ProductType);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", ProductDetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", ZipCode);
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

        public static void CreateNewRentalAnalysis(Driver driver, string ClientID, string ProductType, string ProductDetails, string StreetName, string City, string FullState, string ZipCode)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", ClientID);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", ProductType);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", ProductDetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", ZipCode);
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

        public static void CreateNewUnified53(Driver driver, string ClientID, string ProductType, string ProductDetails, string StreetName, string City, string FullState, string ZipCode)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", ClientID);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", ProductType);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", ProductDetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", ZipCode);
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

        public static void CreateNewFMBBPO(Driver driver, string ClientID, string ProductType, string ProductDetails, string StreetName, string City, string FullState, string ZipCode)
        {
            // Order Queue Page
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchOrders");

            // Add New Order
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add New Order");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add New Order");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClientId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", ClientID);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumb", Global.LoanNum);
            Global.ConsoleOut("Loan Number: " + Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductType", ProductType);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ProductDetails", ProductDetails);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyType", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatus", "Unknown");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOut("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectPostalCode", ZipCode);
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
            Global.ConsoleOut("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOut("CustomerQualityGradeModal_" + n);
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
            Global.ConsoleOut("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOut("CustomerQualityGradeModal_" + n);
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
            Global.ConsoleOut("CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerServiceGradeModal_" + n);
            n = r.Next(3);
            Global.ConsoleOut("CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomerQualityGradeModal_" + n);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumWindowMethods.Sleep(15);
        
        }

        public static void DisputeOrder(Driver driver, string orderid)
        {
            GotoOrder(driver, orderid);
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

    }

}