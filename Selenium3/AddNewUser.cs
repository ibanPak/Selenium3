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
    class AddNewUser
    {

        public static void ProPlusAgent(Driver driver, CreditCardType cardType)
        {
            Global.ConsoleOut("Add New User: Agent Portal (Pro+ Agent): " + DateTime.Now.ToString());
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Navigate(driver, "https://qa-agent.res.net/");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/registration/AccountStep']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/registration/AccountStep']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Auto");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", "Mated");
            SeleniumSetMethods.Click(driver, ElementType.Id, "Phone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Phone", "9491234567");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", "Automated" + Global.StreetNum + "@email.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", "blue123");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ConfirmPassword", "blue123");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#wrapperProPlusTier > div.wrapper-tier-box-content > input");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#wrapperProPlusTier > div.wrapper-tier-box-content > input");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CreditCardType_CodeId");
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
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CreditCardType_CodeId", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CreditCardNumber", TestCreditCard.GetCardTestNumber(cardType));
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CvvCode", "111");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ExpirationMonth", "01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ExpirationYear", DateTime.Today.AddYears(2).ToString("yyyy"));
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Automated");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", cctype);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingAddress", "100 Main St.");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SelectedBillingState", "California");
            SeleniumSetMethods.Click(driver, ElementType.Id, "BillingZip");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingZip", "92620");
            SeleniumSetMethods.Click(driver, ElementType.Id, "saveButton");
            SeleniumWindowMethods.Sleep(3);
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#main > div > div:nth-child(1) > div > p:nth-child(2)", "Welcome Message");
            SeleniumWindowMethods.ScreenShot(driver, "New User");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Dashboard']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Dashboard']");

        }

    }

}