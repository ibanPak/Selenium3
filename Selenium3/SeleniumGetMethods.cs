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

        public static string GetTextValue(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == ElementType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (elementtype == ElementType.CssSelector)
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            if (elementtype == ElementType.XPath)
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
            else return String.Empty;

        }

        public static string GetTextContent(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("textContent");
            if (elementtype == ElementType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("textContent");
            if (elementtype == ElementType.CssSelector)
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("textContent");
            if (elementtype == ElementType.XPath)
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("textContent");
            else return String.Empty;

        }


        public static string GetFromDDL(ElementType elementtype, string element)
        {
            if (elementtype == ElementType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == ElementType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }


    }


}
