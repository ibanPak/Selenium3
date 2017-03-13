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

        public static void AddNewProperty(string PropSTName, string PropCity, string PropState, string PropZipCode)
        {
            // Add new property using variables
            SeleniumSetMethods.Wait(ElementType.XPath, "//div[@id='dtPropSearch_wrapper']/div/div[2]/div/a[3]/span");
            SeleniumSetMethods.Click(ElementType.XPath, "//div[@id='dtPropSearch_wrapper']/div/div[2]/div/a[3]/span");
            SeleniumSetMethods.Wait(ElementType.Id, "PropertyStreet1");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyStreet1", Global.StreetNum + " " + PropSTName);
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyCity", PropCity);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyStateLkUp", PropState);
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyZip", PropZipCode);
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "Client01");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[15]");

        }

        public static void Sample()
        {
            SeleniumSetMethods.Wait(ElementType.Id, "Filters_PropertyId");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyId", "212313");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_LoanNumber", Global.LoanNum);
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_LoanStatusLkUp > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.grid-col:nth-child(1) > div:nth-child(3) > div:nth-child(3) > label:nth-child(5) > input:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.Id, "topPane");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_ClientId > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.grid-col:nth-child(2) > div:nth-child(1) > div:nth-child(3) > label:nth-child(1) > input:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.Id, "topPane");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_OccupiedLkUp_192");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_LitigationLegalLkUp_98");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_AcquisitionDateFrom", Global.LastYear);
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_AcquisitionDateTo", Global.LastMonth);
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyCity", "Irvine");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyCity", "");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_LoanStatusLkUp > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "input.selectAll");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-2");

        }

    }

}
