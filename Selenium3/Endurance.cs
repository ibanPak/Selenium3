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
    class Endurance
    {
        public static void PropertyCure(Driver driver)
        {
            int cycles = 0;
            int failcount = 0;
            while (cycles < 1000000)
            {
                try
                {
                    cycles = cycles + 1;
                    Global.ConsoleOutTab("Number of cycles: " + cycles);
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/Detail/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/Detail/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/Violations/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/Violations/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/Inspection/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/Inspection/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Note/Notes?']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Note/Notes?']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Violation']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Violation']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Utility']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Utility']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/ServicingError']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/ServicingError']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Inspection']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Inspection']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/HazardClaim']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/HazardClaim']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/PropertyReg']");
                    SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/PropertyReg']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
                    // Adding Timestaping information 
                    Global.EndDT = DateTime.Now;
                    var seconds = (Global.EndDT - Global.StartDT).TotalSeconds;
                    TimeSpan timespan = TimeSpan.FromSeconds(seconds);
                    int hour = timespan.Hours;
                    int min = timespan.Minutes;
                    int sec = timespan.Seconds;
                    Global.ConsoleOut("Running Time " + hour + " Hours, " + min + " minutes, " + sec + " seconds, since testing has begun");
                    Global.ConsoleOutTab("Time Stamp: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    Global.ConsoleOutAlert("Error: " + ex.ToString());
                    failcount = failcount + 1;
                    Global.ConsoleOutAlert("failcount: " + failcount);
                    SeleniumWindowMethods.ScreenShot(driver, "Error");
                    Global.ConsoleOutAlert("Error Time Stamp: " + DateTime.Now);
                }
                if (failcount == 15)
                {
                    Global.ConsoleOutAlert("Max Failed Count: " + cycles + " test has aborted");
                    break; // handle error and break/return
                }

            }

        }

    }

}
