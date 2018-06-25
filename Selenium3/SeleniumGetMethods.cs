﻿using OpenQA.Selenium;
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
    class SeleniumGetMethods
    {
        public static string GetTextValue(Driver driver, ElementType elementtype, string element)
        {
            try
            {
                // Driver 1
                if (driver == Driver.driver1 && elementtype == ElementType.Id)
                {
                    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
                }
                // Driver 2
                else if (driver == Driver.driver2 && elementtype == ElementType.Id)
                {
                    return PropertiesCollection.driver2.FindElement(By.Id(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver2.FindElement(By.Name(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver2.FindElement(By.CssSelector(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver2.FindElement(By.XPath(element)).GetAttribute("value");
                }
                else return String.Empty;
            }
            catch (NoSuchElementException)
            {
                return String.Empty;
            }

        }

        public static string GetTextContent(Driver driver, ElementType elementtype, string element)
        {
            try
            {
                // Driver 1
                if (driver == Driver.driver1 && elementtype == ElementType.Id)
                {
                    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                // Driver 2
                else if (driver == Driver.driver2 && elementtype == ElementType.Id)
                {
                    return PropertiesCollection.driver2.FindElement(By.Id(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver2.FindElement(By.Name(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver2.FindElement(By.CssSelector(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver2.FindElement(By.XPath(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else return String.Empty;
            }
            catch (NoSuchElementException)
            {
                return String.Empty;
            }

        }

        public static string GetFromDDL(Driver driver, ElementType elementtype, string element)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                return new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                return new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else return String.Empty;

        }

        public static void DisplayTextContent(Driver driver, ElementType elementtype, string element, string text)
        {

            Global.Display = SeleniumGetMethods.GetTextContent(driver, elementtype, element);
            if (Global.Display.Trim().Length >= 1)
            {
                Global.ConsoleOutTab(text + ": " + Global.Display);
            }
            else
            {
                Global.ConsoleOutAlert(text + ": Not Present");
            }

        }

        public static void DisplayTextValue(Driver driver, ElementType elementtype, string element, string text)
        {

            Global.Display = SeleniumGetMethods.GetTextValue(driver, elementtype, element);
            if (Global.Display.Trim().Length >= 1)
            {
                Global.ConsoleOutTab(text + ": " + Global.Display);
            }
            else
            {
                Global.ConsoleOutAlert(text + ": Not Present");
            }

        }

        public static bool IsPresent(Driver driver, ElementType elementtype, string element)
        {

            try
            {
                PropertiesCollection.driver.FindElement(By.Id(element));
                Global.IsPresent = true;
                return true;
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert("Element not present: " + element);

                return false;
            }

        }

        public static void VerifyTextContent(Driver driver, ElementType elementtype, string element, string text)
        {
            Global.Display = SeleniumGetMethods.GetTextContent(driver, elementtype, element);
            if (Global.Display == text)
            {
                Global.ConsoleOutTab(text + " Matched: " + Global.Display);
            }
            else
            {
                Global.ConsoleOutAlert(text + " DID NOT Match: " + Global.Display);
            }

        }

        public static void VerifyTextValue(Driver driver, ElementType elementtype, string element, string text)
        {
            Global.Display = SeleniumGetMethods.GetTextValue(driver, elementtype, element);
            if (Global.Display == text)
            {
                Global.ConsoleOutTab(text + " Matched: " + Global.Display);
            }
            else
            {
                Global.ConsoleOutAlert(text + " VALUE DID NOT MATCH: " + Global.Display);
            }

        }

    }

}
