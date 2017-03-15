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
    class Login
    {

        public static void qaAgent(string username, string password)
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("https://qa-agent.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "username");
            SeleniumSetMethods.EnterText(ElementType.Id, "username", username);
            SeleniumSetMethods.EnterText(ElementType.Id, "password", password);
            SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

        }

        public static void qaValPortal(string username, string password)
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://qa-valuation.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", username);
            SeleniumSetMethods.EnterText(ElementType.Id, "password", password);
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");

        }

        public static void uatValPortal(string username, string password)
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://uat-valuation.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", username);
            SeleniumSetMethods.EnterText(ElementType.Id, "password", password);
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");

        }

        public static void qaREO(string username, string password)
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("https://qa-reo2.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "amLoginId");
            SeleniumSetMethods.EnterText(ElementType.Id, "amLoginId", username);
            SeleniumSetMethods.EnterText(ElementType.Name, "amIdentity", password);
            SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

        }

        public static void qaBuyer(string username, string password)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate("https://qa-buyer.res.net/login");

            // Login Pages
            SeleniumSetMethods.Wait(ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "UsernameOrEmail", username);
            SeleniumSetMethods.EnterText(ElementType.Name, "PasswordLogin", password);
            SeleniumSetMethods.Click(ElementType.Id, "submitForm");

        }

        public static void uatVendor(string username, string password)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate("https://uat-vendor.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "Username");
            SeleniumSetMethods.EnterText(ElementType.Id, "Username", username);
            SeleniumSetMethods.EnterText(ElementType.Name, "UserPassword", password);
            SeleniumSetMethods.Click(ElementType.Id, "btnLogin");

        }

        public static void qaVendor(string username, string password)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate("https://qa-vendor.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "Username");
            SeleniumSetMethods.EnterText(ElementType.Id, "Username", username);
            SeleniumSetMethods.EnterText(ElementType.Name, "UserPassword", password);
            SeleniumSetMethods.Click(ElementType.Id, "btnLogin");

        }

        public static void qaPropertyCure(string username, string password)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate("https://qa-propertycure.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "User");
            SeleniumSetMethods.EnterText(ElementType.Id, "User", username);
            SeleniumSetMethods.EnterText(ElementType.Name, "Pass", password);
            SeleniumSetMethods.Click(ElementType.XPath, "//input[@value='Log in']");

        }


    }


}