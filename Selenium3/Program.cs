﻿using OpenQA.Selenium.Chrome;
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
            // Start your engines !!!
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();

            
            Global.Cooldown();

            // Test was completed successfully
            // Global.Done();

        }

      

    }


}

    