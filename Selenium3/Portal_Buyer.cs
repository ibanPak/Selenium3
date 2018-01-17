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
    class Portal_Buyer
    {

        public static void Search(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(Driver.driver1, "https://qa-buyer.res.net");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "34747");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumWindowMethods.ScreenShot(driver, "SoPurdy");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Springfield");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "34747, Reunion, FL");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "30004");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "withinRadius");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "minPrice");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "minPrice", "$100K");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "maxPrice");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "maxPrice", "$250K");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "minBeds");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "minBeds", "3+");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "minBaths");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "minBaths", "3+");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "MLSNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MLSNumber", "LO7793433");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "90210");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "withinRadius");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertytypeChk10");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyTypeAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyTypeAll");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyListingsNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyListingsNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "listingTypeChk2");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyListingsAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyListingsAll");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusNone");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(driver, ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(driver, ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusChk6");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyStatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertyStatusAll");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "minSqFt");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "minSqFt", "1000+");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "minLotSize");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "minLotSize", "4000+");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "yearBuilt");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "yearBuilt", "1960");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");

        }

        public static void GeneralHome(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(Driver.driver1, "https://qa-buyer.res.net/");

            // Buyer Portal - General - Home - Test Case 1
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Support");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Support");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Register");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Register");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#comm100-button-138 > a > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#comm100-button-138 > a > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            Global.ConsoleOutTab("Window Title: " + PropertiesCollection.driver.Title);
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.iFrame(driver, "chat_window_container");
            
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.box-field:nth-child(1) > div:nth-child(2) > div:nth-child(1) > input:nth-child(1)");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.box-field:nth-child(1) > div:nth-child(2) > div:nth-child(1) > input:nth-child(1)", "Name");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.box-field:nth-child(2) > div:nth-child(2) > div:nth-child(1) > input:nth-child(1)", "Company");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.box-field:nth-child(3) > div:nth-child(2) > div:nth-child(1) > input:nth-child(1)", "Phone");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.box-field:nth-child(4) > div:nth-child(2) > div:nth-child(1) > input:nth-child(1)", "email@email.com");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.CssSelector, ".select", "Homeowner Portal");

            /* Live Chat - Need to figure out how to click 
            
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#comm100-button-138img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#comm100-button-138img");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            */
            // Find a Home Slider

            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.mosaic-block:nth-child(1) > div:nth-child(1) > img:nth-child(3)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > b");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumWindowMethods.Sleep(3);
            // Find An Agent Slider
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#slider > div:nth-child(2) > div.mosaic-overlay > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#slider > div:nth-child(2) > div.mosaic-overlay > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#slider > div:nth-child(2) > div.mosaic-backdrop > div > div.align-center > div > a");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            // Are You An Agent Slider
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#slider > div:nth-child(3) > div.mosaic-overlay > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#slider > div:nth-child(3) > div.mosaic-overlay > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#slider > div:nth-child(3) > div.mosaic-backdrop > div > div.align-center > div > a");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Hours");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Hours");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(2) > img:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(2) > img:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(3) > img:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(3) > img:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(4) > img:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(4) > img:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(5) > img:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".Icon-Social > a:nth-child(5) > img:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            // Footer
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[1]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[1]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[2]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[3]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[3]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[4]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[5]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[1]/a[5]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[1]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[1]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[2]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[3]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[3]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[4]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[5]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[3]/div[1]/div[2]/a[5]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Homeowners");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Homeowners");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Real Estate Agents");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Real Estate Agents");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Asset Managers");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Asset Managers");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Short Sale Specialist");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Short Sale Specialist");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Vendors");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Vendors");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "About Us");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "About Us");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Management Profiles");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Management Profiles");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Press Room");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Press Room");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Careers");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Careers");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Contact Us");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Contact Us");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".footerFollowUs > p:nth-child(1) > a:nth-child(1) > img:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".footerFollowUs > p:nth-child(1) > a:nth-child(1) > img:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".support > a:nth-child(3)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".support > a:nth-child(3)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".trustkeeper");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".trustkeeper");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Privacy Policy");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Privacy Policy");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Terms of Use");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Terms of Use");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            // Test Ended Close Window

        }

        public static void LoginGeneral(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(Driver.driver1, "https://qa-buyer.res.net/");

            // Buyer Portal - Login Validation - Test Case 4

            // Login Pages
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Login");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Register");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Register");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Login");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Problems Signing In?");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Problems Signing In?");
            // Test Ended Close Window

        }

        public static void LoginValidation(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Login Pages
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Click(driver, ElementType.Id, "submitForm");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Login");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UsernameOrEmail", "123");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PasswordLogin", "abc");
            SeleniumSetMethods.Click(driver, ElementType.Id, "submitForm");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UsernameOrEmail", "qapaidbuyer03");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PasswordLogin", "P@SSW0RD1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "submitForm");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "UsernameOrEmail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UsernameOrEmail", "qapaidbuyer03");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PasswordLogin", "P@ssw0rd1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "submitForm");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "My Account");
            // Test Ended Close Window

        }

        public static void PrelistAlerts(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Prelist Alerts
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Fresno, CA");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#showNewPreslitAlertsLink > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#showNewPreslitAlertsLink > img");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Qa");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "LastName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", "Test");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", "QaTest55@usres.com");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Cancel");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Cancel");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#showNewPreslitAlertsLink > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#showNewPreslitAlertsLink > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#prelistAlertBoxSubmit > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#prelistAlertBoxSubmit > span");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#prelistAlertBox > div:nth-child(1) > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#prelistAlertBox > div:nth-child(1) > a");

            // Test Ended Close Window

        }

        public static void SearchBreadcrumbs(Driver driver)
        {

            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Search Results Breadcrumbs Needs to be run with Login
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "60175");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Saint Charles");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Saint Charles");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Kane County");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Kane County");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Illinois");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Illinois");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Find Homes");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Find Homes");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Home");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Home");

            // Test Ended Close Window

        }
        public static void SortResults(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Sort Search Results - Needs to be run with Login
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Springfield");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Oldest Listings");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Price - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Price - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Square feet - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Square feet - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Beds - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Beds - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Baths - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Baths - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Lot Size - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Lot Size - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Square feet - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Square feet - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "More Options");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Less Options");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Days on Market - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Days on Market - high to low");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Year Built - oldest to newest");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Year Built - newest to oldest");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Street Number - low to high");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "SortOption");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SortOption", "Street Number - high to low");
            SeleniumWindowMethods.Sleep(2);

            // Test Ended Close Window

        }

        public static void Map(Driver driver)
        {

            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Search Results Map Needs to be run with Login
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Brooklyn, NY");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "toggleMapMap");
            SeleniumSetMethods.Click(driver, ElementType.Id, "toggleMapMap");
            SeleniumWindowMethods.Sleep(4);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "map-container");
            SeleniumSetMethods.Click(driver, ElementType.Id, "map-container");
            SeleniumWindowMethods.Sleep(4);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "View");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "View");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Brooklyn");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Brooklyn");

            // Test Ended Close Window

        }

        public static void PrelistNonMember(Driver driver)
        {
            // Login with Basic User Needs to Run First
            // Pre-List Get Complete Address - View Now
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Brooklyn, NY");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#TrustWaveLogo > #trustwaveSealImage");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#TrustWaveLogo > #trustwaveSealImage");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".terms-of-use > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".terms-of-use > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)");
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".terms-of-use > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(2)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".terms-of-use > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(2)");
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.muteGreen");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.muteGreen");
            SeleniumWindowMethods.Sleep(3);
            // Pre-List Get Complete Address - View Now Log in As Free Buyer
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Brooklyn, NY");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "UsernameOrEmail");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "UsernameOrEmail", "testbuyer");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "PasswordLogin");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PasswordLogin", "P@ssw0rd1");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.muteGreen");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.muteGreen");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Logout");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Logout");
            // Register as Elite Buyer 
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.customDialogueClass.ui-dialog-buttons.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.Positive-Primary.floatLeft > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.customDialogueClass.ui-dialog-buttons.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.Positive-Primary.floatLeft > span");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#logo > a > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#logo > a > img");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Brooklyn, NY");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            // Registration Page 1
            string UVar = DateTime.Now.ToString("MMddHHmm").TrimStart('0');
            SeleniumSetMethods.Wait(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", "Qa");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", "Test");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SignupEmail", "qa" + UVar + "@usres.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SignupZipCode", "06450");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Username", "qa" + UVar + "@usres.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", "P@ssw0rd1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ConfirmPassword", "P@ssw0rd1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DescriptionID", "Other");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnSignup");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSignup");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId", "Visa");
            // Registration Page 2
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input");
            SeleniumSetMethods.EnterText(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input", "4556107422503600");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BillingInfo_ExpirationMonth");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_ExpirationMonth", "07");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_ExpirationYear", "2025");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_OriginalCvvCode", "123");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_NameOnCard", "Qa Test");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingAddress", "123 Main St");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingCity", "Dover");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingState_Code", "Delaware");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingZip", "19901");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnBilling");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "button.muteGreen");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.muteGreen");
            SeleniumWindowMethods.Sleep(3);
            // User Sees Addresses After Sign Up As Elite
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Brooklyn, NY");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > span:nth-child(1) > b:nth-child(1)");

            // Test Ended Close Window

        }

        public static void PrelistBasicMember(Driver driver)
        {

            // Navigate to web page
            // Pre-List Get Complete Address - View Now
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Atlanta, GA");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > span > b");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            // Registration Page 2
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_CreditCardType_CodeId", "Visa");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input");
            SeleniumSetMethods.EnterText(driver, ElementType.XPath, "/html/body/div[1]/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/span[1]/input", "4556107422503600");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_ExpirationMonth", "07");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_ExpirationYear", "2025");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_OriginalCvvCode", "123");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_NameOnCard", "Qa Test");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingAddress", "123 Main St");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingCity", "Dover");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingState_Code", "Delaware");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BillingInfo_BillingZip", "19901");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnBilling");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#goHome > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#goHome > span > b");
            SeleniumWindowMethods.Sleep(3);
            // User Sees Addresses After Sign Up As Elite
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Atlanta, GA");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > span > b");
            // Need to Cancel User when Test is done

            // Test Ended Close Window

        }


        public static void PrelistEliteMember(Driver driver)
        {

            // Navigate to web page
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Hampshire County, MA");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "RequestShowing");
            SeleniumSetMethods.Click(driver, ElementType.Id, "RequestShowing");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ShowingRequest_OfficePhone");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_OfficePhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_OfficePhone", "5555555555");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_PreferredContactType_ID", "Phone");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_PreferredShowingDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_PreferredShowingDate", "12/01/2018");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_RequestedShowingTime");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_RequestedShowingTime", "2:30 pm");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#submitRequestShowing > span");

            // Test Ended Close Window

        }

        public static void PropDetailsBreadcrumbs(Driver driver)
        {

            // Navigate to web page
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Chicago, IL");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".last");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".last");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(7)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(7)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(6)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(6)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(5)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(5)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(4)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(4)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(3)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(3)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(2)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(2)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");

            // Test Ended Close Window

        }

        public static void PropDetailsIconsNonMember(Driver driver)
        {

            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Login Pages
            // Favorite Icon
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "01089");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.favorite");
            SeleniumWindowMethods.Sleep(3);
            // Request Showing
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "33140");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "RequestShowing");
            SeleniumSetMethods.Click(driver, ElementType.Id, "RequestShowing");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ShowingRequest_Name");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_Name", "QA Test");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_Email", "QATest1@usres.com");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_OfficePhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_OfficePhone", "5555555555");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_PreferredContactType_ID", "Phone");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_PreferredShowingDate");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_PreferredShowingDate", "12/10/2018");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ShowingRequest_RequestedShowingTime");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_RequestedShowingTime", "12:15 PM");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ShowingRequest_Questions", "Testing Automation - Nonmember Icons");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#submitRequestShowing > span");
            SeleniumWindowMethods.Sleep(5);
            // Offer Icon
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "01923");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.offer");
            SeleniumWindowMethods.Sleep(3);
            // Inquiry Icon
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "33140");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PurchaseInquiry");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PurchaseInquiry");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Name");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Name", "QA Test");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", "QATest1@usres.com");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "HomePhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "HomePhone", "5555555555");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#A1 > span");
            SeleniumWindowMethods.Sleep(3);
            // Share Icon
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "01089");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.share");
            SeleniumWindowMethods.Sleep(3);
            // Print Icon 
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "33140");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            // Map Property Tab
            SeleniumSetMethods.Wait(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(driver, ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "33140");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propertiesSubmit > img");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#propResultsContainer > div > div:nth-child(2) > div.displayDetails > div.listDetails > h2 > a");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#tab_map > a > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#tab_map > a > span > b");
            SeleniumWindowMethods.Sleep(3);
            // Streetview Property Tab 
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_streetview");
            SeleniumWindowMethods.Sleep(3);
            // Photos Property Tab 
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_photos");
            SeleniumWindowMethods.Sleep(3);
            // Agent Property Tab 
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_agent");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#box_agent > div.paddedBox > div > div.info > h3 > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#box_agent > div.paddedBox > div > div.info > h3 > a");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#A1 > span");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#A1 > span");

            // Test Ended Close Window

        }

        public static void PropDetailsIconsMember(Driver driver)
        {
            // Find Property
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "New York, NY");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Boca Raton, FL");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Favorite 
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".favorite");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".favorite");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".breadcrumb > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Boca Raton, FL");
            SeleniumSetMethods.Click(driver, ElementType.Id, "NotListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Request Showing
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#RequestShowing");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#RequestShowing");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "cancelRequestShowing");
            SeleniumSetMethods.Click(driver, ElementType.Id, "cancelRequestShowing");
            SeleniumWindowMethods.Sleep(3);
            // Offer
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.offer");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.offer");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PurchaseInquiryVM_PurchaseInquiry_HomePhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_PurchaseInquiry_HomePhone", "5555555555");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_PurchaseInquiry_CellPhone", "5555555555");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_PurchaseInquiry_PreferredContactType_ID", "Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Purchase_Enquiry_Has_Offer", "Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_Offer_OfferDate", "01/10/2018");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#ui-datepicker-div > div.ui-datepicker-buttonpane.ui-widget-content > button.ui-datepicker-close.ui-state-default.ui-priority-primary.ui-corner-all");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_Offer_OfferPrice", "182500");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Working_With_Realtor_Option", "No");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PurchaseInquiryVM_PurchaseInquiry_Questions", "Testing Automation Script");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.editBox:nth-child(4) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > a:nth-child(1) > span:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Inquiry
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PurchaseInquiry");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PurchaseInquiry");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "HomePhone");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "HomePhone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "HomePhone", "5555555555");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Questions", "Testing Elite Buyer icons with Automation");
            SeleniumSetMethods.Click(driver, ElementType.Id, "submitContactAgent");
            SeleniumWindowMethods.Sleep(5);
            // Share
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.share");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.share");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyShareEmailAddress");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "propertyShareEmailAddress", "qatest100@usres.com");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#shareProperty > span > b");
            SeleniumWindowMethods.Sleep(3);
            // Print 
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            // Connections
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_connections");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_connections");
            // Map and Street View
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_map");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_streetview");
            SeleniumWindowMethods.Sleep(3);
            // Photos
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_photos");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#box_photos > div.paddedBox > ul > li:nth-child(1) > a > img");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#box_photos > div.paddedBox > ul > li:nth-child(1) > a > img");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "body > div.pp_pic_holder.facebook > div.pp_content_container > div > div > div > div.pp_fade > div.pp_details.clearfix > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div.pp_pic_holder.facebook > div.pp_content_container > div > div > div > div.pp_fade > div.pp_details.clearfix > a");
            // Notes
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_mynotes");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_mynotes");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PropertyNote_Note");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyNote_Note", "testing automation");
            SeleniumSetMethods.Click(driver, ElementType.Id, "addNote");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Share");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Share");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyNoteEmailAddress");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "propertyNoteEmailAddress", "qatest100@usres.com");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#sendEmail > span:nth-child(1) > b:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "DeletePropertyNoteLnk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "DeletePropertyNoteLnk");
            SeleniumWindowMethods.Sleep(3);
            // Offer
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_offers");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_offers");
            SeleniumWindowMethods.Sleep(3);
            // Documents
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_documents");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_documents");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add Document");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add Document");
            SeleniumSetMethods.Click(driver, ElementType.Id, "isPrivate");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "fileData", "C:\\Users\\bonnie.homer\\Desktop\\house.jpg");
            SeleniumSetMethods.Click(driver, ElementType.Id, "uploadForm_submitBtn");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "Documents.File.Description");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Documents.File.Description", "test jpg");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmitDocuments");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Add Document");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Add Document");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "fileData", "C:\\Users\\bonnie.homer\\Desktop\\Test upload.pdf");
            SeleniumSetMethods.Click(driver, ElementType.Id, "uploadForm_submitBtn");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "Documents.File.Description");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "Documents.File.Description", "test PDF");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmitDocuments");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "eSign");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "eSign");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "pageImg1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnMenuSignName");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnPageSignDone");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div > button");
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Pager_DisplayRows");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[1]/div/div[5]/div[10]/div[1]/div/fieldset/div[2]/div/div[2]/table/tbody/tr[1]/td[9]/div/a[1]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='targetGrid']/div[2]/table/tbody/tr[1]/td[9]/div/a[2]/i");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.modal-footer:nth-child(2) > button:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.modal-footer:nth-child(2) > button:nth-child(1)");
            // Messages
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_messages");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_messages");
            SeleniumWindowMethods.Sleep(3);
            // Remove Favorite Property
            SeleniumSetMethods.Click(driver, ElementType.Id, "myHomeTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "/html/body/div[1]/div/div[2]/div[2]/div[5]/div[2]/div[1]/div[1]/div[2]/div[2]/a[1]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "/html/body/div[1]/div/div[2]/div[2]/div[5]/div[2]/div[1]/div[1]/div[2]/div[2]/a[1]");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.customDialogueClass.ui-dialog-buttons.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.Positive-Primary.floatLeft");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.customDialogueClass.ui-dialog-buttons.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.Positive-Primary.floatLeft");

            // Test Ended Close Window

        }

        public static void PropDetailsPrelistEliteMember(Driver driver)
        {
            // Find Property - Must Login as Elite Member First
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "New Orleans, LA");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListedOnMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(2) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_map");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_map");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_streetview");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".share");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertyShareEmailAddress");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "propertyShareEmailAddress", "bonnie.homer@usres.com");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#shareProperty > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#shareProperty > span:nth-child(1) > b:nth-child(1)");
            SeleniumWindowMethods.Sleep(3);
            // Print
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            // Prelist with Address
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "location");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "location", "Lafayette, LA");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(4) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(4) > div:nth-child(2) > div:nth-child(4) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "tab_map");
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_map");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "tab_streetview");
            SeleniumWindowMethods.Sleep(3);
            // Print 
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#mainColumnLeft > div:nth-child(3) > table > tbody > tr > td:nth-child(2) > ul > li.print");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumWindowMethods.Sleep(3);
            SeleniumWindowMethods.WindowActions(driver, ActType.Close);

            // Test Ended Close Window

        }

        public static void AgentSearchNonMember(Driver driver)
        {
            // Navigate to web page
            SeleniumSetMethods.Navigate(driver, "https://qa-buyer.res.net/");

            // Login Pages
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#agentsTabLink > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#agentsTabLink > span > b");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#agentSearchOptionContainer > a:nth-child(1) > img:nth-child(1)");
            // Need to Manually Click in the Location text box 
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.paddedBoxSearchArea:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > input:nth-child(2)");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.paddedBoxSearchArea:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > input:nth-child(2)", "92648");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumWindowMethods.Sleep(3);
            // Radius 
            SeleniumSetMethods.Wait(driver, ElementType.Id, "withinRadius");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#search_pagination > div > ul > li:nth-child(2) > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#search_pagination > div > ul > li:nth-child(2) > a");
            SeleniumWindowMethods.Sleep(3);
            // Name
            SeleniumSetMethods.Wait(driver, ElementType.Id, "name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "name", "Bonnie");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumWindowMethods.Sleep(3);
            // Company
            SeleniumSetMethods.Wait(driver, ElementType.Id, "company");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "company", "B");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(1) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(2) > li:nth-child(1) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(1) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(2) > li:nth-child(1) > h2:nth-child(1) > a:nth-child(1)");

            // Test Ended Close Window

        }

        public static void AgentSearchMember(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#agentsTabLink > span > b");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#agentsTabLink > span > b");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#agentsSubmit > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#agentsSubmit > span:nth-child(1) > b:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.paddedBoxSearchArea:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > input:nth-child(2)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.paddedBoxSearchArea:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > input:nth-child(2)");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "div.paddedBoxSearchArea:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > input:nth-child(2)", "90210");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search");
            SeleniumWindowMethods.Sleep(3);
            // Radius
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#search_pagination > div > ul > li:nth-child(2) > a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#search_pagination > div > ul > li:nth-child(2) > a");
            SeleniumWindowMethods.Sleep(3);
            // Name
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "name", "a");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumWindowMethods.Sleep(3);
            //Company             
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "company", "r");
            SeleniumWindowMethods.Sleep(3);
            // Photo 
            SeleniumSetMethods.Click(driver, ElementType.Id, "AHasPhoto");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.searchbtn > #agentsSubmit > span > b");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.displayUnit:nth-child(1) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(2) > li:nth-child(1) > h2:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.displayUnit:nth-child(1) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(2) > li:nth-child(1) > h2:nth-child(1) > a:nth-child(1)");

            // Test Ended Close Window

        }

    }

}
