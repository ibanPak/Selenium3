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
    class REO
    {

        public static void GetPropertyIdSample()
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate("https://uat-reo2.res.net/");

            SeleniumSetMethods.Wait(ElementType.Id, "amLoginId");
            SeleniumSetMethods.EnterText(ElementType.Id, "amLoginId", "Yeshh1");
            SeleniumSetMethods.EnterText(ElementType.Name, "amIdentity", "Yeshh1");
            SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

            // Properties - Search for properties
            SeleniumSetMethods.Wait(ElementType.LinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.LinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Name, "btnSearchProp");
            SeleniumSetMethods.Click(ElementType.Name, "btnSearchProp");

            // Click on Property - 411 Mars
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "411 Mars");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "411 Mars");

            // Get Property ID from Property Details page
            string PropertyID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "#selectedProperty > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2)").TrimStart();

            // Print Property ID
            Console.WriteLine(" ");
            Console.WriteLine("Order ID: " + PropertyID);
            Console.WriteLine(" ");

            SeleniumWindowMethods.Sleep(5);

            // End Test
            SeleniumWindowMethods.WindowActions(ActType.Close);


        }



    }




}