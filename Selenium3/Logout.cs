using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Logout
    {
        public static void REO()
        {
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");

        }

        public static void ValPortal()
        {
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");

        }

        public static void Agent()
        {
            SeleniumSetMethods.Wait(ElementType.Id, "ctl00_ctl00_ctrHeader_LoginState1_hlLogout");
            SeleniumSetMethods.Click(ElementType.Id, "ctl00_ctl00_ctrHeader_LoginState1_hlLogout");

        }

        public static void Vendor()
        {
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Authentication/Logout']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Authentication/Logout']");

        }


    }


}
