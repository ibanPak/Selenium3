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
    class Logout
    {
        public static void Portal(Driver driver, Portals portals)
        {
            Global.ConsoleOut("Logging out " + portals + ": " + DateTime.Now.ToString());
            int tries = 0;
            bool IsElementPresent = false;
            while (IsElementPresent == false)
            {
                try
                {
                    // Check to see if Logout WebElement is Present
                    tries = tries + 1;
                    if (portals == Portals.ValPortal)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
                    }
                    else if (portals == Portals.Agent)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Logout");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Logout");
                    }
                    else if (portals == Portals.Vendor)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Authentication/Logout']");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Authentication/Logout']");
                    }
                    else if (portals == Portals.REO)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");
                    }
                    else if (portals == Portals.PropertyCure)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "i.fa.fa-caret-down");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "i.fa.fa-caret-down");
                        SeleniumSetMethods.Click(driver, ElementType.Id, "btnLogout");
                    }
                    else if (portals == Portals.Buyer)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.Id, "lnkLogout");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.Id, "lnkLogout");
                        SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[8]/div[3]/div/button[1]");
                        SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[8]/div[3]/div/button[1]");
                        
                    }
                    IsElementPresent = true;
                    Global.ConsoleOutTab("Logout was successful: " + portals);
                }
                catch
                {
                    Global.ConsoleOutAlert("Logout was NOT successful: " + portals + " not found, " + tries + " attempted");
                    SeleniumWindowMethods.Sleep(3);
                }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert("Logout was NOT successful: " + portals + " not found, and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

    }

}
