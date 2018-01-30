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

            Global.OrderID = "30952";
            Global.StreetAddress = "1141 PARIS WAY";
            Global.ThrottleSleep = 3 * (1000);
            Driver driver = Driver.driver1;

            Login.Agent(driver, ENV.QA, "QATest23@usres.com", "blue123");
            // Portal_Agent.AcceptScheduleAppointment(driver);
            Portal_Agent.OpenBPO(driver);
            Form_PNMACBPO.CompleteBPO(driver);
            Form_PNMACBPO.Attachments(driver, ENV.QA);
            Logout.Portal(driver, Portals.Agent);
            Login.ValPortal(driver, ENV.QA, "test", "P@ssw0rd1");
            Portal_Val.CompleteBPOOrder(driver, Global.OrderID);
            Logout.Portal(driver, Portals.ValPortal);
            
            //Runner_QA.CreditCard(Driver.driver1);
            //Runner_QA.NewUser(Driver.driver1);

            Global.ApplicationPause("Wait here");

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }

    }

}

