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
    class Program
    {

        static void Main(string[] args)
        {
            DateTime d = DateTime.Today.Date;
            string StNum = d.ToString("MMdd").TrimStart('0');

            DateTime e = DateTime.Now;
            string Lnum = e.ToString("MMddyyHHmm").TrimStart('0');

            DateTime x = DateTime.Today.AddMonths(-1);
            string xDate = x.ToString("MM-dd-yy");

            IWebDriver driver = new ChromeDriver();
            PropertiesCollection.driver = driver;
            SeleniumWindowMethods.WindowActions(ActType.Maximize);

            /*********************************************************************************
            * 
            *      Start coding from below this
            * 
            * ******************************************************************************/

           




        }



    }




}
