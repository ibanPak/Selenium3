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
    class Portal_ValClient
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

        public static void CreateNewOrder(Driver driver, ProductTypes producttypes, string products,
            string streetnumber, string StreetName, string City, string FullState, string ZipCode, CreditCardType cardType)
        {
            if (streetnumber == "Random")
            {
                streetnumber = Global.StreetNum;
            }
            else
            {
                Global.StreetNum = streetnumber;
            }
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/CreateOrder/Step1']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/CreateOrder/Step1']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ValuationTypeId");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ValuationTypeId", producttypes.ToString());
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ValuationSubTypeId", products.ToString());
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ValuationPurposeId", "New Loan Purchase ");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "LoanTypeId", "Conv");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PurchaseContractNA");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanAmount", "500000.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Portfolio", "Automated");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ClientFileNumber", "File-" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LockboxCode", Global.UniqueNum);
            Global.StreetAddress = (Global.StreetNum + " " + StreetName);
            Global.ConsoleOutTab("Street Address: " + Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectAddress", Global.StreetAddress);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectCity", City);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SubjectState", FullState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectZip", ZipCode);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyTypeId", "Single Family");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OccupancyStatusId", "Occupied");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerContactName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerContactPhone", "949-333-1234");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BorrowerContactEmail", "Hello@Kitty.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OccupantContactName", "Hello Kitty");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OccupantContactPhone", "949-333-1234");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OccupantContactEmail", "Hello@Kitty.com");
            SeleniumSetMethods.MultiSelect(driver, ElementType.Id, "sbAvailableUsers", "2");
            SeleniumSetMethods.MultiSelect(driver, ElementType.Id, "sbAvailableUsers", "4");
            SeleniumSetMethods.MultiSelect(driver, ElementType.Id, "sbAvailableUsers", "6");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#moveRight");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Comments", "Testing Comments");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOrderSave");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "OrderInfo_TenderType");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OrderInfo_TenderType", "Credit Card");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CreditCardInfo_FirstName");
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
                cctype = "Mastercard";
            }
            else if (cardType == CreditCardType.MasterCard2)
            {
                cctype = "Mastercard";
            }
            else if (cardType == CreditCardType.Discover)
            {
                cctype = "Discover";
            }
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardInfo_FirstName", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardInfo_LastName", "Test");
            //SeleniumSetMethods.EnterText(driver, ElementType.Name, "OrderInfo.PaymentLinkEmail]", "Test");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CreditCardInfo_CardType", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardInfo_CardNumber", TestCreditCard.GetCardTestNumber(cardType));
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardInfo_CvvCode", "111");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CreditCardInfo_ExpiredMonth", "01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CreditCardInfo_ExpiredYear", DateTime.Today.AddYears(2).ToString("yyyy"));
            //  SeleniumSetMethods.Click(driver, ElementType.Id, "btnPlaceOrder");

        }

    }

}