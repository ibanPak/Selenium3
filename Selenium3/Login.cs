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
        public static void REO(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into REO Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-reo2.res.net/");
                    }
                    else if (environment == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-reo2.res.net/");
                    }
                    else if (environment == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-reo2.res.net/");
                    }
                    else if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://reo2.res.net/");
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://reo2.res.net/");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "amLoginId");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "amLoginId");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "amLoginId", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "amIdentity");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "amIdentity", password);
                    SeleniumSetMethods.Click(driver, ElementType.Name, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void Agent(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Agent Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "propertySrchTxt";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-agent.res.net/");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-agent.res.net/");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-agent.res.net/");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://agent.res.net/");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "username");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "username");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "username", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "password");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "password", password);
                    SeleniumSetMethods.Click(driver, ElementType.Name, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void ValPortal(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Val Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "searchBar";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://qa-valuation.res.net/");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://uat-valuation.res.net/");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://stg-valuation.res.net/");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://valuation.res.net/");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "usernameEmail");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "usernameEmail");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "usernameEmail", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "password");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "password", password);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmitLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void PropertyCure(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into PropertyCure Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "searchBar";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-propertycure.res.net/");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-propertycure.res.net/");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-propertycure.res.net/");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://propertycure.res.net/");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "User");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "User");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "User", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "Pass");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "Pass", password);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);

                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void Vendor(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Vendor Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-vendor.res.net/");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-vendor.res.net/");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-vendor.res.net/");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://vendor.res.net/");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "UserPassword");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "UserPassword", password);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void LossMit(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into LossMit Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-shortsale.res.net");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-shortsale.res.net");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-shortsale.res.net");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://shortsale.res.net");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "UserPassword");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "UserPassword", password);
                    SeleniumSetMethods.Click(driver, ElementType.Name, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void Buyer(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Buyer Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "logoBP";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/login");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-buyer.res.net/login");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-buyer.res.net/login");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://buyer.res.net/login");
                    }
                    // Login Pages
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "UsernameOrEmail");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "UsernameOrEmail");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "UsernameOrEmail", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "PasswordLogin");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "PasswordLogin", password);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "submitForm");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void ValClient(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Val Client Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.Id;
            string element = "Filter_LoanNumber";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://qa-client.usres.com/Authentication/LogOn");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://uat-client.usres.com/Authentication/LogOn");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://stg-client.usres.com/Authentication/LogOn");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "http://client.usres.com/Authentication/LogOn");
                    }
                    // Login Page
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Password");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", password);
                    SeleniumSetMethods.Click(driver, ElementType.Name, "btnLogin");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

        public static void Homeowner(Driver driver, ENV portal, string username, string password)
        {
            Global.ConsoleOut("Logging into Buyer Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            ElementType elementtype = ElementType.CssSelector;
            string element = "a[href *= '/Property/Index/']";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (portal == ENV.QA)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://qa-homeowner.res.net/Authentication/LogOn");
                    }
                    else if (portal == ENV.UAT)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://uat-homeowner.res.net/Authentication/LogOn");
                    }
                    else if (portal == ENV.STG)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://stg-homeowner.res.net/Authentication/LogOn");
                    }
                    else if (portal == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://homeowner.res.net/Authentication/LogOn");
                    }
                    // Login Pages
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.Clear(driver, ElementType.Id, "Username");
                    SeleniumSetMethods.EnterText(driver, ElementType.Id, "Username", username);
                    SeleniumSetMethods.Clear(driver, ElementType.Name, "Password");
                    SeleniumSetMethods.EnterText(driver, ElementType.Name, "Password", password);
                    SeleniumSetMethods.Click(driver, ElementType.Id, "submitLogon");
                    // Check for successful page load
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    Global.ConsoleOutTab("Searching for : " + elementtype + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, elementtype, element);
                    SeleniumSetMethods.Find(driver, elementtype, element, "Login Successful");
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOutAlert("Element not present: " + element + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return

                }

            }

        }

    }

}