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

        public static void PropertyCure()
        {
            
            int cycles = 0;
            int failcount = 0;

            while (cycles < 1000000)
            {
                try
                {
                    cycles = cycles + 1;
                    Global.ConsoleOut("Number of cycles: " + cycles);
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
                    SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Detail/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Detail/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Violations/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Violations/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/OtaBids/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/ServErrors/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/Inspection/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/Inspection/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/HazardClaims/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *='/Property/PropRegistration/']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Violation']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Violation']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Utility']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Utility']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/OtaBid']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/ServicingError']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/ServicingError']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Inspection']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Inspection']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/HazardClaim']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/HazardClaim']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/PropertyReg']");
                    SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/PropertyReg']");
                    SeleniumWindowMethods.ThrottlingSleep();
                    SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
                    SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");

                    Global.EndDT = DateTime.Now;
                    var seconds = (Global.EndDT - Global.StartDT).TotalSeconds;
                    TimeSpan timespan = TimeSpan.FromSeconds(seconds);
                    int hour = timespan.Hours;
                    int min = timespan.Minutes;
                    int sec = timespan.Seconds;

                    Global.ConsoleOut("Running Time " + hour + " Hours, " + min + " minutes, " + sec + " seconds, since testing has begun");
                    Global.ConsoleOut("Time Stamp: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    Global.ConsoleOut("Error: " + ex.ToString());
                    failcount = failcount + 1;
                    Global.ConsoleOut("failcount: " + failcount);

                }
                if (failcount == 15)
                {
                    Global.ConsoleOut("Max Failed Count: " + cycles);
                    break; // handle error and break/return
                }

            }
            
        }

    }

}
