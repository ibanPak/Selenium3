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
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo();
            Login.uatPropertyCure("ibenPn", "Green!23");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, Global.PropteryID);
            SeleniumSetMethods.Click(ElementType.LinkText, Global.PropteryID);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "MostRecentValue");
            SeleniumSetMethods.Clear(ElementType.Id, "MostRecentValue");
            SeleniumSetMethods.EnterText(ElementType.Id, "MostRecentValue", "-12345678.00");
            SeleniumSetMethods.Clear(ElementType.Id, "TaxAssesessedValueAmt");
            SeleniumSetMethods.EnterText(ElementType.Id, "TaxAssesessedValueAmt", "-12345678.00");
            SeleniumSetMethods.Clear(ElementType.Id, "LPI");
            SeleniumSetMethods.EnterText(ElementType.Id, "LPI", "-12345678.00");
            SeleniumSetMethods.Clear(ElementType.Id, "CorpAdvancesAmt");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorpAdvancesAmt", "-12345678.00");
            SeleniumSetMethods.Clear(ElementType.Id, "EscrowAdvancesAmt");
            SeleniumSetMethods.EnterText(ElementType.Id, "EscrowAdvancesAmt", "-12345678.00");
            SeleniumSetMethods.Clear(ElementType.Id, "HazardProceedsAmt");
            SeleniumSetMethods.EnterText(ElementType.Id, "HazardProceedsAmt", "-12345678.00");

            // Update Button    
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody"+Global.PropteryID);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "MostRecentValue");
            Global.Value= SeleniumGetMethods.GetTextValue(ElementType.Id, "MostRecentValue");
            Global.ConsoleOut("MostRecentValue Value : " + Global.Value);
            Global.Value = SeleniumGetMethods.GetTextValue(ElementType.Id, "TaxAssesessedValueAmt");
            Global.ConsoleOut("TaxAssesessedValueAmt Value : " + Global.Value);
            Global.Value = SeleniumGetMethods.GetTextValue(ElementType.Id, "LPI");
            Global.ConsoleOut("LPI Value : " + Global.Value);
            Global.Value = SeleniumGetMethods.GetTextValue(ElementType.Id, "CorpAdvancesAmt");
            Global.ConsoleOut("CorpAdvancesAmt Value : " + Global.Value);
            Global.Value = SeleniumGetMethods.GetTextValue(ElementType.Id, "EscrowAdvancesAmt");
            Global.ConsoleOut("EscrowAdvancesAmt Value : " + Global.Value);
            Global.Value = SeleniumGetMethods.GetTextValue(ElementType.Id, "HazardProceedsAmt");
            Global.ConsoleOut("HazardProceedsAmt Value : " + Global.Value);

            
            SeleniumWindowMethods.Sleep(2);


            Global.Cooldown();
            //Global.Done();

        }

    }

}

