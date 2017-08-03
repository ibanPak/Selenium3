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
    class SeleniumWindowMethods2
    {

        public static void WindowActions(ActType windowsactions)
        {
            if (windowsactions == ActType.Maximize)
                PropertiesCollection.driver2.Manage().Window.Maximize();

            if (windowsactions == ActType.Close)
                PropertiesCollection.driver2.Close();

        }

        public static void WindowType(WinType windowsactions)
        {

            if (windowsactions == WinType.Popup)
                PropertiesCollection.driver2.SwitchTo().Window(PropertiesCollection.driver2.WindowHandles.Last());

            if (windowsactions == WinType.Main)
                PropertiesCollection.driver2.SwitchTo().Window(PropertiesCollection.driver2.WindowHandles.First());

        }

        public static void iFrame(string Frame)
        {
            PropertiesCollection.driver2.SwitchTo().Frame(Frame);

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
            System.Threading.Thread.Sleep(350);

        }

        public static void Assertion(Alert alert)
        {
            if (alert == Alert.Accept)
                PropertiesCollection.driver2.SwitchTo().Alert().Accept();

            if (alert == Alert.Dismiss)
                PropertiesCollection.driver2.SwitchTo().Alert().Dismiss();

        }


    }


}