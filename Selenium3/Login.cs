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
            string url = Global.reoportal;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void Agent(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Agent Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.agentportal;
            ElementType elementtype = ElementType.Id;
            string element = "propertySrchTxt";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void ValPortal(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Val Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url =  Global.valportal;
            ElementType elementtype = ElementType.Id;
            string element = "searchBar";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else 
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void PropertyCure(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into PropertyCure Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.propertycure;
            ElementType elementtype = ElementType.Id;
            string element = "searchBar";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void Vendor(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Vendor Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.vendorportal;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void LossMit(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into LossMit Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.lossmitportal;
            ElementType elementtype = ElementType.Id;
            string element = "globalPropertySearch";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void Buyer(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Buyer Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.buyerportal;
            ElementType elementtype = ElementType.Id;
            string element = "logoBP";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
                    }
                    // Login Page
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

        public static void ValClient(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Val Client Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.valclientportal;
            ElementType elementtype = ElementType.Id;
            string element = "Filter_LoanNumber";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
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

        public static void Homeowner(Driver driver, ENV environment, string username, string password)
        {
            Global.ConsoleOut("Logging into Buyer Portal: " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            string url = Global.homeownerportal;
            ElementType elementtype = ElementType.CssSelector;
            string element = "a[href *= '/Property/Index/']";
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Navigate to the correct environment
                    if (environment == ENV.PROD)
                    {
                        SeleniumSetMethods.Navigate(driver, "https://" + url);
                    }
                    else if (environment == ENV.BUILD)
                    {
                        SeleniumSetMethods.Navigate(driver, Global.buildenv);
                    }
                    else
                    {
                        SeleniumSetMethods.Navigate(driver, "http://" + environment.ToString() + "-" + url);
                    }
                    // Login Page
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