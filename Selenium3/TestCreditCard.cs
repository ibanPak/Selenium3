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

        public static string GetCardTestNumber(CreditCardType cardType)
        {
            switch (cardType)
            {
                case CreditCardType.Amex:
                    return "378282246310005";
                case CreditCardType.Discover:
                    return "6011111111111117";
                case CreditCardType.MasterCard1:
                    return "2223000048400011";
                case CreditCardType.MasterCard2:
                    return "5105105105105100";
                case CreditCardType.Visa:
                    return "4111111111111111";
                default:
                    return null;
            }

        }

        public static void BuyerProfile(Driver driver, CreditCardType cardType)
        {
            Global.ConsoleOut("Test Credit Card: Buyer Profile: " + DateTime.Now.ToString());
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Account']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Account']");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#AccountInformationEdit > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#AccountInformationEdit > span");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId");
            Global.ConsoleOutTab(cardType + ": " + GetCardTestNumber(cardType));
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
                cctype = "Master Card";
            }
            else if (cardType == CreditCardType.MasterCard2)
            {
                cctype = "Master Card";
            }
            else if (cardType == CreditCardType.Discover)
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

        public static void AgentProfile(Driver driver, CreditCardType cardType)
        {
            Global.ConsoleOut("Test Credit Card: Agent Profile: " + DateTime.Now.ToString());
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertySrchTxt");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.MouseOver(driver, ElementType.Id, "agentId");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/AgentProfile']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/AgentProfile']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Profile_LicenseExpDate");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Profile_LicenseExpDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Profile_LicenseExpDate", Global.NextYear);
            Global.ConsoleOutTab(cardType + ": " + GetCardTestNumber(cardType));
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
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "creditcarddata_CreditCardType", cctype);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "creditcarddata_CreditCardNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "creditcarddata_CreditCardNumber", GetCardTestNumber(cardType));
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "creditcarddata_ExpirationMonth", "01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "creditcarddata_ExpirationYear", DateTime.Today.AddYears(2).ToString("yyyy"));
            SeleniumSetMethods.Clear(driver, ElementType.Id, "creditcarddata_NameOnCard");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "creditcarddata_NameOnCard", "Credit Card User");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "creditcarddata_BillingAddress_Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "creditcarddata_BillingAddress_Address", "100 Main St.");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "creditcarddata_BillingAddress_City");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "creditcarddata_BillingAddress_City", "Irvine");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "creditcarddata_BillingAddress_State_Code", "California");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "creditcarddata_BillingAddress_FullZip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "creditcarddata_BillingAddress_FullZip", "92620");
            SeleniumSetMethods.Click(driver, ElementType.Id, "saveButton");
            SeleniumWindowMethods.Sleep(2);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.XPath, "//*[@id=\"BillingInfoDiv\"]/div[3]/div[1]/div", "CC Error Message");
         
        }

    }

}