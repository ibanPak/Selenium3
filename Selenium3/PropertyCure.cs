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
    class PropertyCure
    {

        public static void AddNewUser(string FirstName, string LastName, string Username, string Email, string Password)
        {
            // Add new User using variables
            SeleniumSetMethods.Wait(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-2");
            SeleniumSetMethods.Click(ElementType.XPath, "//div[@id='dtUserSearch_wrapper']/div/div[3]/div/a[3]/span");
            SeleniumSetMethods.Wait(ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(ElementType.Id, "FirstName", "Fred");
            SeleniumSetMethods.EnterText(ElementType.Id, "LastName", "Flinstone");
            SeleniumSetMethods.EnterText(ElementType.Id, "UserName", "Bedrock");
            SeleniumSetMethods.EnterText(ElementType.Id, "EmailAddress", "Bedrock@gmail.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "Password", "passwrod1");
            SeleniumSetMethods.Click(ElementType.Id, "Show_Password");
            SeleniumSetMethods.EnterText(ElementType.Id, "PasswordConfirmation", "password1");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "IsActive", "Yes");
            SeleniumSetMethods.Click(ElementType.Id, "UserRoles");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.multiSelectOptions:nth-child(2) > label:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");

        }

        public static void AddNewProperty(string PropSTName, string PropCity, string PropState, string PropZipCode, string Client)
        {
            // Add new property using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.Wait(ElementType.Id, "street_number");
            SeleniumSetMethods.EnterText(ElementType.Id, "street_number", Global.StreetNum+" "+PropSTName);
            SeleniumSetMethods.EnterText(ElementType.Id, "locality", PropCity);
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, PropState);
            SeleniumSetMethods.Click(ElementType.PartialLinkText, PropState);
            SeleniumSetMethods.EnterText(ElementType.Id, "postal_code", PropZipCode);
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, Client);
            SeleniumSetMethods.Click(ElementType.PartialLinkText, Client);
            SeleniumSetMethods.Click(ElementType.Id, "btnPropAdd");

        }

    }

}
