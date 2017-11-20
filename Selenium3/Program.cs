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
            Global.ReadySetGo();

            SeleniumWindowMethods.WindowActions(Driver.driver2, ActType.Close);
            SeleniumWindowMethods.WindowActions(Driver.driver1, ActType.Maximize);            
            Runner_QA.RAFlow1Org1(Driver.driver1);

            // Test was executed successfully 
            Global.Done();

        }

    }

}

