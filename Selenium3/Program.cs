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

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            Runner_QA.FMBFlow1Org1(Driver.driver1);

            // Login.ValPortal(Driver.driver1, ENV.QA, "test", "P@ssw0rd1");
            // Portal_Val.CreateNewAppraisal(Driver.driver1, "acme", "Appraisal", "2055 Exterior Residential", "Encore", "Irvine", "California", "92620");
            // Portal_Val.CreateNewFMBBPO(Driver.driver1, "acme", "BPO", "Exterior", "Encore", "Irvine", "California", "92620");

            // Test was executed successfully 
            Global.Done();

        }

    }

}

