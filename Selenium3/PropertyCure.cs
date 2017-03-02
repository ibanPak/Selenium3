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
    class PropertyCure
    {
        public static void Sample()
        {
            SeleniumSetMethods.Wait(ElementType.Id, "Filters_PropertyId");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyId", "212313");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_LoanNumber", Global.LoanNum);
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_LoanStatusLkUp > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.grid-col:nth-child(1) > div:nth-child(3) > div:nth-child(3) > label:nth-child(5) > input:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.Id, "topPane");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_ClientId > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.grid-col:nth-child(2) > div:nth-child(1) > div:nth-child(3) > label:nth-child(1) > input:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.Id, "topPane");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_OccupiedLkUp_192");
            SeleniumSetMethods.Click(ElementType.Id, "Filters_LitigationLegalLkUp_98");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_AcquisitionDateFrom", Global.LastYear);
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_AcquisitionDateTo", Global.LastMonth);
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyCity", "Irvine");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "Filters_PropertyCity", "");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Filters_LoanStatusLkUp > span");
            SeleniumSetMethods.Click(ElementType.CssSelector, "input.selectAll");

            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-2");

        }

    }

}
