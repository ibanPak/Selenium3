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
    class FormREOAssetMgrTasks
    {
        public static void CustomTask(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.iFrame(driver, "iframe");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#upload #input #inpFile"
             , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\Numbers\\1.jpg");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#DODSearch_Label #upload #input #inpFile"
             , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\Numbers\\2.jpg");

            //SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");

        }

    }

}
