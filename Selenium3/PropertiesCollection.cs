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
        //Auto-implemented properdty
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
        Dismiss,
        Wait

    }

    // Strongly Typed Variable
    enum ENV
    {
        QA,
        UAT,
        STG,
        PROD
        
    }

    // Strongly Typed Variable
    enum Portals
    {
        ValPortal,
        Agent,
        Vendor,
        REO,
        PropertyCure

    }
    
    // Strongly Typed Variable
    enum ProductTypes
    {
        Appraisal,
        BPO,
        RentalAnalysis

    }

    enum Products
    {
        Exterior,
        Interior

    }

    // Strongly Typed Variable
    enum Driver
    {
        driver1,
        driver2

    }

    // Strongly Typed Variable
    enum NumBrowsers
    {
        One,
        Two

    }

}
