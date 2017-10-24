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

        public static void WindowActions(Driver driver, ActType windowsactions)
        {
            // Driver 1
            if (driver == Driver.driver1 && windowsactions == ActType.Maximize)
            {
                PropertiesCollection.driver.Manage().Window.Maximize();

            }

            else if (driver == Driver.driver1 && windowsactions == ActType.Close)
            {
                PropertiesCollection.driver.Close();
   
            }

            // Driver 2
            else if (driver == Driver.driver2 && windowsactions == ActType.Maximize)
            {
                PropertiesCollection.driver2.Manage().Window.Maximize();

            }

            else if (driver == Driver.driver2 && windowsactions == ActType.Close)
            {
                PropertiesCollection.driver2.Close();

            }

        }

        public static void WindowType(Driver driver, WinType windowsactions)
        {
            // Driver 1
            if (driver == Driver.driver1 && windowsactions == WinType.Popup)
            {
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());

            }

            else if (driver == Driver.driver1 && windowsactions == WinType.Main)
            {
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.First());

            }

            // Driver 2
            else if (driver == Driver.driver2 && windowsactions == WinType.Popup)
            {
                PropertiesCollection.driver2.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());

            }

            else if (driver == Driver.driver2 && windowsactions == WinType.Main)
            {
                PropertiesCollection.driver2.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.First());

            }

        }

        public static void iFrame(Driver driver, string Frame)
        {
            // Driver 1
            if (driver == Driver.driver1)
            {
                PropertiesCollection.driver.SwitchTo().Frame(Frame);
            }

            // Driver 2
            else if (driver == Driver.driver2)
            {
                PropertiesCollection.driver2.SwitchTo().Frame(Frame);
            }

        }

        public static void ScreenShot(Driver driver, string FileName)
        {
            // Driver 1
            if (driver == Driver.driver1)
            {
                Screenshot ss = ((ITakesScreenshot)PropertiesCollection.driver).GetScreenshot();
                string filename = "c:/" + FileName + "_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
                ss.SaveAsFile(filename, ScreenshotImageFormat.Png);
                Global.ConsoleOut("Screen Shoot Captured: " + filename);
            }
            
            // Driver 2
            else if (driver == Driver.driver2)
            {
                Screenshot ss = ((ITakesScreenshot)PropertiesCollection.driver2).GetScreenshot();
                string filename = "c:/" + FileName + "_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
                ss.SaveAsFile(filename, ScreenshotImageFormat.Png);
                Global.ConsoleOut("Screen Shoot Captured: " + filename);
            }

        }

        public static void Sleep(int sec)
        {
            System.Threading.Thread.Sleep(sec * (1000));
   
        }

        public static void ThrottlingSleep()
        {
            System.Threading.Thread.Sleep(Global.ThrottleSleep);

        }

        public static void Assertion(Driver driver, Alert alert)
        {
            // Driver 1
            if (driver == Driver.driver1 && alert == Alert.Accept)
            {
                PropertiesCollection.driver.SwitchTo().Alert().Accept();

            }
               
            else if (driver == Driver.driver1 && alert == Alert.Dismiss)
            {
                PropertiesCollection.driver.SwitchTo().Alert().Dismiss();

            }
                
            else if (driver == Driver.driver1 && alert == Alert.Wait)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.AlertIsPresent());

            }

            // Driver 2
            else if (driver == Driver.driver2 && alert == Alert.Accept)
            {
                PropertiesCollection.driver2.SwitchTo().Alert().Accept();

            }

            else if (driver == Driver.driver2 && alert == Alert.Dismiss)
            {
                PropertiesCollection.driver2.SwitchTo().Alert().Dismiss();

            }

            else if (driver == Driver.driver2 && alert == Alert.Wait)
            {
                WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver2, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.AlertIsPresent());

            }


        }

    }

}