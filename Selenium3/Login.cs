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

        public static void REO(ENV environment, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-reo2.res.net/");
                    if (environment == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-reo2.res.net/");
                    if (environment == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-reo2.res.net/");
                    if (environment == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://reo2.res.net/");

                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "amLoginId");
                    SeleniumSetMethods.Clear(ElementType.Id, "amLoginId");
                    SeleniumSetMethods.EnterText(ElementType.Id, "amLoginId", username);
                    SeleniumSetMethods.Clear(ElementType.Name, "amIdentity");
                    SeleniumSetMethods.EnterText(ElementType.Name, "amIdentity", password);
                    SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void Agent(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "propertySrchTxt";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-agent.res.net/");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-agent.res.net/");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-agent.res.net/");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://agent.res.net/");
                    
                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "username");
                    SeleniumSetMethods.Clear(ElementType.Id, "username");
                    SeleniumSetMethods.EnterText(ElementType.Id, "username", username);
                    SeleniumSetMethods.Clear(ElementType.Id, "password");
                    SeleniumSetMethods.EnterText(ElementType.Id, "password", password);
                    SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void ValPortal(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "searchBar";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("http://qa-valuation.res.net/");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("http://uat-valuation.res.net/");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("http://stg-valuation.res.net/");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("http://valuation.res.net/");

                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
                    SeleniumSetMethods.Clear(ElementType.Id, "usernameEmail");
                    SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", username);
                    SeleniumSetMethods.Clear(ElementType.Id, "password");
                    SeleniumSetMethods.EnterText(ElementType.Id, "password", password);
                    SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void PropertyCure(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-vendor.res.net/");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-propertycure.res.net/");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-propertycure.res.net/");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://propertycure.res.net/");

                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(ElementType.Name, "UserPassword");
                    SeleniumSetMethods.EnterText(ElementType.Name, "UserPassword", password);
                    SeleniumSetMethods.Click(ElementType.Id, "btnLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void Vendor(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-vendor.res.net/");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-vendor.res.net/");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-vendor.res.net/");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://vendor.res.net/");

                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(ElementType.Name, "UserPassword");
                    SeleniumSetMethods.EnterText(ElementType.Name, "UserPassword", password);
                    SeleniumSetMethods.Click(ElementType.Id, "btnLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void LossMit(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-shortsale.res.net");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-shortsale.res.net");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-shortsale.res.net");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://shortsale.res.net");

                    // Login Page
                    SeleniumSetMethods.Wait(ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(ElementType.Name, "UserPassword");
                    SeleniumSetMethods.EnterText(ElementType.Name, "UserPassword", password);
                    SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void Buyer(ENV portal, string username, string password)
        {
            int tries = 0;
            bool IsElementPresent = false;
            string element = "logoBP";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                        SeleniumSetMethods.Navigate("https://qa-buyer.res.net/login");
                    if (portal == ENV.UAT)
                        SeleniumSetMethods.Navigate("https://uat-buyer.res.net/login");
                    if (portal == ENV.STG)
                        SeleniumSetMethods.Navigate("https://stg-buyer.res.net/login");
                    if (portal == ENV.PROD)
                        SeleniumSetMethods.Navigate("https://buyer.res.net/login");

                    // Login Pages
                    SeleniumSetMethods.Wait(ElementType.Id, "UsernameOrEmail");
                    SeleniumSetMethods.Clear(ElementType.Id, "UsernameOrEmail");
                    SeleniumSetMethods.EnterText(ElementType.Id, "UsernameOrEmail", username);
                    SeleniumSetMethods.Clear(ElementType.Name, "PasswordLogin");
                    SeleniumSetMethods.EnterText(ElementType.Name, "PasswordLogin", password);
                    SeleniumSetMethods.Click(ElementType.Id, "submitForm");

                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    Global.ConsoleOut("Searching for : " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(ElementType.Id, element);
                    SeleniumSetMethods.Find(ElementType.Id, element);
                    Global.ConsoleOut("Element found: " + element);
                    IsElementPresent = true;
                    break;
                }

                catch
                {
                    Global.ConsoleOut("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(ActType.Close);
                    SeleniumWindowMethods.Sleep(2);
                    Global.ReadySetGo();

                }

                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

    }

}