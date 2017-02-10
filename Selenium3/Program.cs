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
    class Program
    {

        static void Main(string[] args)
        {
          /*  
            IWebDriver driver = new ChromeDriver();
            PropertiesCollection.driver = driver;
            SeleniumWindowMethods.WindowActions(ActType.Maximize);

            */
            /*********************************************************************************
            * 
            *      Start coding from below this
            * 
            * ******************************************************************************/
            // ValPortal.TestCode();

            
            Global.ConsoleOut("Street Number: " + Global.StreetAddress);
            SeleniumWindowMethods.Sleep(1);
            Global.StreetAddress = Global.StreetNum + " Test Land";
            Global.ConsoleOut("Street Number: " + Global.StreetAddress);

            // Test was completed successfully
            Global.ConsoleOut("Test was completed successfully");
            SeleniumWindowMethods.Sleep(5);
            //SeleniumWindowMethods.WindowActions(ActType.Close);


        }



    }




}
