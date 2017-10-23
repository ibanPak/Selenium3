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

            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");

            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.MouseOver(ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplPropertySearch");     
            SeleniumSetMethods.Click(ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplSubPropertyListing");
            SeleniumWindowMethods.Sleep(5);
            Global.ConsoleOut("Chrome Driver was sucessful");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.WindowActions(ActType.Close);
            SeleniumWindowMethods.Sleep(2);
            
            // Test new driver
            IWebDriver driver = new InternetExplorerDriver();
            PropertiesCollection.driver = driver;
            Login.Agent(ENV.QA, "QATest23@usres.com", "blue123");

            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.MouseOver(ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplSubPropertyListing");
            SeleniumWindowMethods.Sleep(5);
            Global.ConsoleOut("IE Driver was sucessful");
            SeleniumWindowMethods.WindowActions(ActType.Close);

            // Test was executed successfully 
            Global.Done();

        }

    }

}

