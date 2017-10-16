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
            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(ElementType.PartialLinkText, "Schedule Appointment");
                    Global.ConsoleOut("Appointment Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 10)
                {
                    Global.ConsoleOut("Appointment Not Found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmit");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut("Accepted Scheduled Appointment @: " + DateTime.Now);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Manually run Amp Order sync now");
        }

        public static void OpenBPO()
        {
            // Open BPO Task
            Global.ConsoleOut("Opening BPO :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find BPO: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(ElementType.LinkText, "BPO");
                    Global.ConsoleOut("BPO Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut("BPO not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenRentalAnalysis()
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening Rental Analysis :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Rental Analysis: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(ElementType.LinkText, "Rental Analysis");
                    Global.ConsoleOut("Rental Analysis Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut("Rental Analysis not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenREOTasks(string TaskName)
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening REO Task for Property Id :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Task: " + TaskName + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(ElementType.LinkText, TaskName);
                    Global.ConsoleOut("REO Task: "+TaskName+ " Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut(TaskName +" not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

       public static void SendToClient()
        {
            SeleniumSetMethods.Wait(ElementType.Id, "btnBpoSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "btnBpoSubmit");
        }

    }

}
