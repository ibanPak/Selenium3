using System.Configuration;
using System.Collections.Specialized;
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
            Global.ReadySetGo();

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            Driver driver = Driver.driver1;

            Runner_QA.FMBFlow1Org1(driver, City.Irvine1);

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }
    }
}