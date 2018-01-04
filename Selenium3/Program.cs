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

            Login.ValPortal(Driver.driver1, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.ViewAssignmentHistory(Driver.driver1, "30927");

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }

    }

}

