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
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            //SeleniumWindowMethods.Sleep(1);
            //SeleniumWindowMethods.iFrame(driver, "iframe");
            //SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#upload #input #inpFile"
            // , Global.folderpath + "Numbers\\1.jpg");
            //SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#DODSearch_Label #upload #input #inpFile"
            // , Global.folderpath + "Numbers\\2.jpg");

        }

        public static void CustomTask2(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Test1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Test1", "yellow");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateAsDone");

        }

        public static void UpdateAsDone(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateAsDone");

        }

    }

}
