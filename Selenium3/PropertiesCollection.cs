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
        public static IWebDriver driver1 { get; set; }
        public static IWebDriver driver2 { get; set; }

    }

    // Strongly Typed Variable
    enum ElementType
    {
        Id,
        Name,
        LinkText,
        PartialLinkText,
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
        PROD,
        BUILD

    }

    // Strongly Typed Variable
    enum Portals
    {
        ValPortal,
        Agent,
        Vendor,
        REO,
        PropertyCure,
        Buyer

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

    enum CreditCardType
    {
        Amex,
        Discover,
        MasterCard1,
        MasterCard2,
        Visa

    }

    enum City
    {
        Essex,
        Irvine1,
        Irvine2,
        IrvineGCFail,
        Melvindale,
        ModestoGCFail,
        Naples

    }

}
