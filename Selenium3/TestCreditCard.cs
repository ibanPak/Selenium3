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
    class TestCreditCard
    {

        public static string GetCardTestNumber(CreditCardTypeType cardType)
        {
            switch (cardType)
            {
                case CreditCardTypeType.Amex:
                    return "378282246310005";
                case CreditCardTypeType.Discover:
                    return "6011111111111117";
                case CreditCardTypeType.MasterCard:
                    return "5105105105105100";
                case CreditCardTypeType.Visa:
                    return "4111111111111111";
                default:
                    return null;
            }

        }

        public static void BuyerProfile(Driver driver, CreditCardTypeType cardType)
        {
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Account']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Account']");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#AccountInformationEdit > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#AccountInformationEdit > span");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId");
            Global.ConsoleOutTab(cardType + ": " + GetCardTestNumber(cardType));
            string cctype = "Drop Down Selection";
            if (cardType == CreditCardTypeType.Visa)
            {
                cctype = "Visa";
            }
            else if (cardType == CreditCardTypeType.Amex)
            {
                cctype = "American Express";
            }
            else if (cardType == CreditCardTypeType.MasterCard)
            {
                cctype = "Master Card";
            }
            else if (cardType == CreditCardTypeType.Discover)
            {
                cctype = "Discover";
            }
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId", cctype);
            SeleniumSetMethods.Clear(driver, ElementType.CssSelector, "#billingForm > div > div > div:nth-child(5) > input");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#billingForm > div > div > div:nth-child(5) > input", GetCardTestNumber(cardType));
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "BillingInfo_ExpirationMonth", "01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "BillingInfo_ExpirationYear", DateTime.Today.AddYears(2).ToString("yyyy"));
            SeleniumSetMethods.Clear(driver, ElementType.Id, "BillingInfo_NameOnCard");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_NameOnCard", "Credit Card User");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "BillingInfo_BillingAddress");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingAddress", "100 Main St.");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "BillingInfo_BillingCity");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "BillingInfo_BillingState_Code", "California");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "BillingInfo_BillingZip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingZip", "92620");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSaveBilling");
            SeleniumWindowMethods.Sleep(2);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#billingForm > div > div > div:nth-child(6) > span", "CC Error Message");
            
        }

    }

}