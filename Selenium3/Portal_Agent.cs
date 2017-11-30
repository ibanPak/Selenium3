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
    class Portal_Agent
    {
        public static void AcceptScheduleAppointment(Driver driver)
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Schedule Appointment");
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
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut("Accepted Scheduled Appointment @: " + DateTime.Now);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Manually run Amp Order sync now");

        }

        public static void OpenBPO(Driver driver)
        {
            // Open BPO Task
            Global.ConsoleOut("Opening BPO :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find BPO: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "BPO");
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
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenRentalAnalysis(Driver driver)
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening Rental Analysis :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Rental Analysis: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "Rental Analysis");
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
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenREOTasks(Driver driver, string TaskName)
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening REO Task for Property Id :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Task: " + TaskName + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, TaskName);
                    Global.ConsoleOut("REO Task: " + TaskName + " Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut(TaskName + " not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void SendToClient(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnBpoSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnBpoSubmit");
        }

    }

}
