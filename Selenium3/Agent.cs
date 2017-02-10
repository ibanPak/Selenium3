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
    class Agent
    {
        public static void AcceptScheduleAppointment()
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(ElementType.Id, "Address", Global.StreetAddress);
            SeleniumSetMethods.Click(ElementType.Id, "searchButton1");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Schedule Appointment (Agent)");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Schedule Appointment (Agent)");
            SeleniumSetMethods.Wait(ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmit");

        }

        public static void OrderU53()
        {

            // Login to Agent
            Login.qaAgent();
            Agent.AcceptScheduleAppointment();

            


        }


    }


}
