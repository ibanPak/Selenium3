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

    class PropertiesCollection
    {
        //Auto-implemented property
        public static IWebDriver driver { get; set; }
        public static IWebDriver driver2 { get; set; }

    }

    // Strongly Typed Variable
    enum ElementType
    {
        Id,
        Name,
        LinkText,
        PartialLinkText,
        CssName,
        XPath,
        CssSelector

    }

    // Strongly Typed Variable
    enum ActType
    {
        Maximize,
        Close

    }

    // Strongly Typed Variable
    enum WinType
    {
        Popup,
        Main,
        iFrame
    }

    // Strongly Typed Variable
    enum Alert
    {
        Accept,
        Dismiss

    }

    // Strongly Typed Variable
    enum ENV
    {
        QA,
        UAT,
        STG,
        PROD
        
    }

}
