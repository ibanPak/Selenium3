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
                PropertiesCollection.driver.Navigate().GoToUrl(URL);
            }
            // Driver 2
            else if (driver == Driver.driver2)
            {
                PropertiesCollection.driver2.Navigate().GoToUrl(URL);
            }

        }

        public static void EnterText(Driver driver, ElementType elementtype, string element, string value)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            }
            // Driver2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver2.FindElement(By.Id(element)).SendKeys(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver2.FindElement(By.Name(element)).SendKeys(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                PropertiesCollection.driver2.FindElement(By.XPath(element)).SendKeys(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver2.FindElement(By.CssSelector(element)).SendKeys(value);
            }

        }

        public static void Clear(Driver driver, ElementType elementtype, string element)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Clear();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Clear();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Clear();
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver2.FindElement(By.Id(element)).Clear();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver2.FindElement(By.Name(element)).Clear();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver2.FindElement(By.CssSelector(element)).Clear();
            }

        }

        public static void Click(Driver driver, ElementType elementtype, string element)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.LinkText)
            {
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.PartialLinkText)
            {
                PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).Click();
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                PropertiesCollection.driver2.FindElement(By.Id(element)).Click();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                PropertiesCollection.driver2.FindElement(By.Name(element)).Click();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                PropertiesCollection.driver2.FindElement(By.XPath(element)).Click();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                PropertiesCollection.driver2.FindElement(By.CssSelector(element)).Click();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.LinkText)
            {
                PropertiesCollection.driver2.FindElement(By.LinkText(element)).Click();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.PartialLinkText)
            {
                PropertiesCollection.driver2.FindElement(By.PartialLinkText(element)).Click();
            }

        }

        public static void MultiSelect(Driver driver, ElementType elementtype, string element, string value)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByValue(value);
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).SelectByValue(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).SelectByValue(value);
            }

        }

        public static void SelectDropDown(Driver driver, ElementType elementtype, string element, string value)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.Id(element))).SelectByText(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.Name(element))).SelectByText(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).SelectByText(value);
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                new SelectElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).SelectByText(value);
            }

        }

        public static void MouseOver(Driver driver, ElementType elementtype, string element)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.Id(element))).Build().Perform();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.Name(element))).Build().Perform();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.XPath(element))).Build().Perform();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).Build().Perform();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.LinkText)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.LinkText(element))).Build().Perform();
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.PartialLinkText)
            {
                Actions builder = new Actions(PropertiesCollection.driver);
                builder.MoveToElement(PropertiesCollection.driver.FindElement(By.PartialLinkText(element))).Build().Perform();
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.Id(element))).Build().Perform();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.Name(element))).Build().Perform();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.XPath(element))).Build().Perform();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.CssSelector(element))).Build().Perform();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.LinkText)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.LinkText(element))).Build().Perform();
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.PartialLinkText)
            {
                Actions builder2 = new Actions(PropertiesCollection.driver2);
                builder2.MoveToElement(PropertiesCollection.driver2.FindElement(By.PartialLinkText(element))).Build().Perform();
            }

        }

        public static void Wait(Driver driver, ElementType elementtype, string element)
        {
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }
            // Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }

        }

        public static void WaitMinutes(Driver driver, ElementType elementtype, string element, int minutes)
        {
            // Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }
            // Driver 2
            if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }

        }

        public static void Find(Driver driver, ElementType elementtype, string element)
        {
            //Driver 1
            if (driver == Driver.driver1 && elementtype == ElementType.Id)
            {
                try
                {
                    PropertiesCollection.driver.FindElement(By.Id(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.Name)
            {
                try
                {
                    PropertiesCollection.driver.FindElement(By.Name(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.XPath)
            {
                PropertiesCollection.driver.FindElement(By.XPath(element));
                Global.ConsoleOut("Element found: " + element);
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.CssSelector)
            {
                try
                {
                    PropertiesCollection.driver.FindElement(By.CssSelector(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.LinkText)
            {
                try
                {
                    PropertiesCollection.driver.FindElement(By.LinkText(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver1 && elementtype == ElementType.PartialLinkText)
            {
                try
                {
                    PropertiesCollection.driver.FindElement(By.PartialLinkText(element));
                    Global.ConsoleOut("Element not found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            //Driver 2
            else if (driver == Driver.driver2 && elementtype == ElementType.Id)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.Id(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.Name)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.Name(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.XPath)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.XPath(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.CssSelector)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.CssSelector(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.LinkText)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.LinkText(element));
                    Global.ConsoleOut("Element found: " + element);
                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);
                }
            }
            else if (driver == Driver.driver2 && elementtype == ElementType.PartialLinkText)
            {
                try
                {
                    PropertiesCollection.driver2.FindElement(By.PartialLinkText(element));
                    Global.ConsoleOut("Element found: " + element);

                }
                catch (Exception)
                {
                    Global.ConsoleOut("Element not found: " + element);

                }

            }

        }

    }

}