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

            Login.Buyer(Driver.driver1, ENV.QA, "ibanPn", "yellow123");
            TestCreditCard.BuyerProfile(Driver.driver1, CreditCardTypeType.Visa);
         
            Global.ApplicationPause("Wait here");

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }

    }

}

