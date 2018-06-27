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
                // Driver 1
                if (driver == Driver.driver1 && elementtype == ElementType.Id)
                {
                    return PropertiesCollection.driver1.FindElement(By.Id(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver1.FindElement(By.Name(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver1.FindElement(By.CssSelector(element)).GetAttribute("value");
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver1.FindElement(By.XPath(element)).GetAttribute("value");
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
                    return PropertiesCollection.driver1.FindElement(By.Id(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.Name)
                {
                    return PropertiesCollection.driver1.FindElement(By.Name(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
                {
                    return PropertiesCollection.driver1.FindElement(By.CssSelector(element)).GetAttribute("textContent").TrimStart().TrimEnd();
                }
                else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
                {
                    return PropertiesCollection.driver1.FindElement(By.XPath(element)).GetAttribute("textContent").TrimStart().TrimEnd();
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
                return new SelectElement(PropertiesCollection.driver1.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                return new SelectElement(PropertiesCollection.driver1.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
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

        public static void IsPresent(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                Boolean ispresent = PropertiesCollection.driver1.FindElement(By.Id(element)).Displayed;
                if (ispresent == true)
                {
                    Global.ConsoleOutTab("Element is Present: " + element);
                }
                else if (ispresent == false)
                {
                    Global.ConsoleOutAlert("Element NOT Present: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                Boolean ispresent = PropertiesCollection.driver1.FindElement(By.Name(element)).Displayed;
                if (ispresent == true)
                {
                    Global.ConsoleOutTab("Element is Present: " + element);
                }
                else if (ispresent == false)
                {
                    Global.ConsoleOutAlert("Element NOT Present: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                Boolean ispresent = PropertiesCollection.driver1.FindElement(By.ClassName(element)).Displayed;
                if (ispresent == true)
                {
                    Global.ConsoleOutTab("Element is Present: " + element);
                }
                else if (ispresent == false)
                {
                    Global.ConsoleOutAlert("Element NOT Present: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                Boolean ispresent = PropertiesCollection.driver2.FindElement(By.Id(element)).Displayed;
                if (ispresent == true)
                {
                    Global.ConsoleOutTab("Element is Present: " + element);
                }
                else if (ispresent == false)
                {
                    Global.ConsoleOutAlert("Element NOT Present: " + element);
                }
            }
        }

        public static void IsSelected(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                Boolean isselected = PropertiesCollection.driver1.FindElement(By.Id(element)).Selected;
                if (isselected == true)
                {
                    Global.ConsoleOutAlert("Element is Selected: " + element);
                }
                else if (isselected == false)
                {
                    Global.ConsoleOutAlert("Element not Selected: " + element);
                }
            }
            else if (driver == Driver.driver2)
                try
                {
                    PropertiesCollection.driver2.FindElement(By.Id(element));


                }
                catch (NoSuchElementException)
                {
                    Global.ConsoleOutAlert("Element not present: " + element);


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
