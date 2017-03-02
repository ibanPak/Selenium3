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
using System.Runtime.InteropServices;

namespace Selenium3
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
            // Start your engines !!!
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();

            Runner.REOFlow1();

            Global.Cooldown();

            // Test was completed successfully
            Global.Done();



        }


    }


}
