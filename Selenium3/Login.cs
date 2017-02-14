using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Login
    {

        public static void qaAgent()
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("https://qa-agent.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "username");
            SeleniumSetMethods.EnterText(ElementType.Id, "username", "QATest23@usres.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "password", "blue123");
            SeleniumSetMethods.Click(ElementType.Name, "btnLogin");

        }

        public static void qaValPortal()
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://qa-valuation.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", "test");
            SeleniumSetMethods.EnterText(ElementType.Id, "password", "P@ssw0rd1");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");

        }

        public static void qaREO()
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://qa-valuation.res.net/");

            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", "test");
            SeleniumSetMethods.EnterText(ElementType.Id, "password", "P@ssw0rd1");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");


        }

        public static void ScheduledTasks()
        {
            // Navigate to URL
            SeleniumSetMethods.Navigate("http://autodeploy.res.net/Portal/ScheduledTasks?env=QA&portalsOnly=true&portalsOnly=false");
/*
            // Login Page
            SeleniumSetMethods.Wait(ElementType.Id, "usernameEmail");
            SeleniumSetMethods.EnterText(ElementType.Id, "usernameEmail", "test");
            SeleniumSetMethods.EnterText(ElementType.Id, "password", "P@ssw0rd1");
            SeleniumSetMethods.Click(ElementType.Id, "btnSubmitLogin");
*/

        }




    }


}