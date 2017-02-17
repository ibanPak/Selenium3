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

            DateTime Sdate;
            DateTime Edate;
            Sdate = DateTime.Now;

            // Start your engines !!!
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();

            Login.qaValPortal();            
            ValPortal.CreateNewOrderU53();
            Login.qaAgent();
            Agent.AcceptScheduleAppointment();
            Agent.OpenBPO();
            Agent.U53Order();
            Agent.U53ExteriorAttachments();
            Login.qaValPortal();
            ValPortal.CompleteU53Order();

            Edate = DateTime.Now;
            var seconds = (Edate - Sdate).TotalSeconds;
            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;

            Global.ConsoleOut("Test took " + hour +" Hours, " + min +" minutes, "+ sec + " seconds to run");

            // Test was completed successfully
            Global.Done();



        }



    }




}
