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

            Driver driver = Driver.driver1;

            Global.ConsoleOutTab("Passed Count: " + Global.passcount.ToString());

            Global.passcount++;

            Global.ConsoleOutTab("Passed Count: " + Global.passcount.ToString());

            Global.passcount++;

            Global.ConsoleOutTab("Passed Count: " + Global.passcount.ToString());

            Global.failcount++;

            Global.ConsoleOutAlert("Failed Count: " + Global.failcount.ToString());

            Global.PassFailCalc();

            Global.ApplicationPause("Wait here");

            // Runner_QA.REOFlowOrg1(driver, City.Irvine);       

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }

    }

}

