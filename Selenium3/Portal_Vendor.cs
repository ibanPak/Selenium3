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
            Global.ConsoleOut("Accepting Schedule Appointment: " + DateTime.Now.ToString());
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
                    Global.ConsoleOutTab("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Schedule Appointment");
                    Global.ConsoleOutTab("Appointment Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 10)
                {
                    Global.ConsoleOutAlert("Appointment Not Found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            // Complete Accpet Schedule
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOutTab("Accepted Scheduled Appointment @: " + DateTime.Now);

        }

        public static void UploadAppraisal(Driver driver)
        {
            // Upload Appraisal
            Global.ConsoleOut("Upload Appraisal: " + DateTime.Now.ToString());
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
                    Global.ConsoleOutTab("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Upload Appraisal");
                    Global.ConsoleOutTab("Appraisal Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 10)
                {
                    Global.ConsoleOutAlert("Appraisal Not Found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            // Complete Upload Appraisal
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

        public static void HODILVendorPartI(Driver driver)
        {
            // Homeowner DIL Flow Vendor Part I
            /* Find Title Request */
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainNav > ul > li:nth-child(3) > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainNav > ul > li:nth-child(3) > a");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "cbAcceptTitleRequest");
            SeleniumSetMethods.Click(driver, ElementType.Id, "cbAcceptTitleRequest");
            SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton");
            SeleniumWindowMethods.Sleep(3);
            /* Accept Title Request */
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//*[@id='tasks']/tbody/tr[1]/td[2]/a");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='tasks']/tbody/tr[1]/td[2]/a");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Accept Title Request");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Accept Title Request");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#taskDetailsBodyRight > div.buttons > a.submit_button.btn.green.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#taskDetailsBodyRight > div.buttons > a.submit_button.btn.green.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "body > div:nth-child(17) > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only.primary > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div:nth-child(17) > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only.primary > span");
            SeleniumWindowMethods.Sleep(3);

            /* Preliminarty Title Request */
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Preliminary Title Request");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Preliminary Title Request");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CustomFields_CustomField_EstimatedClearDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "CustomFields_CustomField_EstimatedClearDate");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#ui-datepicker-div > div.ui-datepicker-buttonpane.ui-widget-content > button.ui-datepicker-current.ui-state-default.ui-priority-secondary.ui-corner-all.secondary");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#ui-datepicker-div > div.ui-datepicker-buttonpane.ui-widget-content > button.ui-datepicker-current.ui-state-default.ui-priority-secondary.ui-corner-all.secondary");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "5");
            SeleniumWindowMethods.Sleep(3);

            /* Stuck On Add File */
            /*
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SWFUpload_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SWFUpload_0", Global.folderpath + "H5.jpg");
            */
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#container > div:nth-child(1) > input[type='file']");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#container > div:nth-child(1) > input[type='file']", Global.folderpath + "H5.jpg");

            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div:nth-child(17) > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button:nth-child(2) > span");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "body > div:nth-child(17) > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button:nth-child(2) > span");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#taskDetailsFooterContent > div.buttons > a.btn.green.btn-primary.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#taskDetailsFooterContent > div.buttons > a.btn.green.btn-primary.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only > span");
            // Test Ended Close Window

        }

    }

}
