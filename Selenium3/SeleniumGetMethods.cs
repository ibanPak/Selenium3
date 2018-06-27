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
    class SeleniumGetMethods
    {
        public static string GetTextValue(Driver driver, ElementType elementtype, string element)
        {
            try
            {
                if (driver == Driver.driver1)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver1.FindElement(By.Id(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.Name: return PropertiesCollection.driver1.FindElement(By.Name(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.XPath: return PropertiesCollection.driver1.FindElement(By.XPath(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.CssSelector: return PropertiesCollection.driver1.FindElement(By.CssSelector(element)).GetAttribute("value").TrimStart().TrimEnd();
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                    }
                }
                else if (driver == Driver.driver2)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver2.FindElement(By.Id(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.Name: return PropertiesCollection.driver2.FindElement(By.Name(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.XPath: return PropertiesCollection.driver2.FindElement(By.XPath(element)).GetAttribute("value").TrimStart().TrimEnd();
                        case ElementType.CssSelector: return PropertiesCollection.driver2.FindElement(By.CssSelector(element)).GetAttribute("value").TrimStart().TrimEnd();
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                    }
                }
                else return String.Empty;
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert(elementtype.ToString() + ": (" + element + ") Not Present");
                return String.Empty;
            }
        }

        public static string GetTextContent(Driver driver, ElementType elementtype, string element)
        {
            try
            {
                if (driver == Driver.driver1)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver1.FindElement(By.Id(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.Name: return PropertiesCollection.driver1.FindElement(By.Name(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.XPath: return PropertiesCollection.driver1.FindElement(By.XPath(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.CssSelector: return PropertiesCollection.driver1.FindElement(By.CssSelector(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                    }
                }
                else if (driver == Driver.driver2)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver2.FindElement(By.Id(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.Name: return PropertiesCollection.driver2.FindElement(By.Name(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.XPath: return PropertiesCollection.driver2.FindElement(By.XPath(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        case ElementType.CssSelector: return PropertiesCollection.driver2.FindElement(By.CssSelector(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                    }
                }
                else return String.Empty;
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert(elementtype.ToString() + ": (" + element + ") Not Present");
                return String.Empty;
            }
        }

        public static string GetFromDDL(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: return new SelectElement(PropertiesCollection.driver1.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.Name: return new SelectElement(PropertiesCollection.driver1.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.XPath: return new SelectElement(PropertiesCollection.driver1.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.CssSelector: return new SelectElement(PropertiesCollection.driver1.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
                    default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: return new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.Name: return new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.XPath: return new SelectElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementType.CssSelector: return new SelectElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
                    default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return String.Empty;
                }
            }
            else return String.Empty;
        }

        public static void DisplayTextContent(Driver driver, ElementType elementtype, string element, string text)
        {
            Global.ConsoleOutTab(SeleniumGetMethods.GetTextContent(driver, elementtype, element) + ": " + text);
        }

        public static void DisplayTextValue(Driver driver, ElementType elementtype, string element, string text)
        {
            Global.ConsoleOutTab(SeleniumGetMethods.GetTextValue(driver, elementtype, element) + ": " + text);          
        }

        public static Boolean IsPresent(Driver driver, ElementType elementtype, string element)
        {
            try
            {
                if (driver == Driver.driver1)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver1.FindElement(By.Id(element)).Displayed;
                        case ElementType.Name: return PropertiesCollection.driver1.FindElement(By.Name(element)).Displayed;
                        case ElementType.XPath: return PropertiesCollection.driver1.FindElement(By.XPath(element)).Displayed;
                        case ElementType.CssSelector: return PropertiesCollection.driver1.FindElement(By.CssSelector(element)).Displayed;
                        case ElementType.LinkText: return PropertiesCollection.driver1.FindElement(By.LinkText(element)).Displayed;
                        case ElementType.PartialLinkText: return PropertiesCollection.driver1.FindElement(By.PartialLinkText(element)).Displayed;
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return false;
                    }
                }
                else if (driver == Driver.driver2)
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: return PropertiesCollection.driver2.FindElement(By.Id(element)).Displayed;
                        case ElementType.Name: return PropertiesCollection.driver2.FindElement(By.Name(element)).Displayed;
                        case ElementType.XPath: return PropertiesCollection.driver2.FindElement(By.XPath(element)).Displayed;
                        case ElementType.CssSelector: return PropertiesCollection.driver2.FindElement(By.CssSelector(element)).Displayed;
                        case ElementType.LinkText: return PropertiesCollection.driver2.FindElement(By.LinkText(element)).Displayed;
                        case ElementType.PartialLinkText: return PropertiesCollection.driver2.FindElement(By.PartialLinkText(element)).Displayed;
                        default: Global.ConsoleOutAlert("No Such ElementType: " + elementtype); return false;
                    }
                }
                else return false;
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert(elementtype.ToString() + ": (" + element + ") Not Present");
                return false;
            }
        }

        public static void DisplayIsPresent(Driver driver, ElementType elementtype, string element, string text)
        {
            Global.ConsoleOutTab(SeleniumGetMethods.IsPresent(driver, elementtype, element) + ": " + text);
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

        public static void GetWindowTitle(Driver driver)
        {
            // Driver 1
            if (driver == Driver.driver1)
            {
                string path = PropertiesCollection.driver1.ToString();
                int pos = path.LastIndexOf(".") + 1;
                Global.ConsoleOutTab(path.Substring(pos, path.Length - pos).ToString() + ":-  Window Title: " + PropertiesCollection.driver1.Title);
            }
            // Driver 2
            else if (driver == Driver.driver2)
            {
                string path = PropertiesCollection.driver2.ToString();
                int pos = path.LastIndexOf(".") + 1;
                Global.ConsoleOutTab(path.Substring(pos, path.Length - pos).ToString() + ":- Window Title: " + PropertiesCollection.driver2.Title);
            }
        }
    }
}
