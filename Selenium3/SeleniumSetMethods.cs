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
    class SeleniumSetMethods
    {
        public static void Navigate(Driver driver, string URL)
        {
            // Driver 1
            if (driver == Driver.driver1)
            {
                PropertiesCollection.driver1.Navigate().GoToUrl(URL);
            }
            // Driver 2
            else if (driver == Driver.driver2)
            {
                PropertiesCollection.driver2.Navigate().GoToUrl(URL);
            }
        }

        public static void EnterText(Driver driver, ElementType elementtype, string element, string value)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver1.FindElement(By.Id(element)).SendKeys(value); break;
                    case ElementType.Name: PropertiesCollection.driver1.FindElement(By.Name(element)).SendKeys(value); break;
                    case ElementType.XPath: PropertiesCollection.driver1.FindElement(By.XPath(element)).SendKeys(value); break;
                    case ElementType.CssSelector: PropertiesCollection.driver1.FindElement(By.CssSelector(element)).SendKeys(value); break;
                    case ElementType.LinkText: PropertiesCollection.driver1.FindElement(By.LinkText(element)).SendKeys(value); break;
                    case ElementType.PartialLinkText: PropertiesCollection.driver1.FindElement(By.PartialLinkText(element)).SendKeys(value); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver2.FindElement(By.Id(element)).SendKeys(value); break;
                    case ElementType.Name: PropertiesCollection.driver2.FindElement(By.Name(element)).SendKeys(value); break;
                    case ElementType.XPath: PropertiesCollection.driver2.FindElement(By.XPath(element)).SendKeys(value); break;
                    case ElementType.CssSelector: PropertiesCollection.driver2.FindElement(By.CssSelector(element)).SendKeys(value); break;
                    case ElementType.LinkText: PropertiesCollection.driver2.FindElement(By.LinkText(element)).SendKeys(value); break;
                    case ElementType.PartialLinkText: PropertiesCollection.driver2.FindElement(By.PartialLinkText(element)).SendKeys(value); break;
                }
            }
        }

        public static void Clear(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver1.FindElement(By.Id(element)).Clear(); break;
                    case ElementType.Name: PropertiesCollection.driver1.FindElement(By.Name(element)).Clear(); break;
                    case ElementType.XPath: PropertiesCollection.driver1.FindElement(By.XPath(element)).Clear(); break;
                    case ElementType.CssSelector: PropertiesCollection.driver1.FindElement(By.CssSelector(element)).Clear(); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver2.FindElement(By.Id(element)).Clear(); break;
                    case ElementType.Name: PropertiesCollection.driver2.FindElement(By.Name(element)).Clear(); break;
                    case ElementType.XPath: PropertiesCollection.driver2.FindElement(By.XPath(element)).Clear(); break;
                    case ElementType.CssSelector: PropertiesCollection.driver2.FindElement(By.CssSelector(element)).Clear(); break;
                }
            }
        }

        public static void Click(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver1.FindElement(By.Id(element)).Click(); break;
                    case ElementType.Name: PropertiesCollection.driver1.FindElement(By.Name(element)).Click(); break;
                    case ElementType.XPath: PropertiesCollection.driver1.FindElement(By.XPath(element)).Click(); break;
                    case ElementType.CssSelector: PropertiesCollection.driver1.FindElement(By.CssSelector(element)).Click(); break;
                    case ElementType.LinkText: PropertiesCollection.driver1.FindElement(By.LinkText(element)).Click(); break;
                    case ElementType.PartialLinkText: PropertiesCollection.driver1.FindElement(By.PartialLinkText(element)).Click(); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: PropertiesCollection.driver2.FindElement(By.Id(element)).Click(); break;
                    case ElementType.Name: PropertiesCollection.driver2.FindElement(By.Name(element)).Click(); break;
                    case ElementType.XPath: PropertiesCollection.driver2.FindElement(By.XPath(element)).Click(); break;
                    case ElementType.CssSelector: PropertiesCollection.driver2.FindElement(By.CssSelector(element)).Click(); break;
                    case ElementType.LinkText: PropertiesCollection.driver2.FindElement(By.LinkText(element)).Click(); break;
                    case ElementType.PartialLinkText: PropertiesCollection.driver2.FindElement(By.PartialLinkText(element)).Click(); break;
                }
            }
        }

        public static void MultiSelect(Driver driver, ElementType elementtype, string element, string value)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: new SelectElement(PropertiesCollection.driver1.FindElement(By.Id(element))).SelectByValue(value); break;
                    case ElementType.Name: new SelectElement(PropertiesCollection.driver1.FindElement(By.Name(element))).SelectByValue(value); break;
                    case ElementType.XPath: new SelectElement(PropertiesCollection.driver1.FindElement(By.XPath(element))).SelectByValue(value); break;
                    case ElementType.CssSelector: new SelectElement(PropertiesCollection.driver1.FindElement(By.CssSelector(element))).SelectByValue(value); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).SelectByValue(value); break;
                    case ElementType.Name: new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).SelectByValue(value); break;
                    case ElementType.XPath: new SelectElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).SelectByValue(value); break;
                    case ElementType.CssSelector: new SelectElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).SelectByValue(value); break;
                }
            }
        }

        public static void SelectDropDown(Driver driver, ElementType elementtype, string element, string value)
        {
            if (driver == Driver.driver1)
            {
                switch (elementtype)
                {
                    case ElementType.Id: new SelectElement(PropertiesCollection.driver1.FindElement(By.Id(element))).SelectByText(value); break;
                    case ElementType.Name: new SelectElement(PropertiesCollection.driver1.FindElement(By.Name(element))).SelectByText(value); break;
                    case ElementType.XPath: new SelectElement(PropertiesCollection.driver1.FindElement(By.XPath(element))).SelectByText(value); break;
                    case ElementType.CssSelector: new SelectElement(PropertiesCollection.driver1.FindElement(By.CssSelector(element))).SelectByText(value); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                switch (elementtype)
                {
                    case ElementType.Id: new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).SelectByText(value); break;
                    case ElementType.Name: new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).SelectByText(value); break;
                    case ElementType.XPath: new SelectElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).SelectByText(value); break;
                    case ElementType.CssSelector: new SelectElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).SelectByText(value); break;
                }
            }
        }

        public static void MouseOver(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1)
            {
                Actions builder = new Actions(PropertiesCollection.driver1);
                switch (elementtype)
                {
                    case ElementType.Id: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.Id(element))).Build().Perform(); break;
                    case ElementType.Name: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.Name(element))).Build().Perform(); break;
                    case ElementType.XPath: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.XPath(element))).Build().Perform(); break;
                    case ElementType.CssSelector: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.CssSelector(element))).Build().Perform(); break;
                    case ElementType.LinkText: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.LinkText(element))).Build().Perform(); break;
                    case ElementType.PartialLinkText: builder.MoveToElement(PropertiesCollection.driver1.FindElement(By.PartialLinkText(element))).Build().Perform(); break;
                }
            }
            else if (driver == Driver.driver2)
            {
                Actions builder = new Actions(PropertiesCollection.driver2);
                switch (elementtype)
                {
                    case ElementType.Id: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.Id(element))).Build().Perform(); break;
                    case ElementType.Name: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.Name(element))).Build().Perform(); break;
                    case ElementType.XPath: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).Build().Perform(); break;
                    case ElementType.CssSelector: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).Build().Perform(); break;
                    case ElementType.LinkText: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.LinkText(element))).Build().Perform(); break;
                    case ElementType.PartialLinkText: builder.MoveToElement(PropertiesCollection.driver2.FindElement(By.PartialLinkText(element))).Build().Perform(); break;
                }
            }
        }

        public static void Wait(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver1, TimeSpan.FromSeconds(30));
                switch (elementtype)
                {
                    case ElementType.Id: wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))); break;
                    case ElementType.Name: wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))); break;
                    case ElementType.XPath: wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))); break;
                    case ElementType.CssSelector: wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element))); break;
                    case ElementType.LinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element))); break;
                    case ElementType.PartialLinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element))); break;
                }
            }
            if (driver == Driver.driver2)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                switch (elementtype)
                {
                    case ElementType.Id: wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))); break;
                    case ElementType.Name: wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))); break;
                    case ElementType.XPath: wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))); break;
                    case ElementType.CssSelector: wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element))); break;
                    case ElementType.LinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element))); break;
                    case ElementType.PartialLinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element))); break;
                }
            }
        }

        public static void WaitMinutes(Driver driver, ElementType elementtype, string element, int minutes)
        {
            if (driver == Driver.driver1)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver1, TimeSpan.FromMinutes(minutes));
                switch (elementtype)
                {
                    case ElementType.Id: wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))); break;
                    case ElementType.Name: wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))); break;
                    case ElementType.XPath: wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))); break;
                    case ElementType.CssSelector: wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element))); break;
                    case ElementType.LinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element))); break;
                    case ElementType.PartialLinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element))); break;
                }
            }
            if (driver == Driver.driver2)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                switch (elementtype)
                {
                    case ElementType.Id: wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))); break;
                    case ElementType.Name: wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))); break;
                    case ElementType.XPath: wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))); break;
                    case ElementType.CssSelector: wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element))); break;
                    case ElementType.LinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element))); break;
                    case ElementType.PartialLinkText: wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element))); break;
                }
            }
        }

        public static void Find(Driver driver, ElementType elementtype, string element, string displaytext)
        {
            if (driver == Driver.driver1)
            {
                try
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: PropertiesCollection.driver1.FindElement(By.Id(element)); break;
                        case ElementType.Name: PropertiesCollection.driver1.FindElement(By.Id(element)); break;
                        case ElementType.XPath: PropertiesCollection.driver1.FindElement(By.Id(element)); break;
                        case ElementType.CssSelector: PropertiesCollection.driver1.FindElement(By.Id(element)); break;
                        case ElementType.LinkText: PropertiesCollection.driver1.FindElement(By.LinkText(element)); break;
                        case ElementType.PartialLinkText: PropertiesCollection.driver1.FindElement(By.PartialLinkText(element)); break;
                    }
                    Global.ConsoleOutTab("Element found: " + displaytext);
                }
                catch (Exception)
                {
                    Global.ConsoleOutAlert("Element not found: " + displaytext);
                }
            }
            else if (driver == Driver.driver2)
            {
                try
                {
                    switch (elementtype)
                    {
                        case ElementType.Id: PropertiesCollection.driver2.FindElement(By.Id(element)); break;
                        case ElementType.Name: PropertiesCollection.driver2.FindElement(By.Id(element)); break;
                        case ElementType.XPath: PropertiesCollection.driver2.FindElement(By.Id(element)); break;
                        case ElementType.CssSelector: PropertiesCollection.driver2.FindElement(By.Id(element)); break;
                        case ElementType.LinkText: PropertiesCollection.driver2.FindElement(By.LinkText(element)); break;
                        case ElementType.PartialLinkText: PropertiesCollection.driver2.FindElement(By.PartialLinkText(element)); break;
                    }
                    Global.ConsoleOutTab("Element found: " + displaytext);
                }
                catch (Exception)
                {
                    Global.ConsoleOutAlert("Element not found: " + displaytext);
                }
            }
        }

        public static void FileUpload(Driver driver, ElementType elementtype, string element, string filename)
        {
            try
            {
                SeleniumSetMethods.Clear(driver, elementtype, element);
                SeleniumWindowMethods.Sleep(1);
                SeleniumSetMethods.EnterText(driver, elementtype, element, Global.folderpath + filename);
                SeleniumWindowMethods.Sleep(1);
                Global.
                    ConsoleOutTab(filename + " was successfully added to: " + element);
            }
            catch (NoSuchElementException)
            {
                Global.ConsoleOutAlert("File Upload Section not found: " + element);
            }
        }
    }
}