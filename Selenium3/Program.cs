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
            Global.ReadySetGo(NumBrowsers.One);

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            Runner_QA.ProAgentSearchAllListing(Driver.driver1);

   /*   
            Login.ValPortal(Driver.driver1, ENV.QA, "test", "P@ssw0rd1");
            Login.Agent(Driver.driver2, ENV.QA, "QATest23@usres.com", "blue123");
 
            SeleniumSetMethods.Wait(Driver.driver1, ElementType.Id, "searchBar");
            Portal_Val.GotoOrder(Driver.driver1, "30925");
            SeleniumWindowMethods.Sleep(3);

            SeleniumSetMethods.Wait(Driver.driver2, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Navigate(Driver.driver2, "https://qa-agent.res.net/AgentProfile");
            SeleniumSetMethods.Wait(Driver.driver2, ElementType.Id, "propertySrchTxt");
            SeleniumSetMethods.EnterText(Driver.driver2, ElementType.Id, "propertySrchTxt", "100");

   */

            // Test was executed successfully 
            Global.Done();

        }

    }

}

