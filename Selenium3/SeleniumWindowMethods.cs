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
    class SeleniumWindowMethods
    {

        public static void WindowActions(ActType windowsactions)
        {
            if (windowsactions == ActType.Maximize)
                PropertiesCollection.driver.Manage().Window.Maximize();

            if (windowsactions == ActType.Close)
                PropertiesCollection.driver.Close();

        }

        public static void WindowType(WinType windowsactions)
        {

            if (windowsactions == WinType.Popup)
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());

            if (windowsactions == WinType.Main)
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.First());

        }

        public static void iFrame(string Frame)
        {
            PropertiesCollection.driver.SwitchTo().Frame(Frame);

        }

        public static void ScreenShot(string FileName)
        {
            Screenshot ss = ((ITakesScreenshot)PropertiesCollection.driver).GetScreenshot();
            ss.SaveAsFile("c:/" + FileName + ".png", ScreenshotImageFormat.Png);

        }

        public static void Sleep(int sec)
        {
            System.Threading.Thread.Sleep(sec * (1000));

        }

        public static void ThrottlingSleep()
        {
            System.Threading.Thread.Sleep(Global.ThrottleSleep);

        }

        public static void Assertion(Alert alert)
        {
            if (alert == Alert.Accept)
                PropertiesCollection.driver.SwitchTo().Alert().Accept();

            if (alert == Alert.Dismiss)
                PropertiesCollection.driver.SwitchTo().Alert().Dismiss();

        }


    }


}