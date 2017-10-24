using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Portal_Vendor
    {
        public static void AcceptScheduleAppointment(Driver driver)
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "cbScheduleAppointment(Appraiser)");
            SeleniumSetMethods.Click(driver, ElementType.Id, "cbScheduleAppointment(Appraiser)");
            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton"); // refreshing results
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
                SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut("Accepted Scheduled Appointment @: " + DateTime.Now);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Manually run Amp Order sync now");
        }

        public static void UploadAppraisal(Driver driver)
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "cbUploadAppraisal");
            SeleniumSetMethods.Click(driver, ElementType.Id, "cbUploadAppraisal");
            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Upload Appraisal");
                    Global.ConsoleOut("Appraisal Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 10)
                {
                    Global.ConsoleOut("Appraisal Not Found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Attachment_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\QA Automation\\Documents\\1025_01.pdf");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyValue", "500000");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ActualAppointmentDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ActualAppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit"); 

        }

    }

}
