using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Vendor
    {
        public static void AcceptScheduleAppointment()
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "searchButton");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "cbScheduleAppointment(Appraiser)");
            SeleniumSetMethods.Click(ElementType.Id, "cbScheduleAppointment(Appraiser)");
            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton"); // refreshing results
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
                SeleniumSetMethods.Click(ElementType.PartialLinkText, "Tasks");
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

        public static void UploadAppraisal()
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Wait(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(ElementType.Id, "searchButton");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "cbUploadAppraisal");
            SeleniumSetMethods.Click(ElementType.Id, "cbUploadAppraisal");
            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(ElementType.Id, "searchButton"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(ElementType.PartialLinkText, "Upload Appraisal");
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
                SeleniumSetMethods.Click(ElementType.PartialLinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.EnterText(ElementType.Id, "Attachment_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\QA Automation\\Documents\\1025_01.pdf");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyValue", "500000");
            SeleniumSetMethods.Wait(ElementType.Id, "ActualAppointmentDate");
            SeleniumSetMethods.Click(ElementType.Id, "ActualAppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmit"); 

        }

    }

}
