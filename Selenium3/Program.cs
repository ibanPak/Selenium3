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
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo(NumBrowsers.Two);

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            //Runner_QA.FMBFlow1Org1(Driver.driver1);

            Login.Vendor(Driver.driver2, ENV.QA, "test", "P@ssw0rd1");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.MouseOver(Driver.driver2, ElementType.CssSelector, "ul.main > li:nth-child(4) > a:nth-child(1)");
            SeleniumSetMethods.Click(Driver.driver2, ElementType.CssSelector, "a[href *= '/Reports/Task']");

            // Test was executed successfully 
            Global.Done();

        }

    }

}

