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


        // Navigate to URL
        public static void Navigate(string URL)
        {

            PropertiesCollection.driver.Navigate().GoToUrl(URL);
        }


        // Enter Text
        public static void EnterText(ElementType elementtype, string element, string value)
        {
            if (elementtype == ElementType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == ElementType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == ElementType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            if (elementtype == ElementType.CssSelector)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);

        }

        // Clear Text Field
        public static void Clear(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Clear();
            if (elementtype == ElementType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Clear();

        }

        // Click into a button, Checkbox, Option etc
        public static void Click(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == ElementType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementtype == ElementType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            if (elementtype == ElementType.CssSelector)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            if (elementtype == ElementType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            if (elementtype == ElementType.PartialLinkText)
                PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).Click();

        }


        // Select a drop down control
        public static void SelectDropDown(ElementType elementtype, string element, string value)
        {
            if (elementtype == ElementType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == ElementType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == ElementType.CssSelector)
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            if (elementtype == ElementType.XPath)
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            if (elementtype == ElementType.CssSelector)
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
        }


        // Webdriver Wait
        public static void Wait(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }

            if (elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }

            if (elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }

            if (elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }

            if (elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }

            if (elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }


        }


        public static void WaitMinutes(ElementType elementtype, string element, int minutes)
        {
            if (elementtype == ElementType.Id)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
            }

            if (elementtype == ElementType.Name)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
            }

            if (elementtype == ElementType.XPath)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }

            if (elementtype == ElementType.CssSelector)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }

            if (elementtype == ElementType.LinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
            }

            if (elementtype == ElementType.PartialLinkText)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(minutes));
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(element)));
            }
        }

        public static void AlertWait()
        {
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.AlertIsPresent());


        }

    }

}