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

        public static void CreateNewOrderU53()
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
            Global.StreetAddress = Global.StreetNum + " Roosevelt";
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

            // Assign Provider   
            SeleniumSetMethods.Wait(ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumSetMethods.Click(ElementType.CssSelector, "img.lookupPopupIcon");
            SeleniumSetMethods.Wait(ElementType.Id, "Filters_Radius");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "Filters_Radius", "50+");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_ProviderHasLocationZip");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_SourceId", "250922");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchProviderAssignment");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Select");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Select");
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.Assertion(Alert.Accept);

        }

        public static void TestCode()
        {
            Login.qaValPortal();

            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "28959");
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();
            Global.ConsoleOut("Order ID: " + OrderID);
            Global.OrderID = OrderID;

            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Logout");
            SeleniumWindowMethods.Sleep(2);


        }


    }


}