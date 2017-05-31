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

        public static void AddNewProperty(int Stnum, string PropSTName, string PropCity, string PropState, string PropZipCode)
        {
            // Add new property using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.XPath, "//div[@id='dtPropSearch_wrapper']/div/div[3]/div/a[3]/span");
            SeleniumSetMethods.Click(ElementType.XPath, "//div[@id='dtPropSearch_wrapper']/div/div[3]/div/a[3]/span");
            SeleniumSetMethods.Wait(ElementType.Id, "street_number");
            //SeleniumSetMethods.EnterText(ElementType.Id, "street_number", Global.StreetNum + " " + PropSTName);
            SeleniumSetMethods.EnterText(ElementType.Id, "street_number", Stnum + " " + PropSTName);
            SeleniumSetMethods.EnterText(ElementType.Id, "locality", PropCity);
            // SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyStateLkUp", PropState);
            SeleniumSetMethods.EnterText(ElementType.Id, "administrative_area_level_1", PropState);
            SeleniumSetMethods.EnterText(ElementType.Id, "postal_code", PropZipCode);
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "Client01");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[17]");

        }

        public static void Sample()
        {
            
            SeleniumSetMethods.Wait(ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Inspections");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "1");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "1");
            SeleniumSetMethods.Wait(ElementType.Id, "btnExpandAll");
            SeleniumSetMethods.Click(ElementType.Id, "btnExpandAll");
            SeleniumSetMethods.Clear(ElementType.Name, "CurrentPropertyValue");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(ElementType.Name, "CurrentPropertyValue", "300.00");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "searchBar");
            SeleniumSetMethods.EnterText(ElementType.Id, "searchBar", "500");
            SeleniumSetMethods.Wait(ElementType.CssSelector, ".ui-autocomplete");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".ui-autocomplete");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_Filters\\.PropertyStateLkUp");
            SeleniumSetMethods.EnterText(ElementType.XPath, "(//input[@value=''])[9]", "calif");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_Filters\\.PropertyStateLkUp > div:nth-child(3) > p:nth-child(1) > span:nth-child(1) > i:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.XPath, "//div[@id='dtPropSearch_wrapper']/div/div[4]/div/a[3]/span");
            SeleniumSetMethods.Wait(ElementType.Id, "autocomplete");
            SeleniumSetMethods.EnterText(ElementType.Id, "autocomplete", "10");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", "Client01");

        }

        public static void Sample2()
        {

            Login.qaPropertyCure("qatest", "P@ssw0rd1");
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Property");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Property");
            SeleniumWindowMethods.Sleep(2);
            PropertiesCollection.driver.Navigate().Back();
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.LinkText, "Add New Property");
            SeleniumSetMethods.Click(ElementType.LinkText, "Add New Property");
            SeleniumSetMethods.EnterText(ElementType.Id, "street_number", "213 Main St.");
            SeleniumSetMethods.EnterText(ElementType.Id, "locality", "Irvine");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_PropertyStateLkUp");
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "input.search-txt", "California");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_PropertyStateLkUp > div:nth-child(3) > ul:nth-child(1) > li:nth-child(6) > label:nth-child(1)");
            SeleniumSetMethods.EnterText(ElementType.Id, "postal_code", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_VendorId");
            SeleniumSetMethods.EnterText(ElementType.CssSelector, ".valid", "Assurant");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_VendorId > div:nth-child(3) > ul:nth-child(1) > li:nth-child(2) > label:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_ClientId");
            SeleniumSetMethods.Click(ElementType.CssSelector, ".sumo_ClientId > div:nth-child(3) > ul:nth-child(1) > li:nth-child(2) > label:nth-child(1)");
            SeleniumWindowMethods.Sleep(1);
            //    SeleniumSetMethods.Click(ElementType.Id, "btnAddNew");
            /*
                        Login.qaPropertyCure("qatest", "P@ssw0rd1");
                        int Stnum = 2604;
                        int tries = 0;
                        while (tries < 2 )
                        {
                            PropertyCure.AddNewProperty(Stnum, "Washington Rd", "Augusta", "GA", "30904");
                            tries = tries + 1;
                            Stnum = Stnum + 1;
                            Global.LoanNum = DateTime.Now.ToString("MMddHHmmss").TrimStart('0');
                            SeleniumWindowMethods.Sleep(1);
                            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
                            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");

                        }

            */

        }

    }

}
