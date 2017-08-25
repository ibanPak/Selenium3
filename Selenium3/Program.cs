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
    class Program
    {

        static void Main(string[] args)
        {
            // Start your engines !!!
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();

            Login.stgPropertyCure("ibenPn", "Green!23");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Detail/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Detail/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Violations/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Violations/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Inspection/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Inspection/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property//Note/Notes?/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property//Note/Notes?/']");

           
            //    SeleniumSetMethods.Wait(ElementType.LinkText, Global.PropteryID);
            //    SeleniumSetMethods.Click(ElementType.LinkText, Global.PropteryID);

        }

      
    }


}

