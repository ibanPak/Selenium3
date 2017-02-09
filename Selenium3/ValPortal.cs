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
    class ValPortal
    {

        public static void GetOrderIdSample()
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://qa-valuation.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", "test");
            SeleniumSetMethods.EnterText(ElementType.Id, "password", "P@ssw0rd1");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");

            // Order Queue Page
            SeleniumSetMethods.Wait(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Click(ElementType.LinkText, "Clear");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchOrders");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchOrders");

            // Open Appraisal Order 28833
            SeleniumSetMethods.Wait(ElementType.LinkText, "28833");
            SeleniumSetMethods.Click(ElementType.LinkText, "28833");

            // Get Order ID from Order Details page
            string OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector, "div.padding-5:nth-child(3) > b:nth-child(2)").TrimStart();

            // Print Order ID
            Console.WriteLine(" ");
            Console.WriteLine("Order ID: " + OrderID);
            Console.WriteLine(" ");

            SeleniumWindowMethods.Sleep(2);

            // Apply using Vars
            SeleniumSetMethods.Click(ElementType.LinkText, "Orders");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(ElementType.LinkText, OrderID);
            SeleniumWindowMethods.Sleep(2);

            // End Test
            SeleniumWindowMethods.WindowActions(ActType.Close);


        }



    }




}