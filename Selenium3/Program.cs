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
    class Program
    {

        static void Main(string[] args)
        {
            // Start your engines !!!
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();

            // qaRunner.PCFlow1();
            Login.qaPropertyCure("ibenPn", "Green!23");

            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "searchBar", Global.PropteryID);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.EnterText(ElementType.Id, "searchBar", Keys.Return);
            SeleniumSetMethods.Wait(ElementType.Id, "ui-id-6");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-6");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "1104");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "1104");
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Wait(ElementType.Id, "ViolationReason");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationReason", Global.PropteryID + " Violation Reason");
            SeleniumSetMethods.EnterText(ElementType.Id, "WorkOrderNumber", Global.PropteryID + " Work Order Number");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationDays", Global.StreetNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "OriginalViolationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Id, "CompliantDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationItemCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.CssSelector, "#newLineItemWrapper > td:nth-child(9) > a.mr10 > i");

            Global.Cooldown();
            // Test was completed successfully
            // Global.Done();

        }

      
    }


}

