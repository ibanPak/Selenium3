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
using OpenQA.Selenium;

namespace Selenium3
{
    class IfExists
    {
        public static void Link_Back(Driver driver, string element, string displaytext)
        {
            int tries = 0;
            bool IsElementPresent = false;
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Element: " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, element);
                    SeleniumSetMethods.Find(driver, ElementType.PartialLinkText, element, displaytext);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, element);
                    IsElementPresent = true;
                    Global.ConsoleOut("Element present: " + element);
                    break;
                }
                catch
                {
                    Global.ConsoleOut("Element not present: " + element);
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.Back(driver);
                }
                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void Id_Refresh(Driver driver, string element, string displaytext)
        {
            int tries = 0;
            bool IsElementPresent = false;
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Element: " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, ElementType.Id, element);
                    SeleniumSetMethods.Find(driver, ElementType.Id, element, displaytext);
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOut("Element not present: " + element);
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.Refresh(driver);
                }
                if (tries == 15)
                {
                    Global.ConsoleOut(element + " not found and " + tries + " maxium tries has been reached");
                    break; // handle error and break/return
                }

            }

        }

        public static void LoadSuccess(Driver driver, string element, string displaytext)
        {
            int tries = 0;
            bool IsElementPresent = false;
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Element: " + element + " " + tries + " Attempt(s)");
                    SeleniumSetMethods.Wait(driver, ElementType.Id, element);
                    SeleniumSetMethods.Find(driver, ElementType.Id, element, displaytext);
                    IsElementPresent = true;
                    break;
                }
                catch
                {
                    Global.ConsoleOut("Element not present: " + element);
                    SeleniumWindowMethods.Sleep(1);
                    SeleniumWindowMethods.WindowActions(driver, ActType.Close);
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
