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
    class Buyer
    {

        public static void Search()
        {
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "34747");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumWindowMethods.ScreenShot("SoPurdy");
            SeleniumSetMethods.Wait(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "Springfield");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "34747, Reunion, FL");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(ElementType.Id, "logoBP");
            SeleniumSetMethods.Click(ElementType.Id, "logoBP");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesTabLink");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "30004");
            SeleniumSetMethods.Wait(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(ElementType.Id, "withinRadius");
            SeleniumSetMethods.EnterText(ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "minPrice");
            SeleniumSetMethods.EnterText(ElementType.Id, "minPrice", "$100K");
            SeleniumSetMethods.Wait(ElementType.Id, "maxPrice");
            SeleniumSetMethods.EnterText(ElementType.Id, "maxPrice", "$250K");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "minBeds");
            SeleniumSetMethods.EnterText(ElementType.Id, "minBeds", "3+");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "minBaths");
            SeleniumSetMethods.EnterText(ElementType.Id, "minBaths", "3+");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(ElementType.Id, "MLSNumber");
            SeleniumSetMethods.EnterText(ElementType.Id, "MLSNumber", "LO7793433");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Click(ElementType.Id, "clearPropertiesSearch");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "90210");
            SeleniumSetMethods.Wait(ElementType.Id, "withinRadius");
            SeleniumSetMethods.EnterText(ElementType.Id, "withinRadius", "50 Miles");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeNone");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeNone");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk1");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk2");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk7");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk9");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk13");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk5");
            SeleniumSetMethods.Click(ElementType.Id, "propertytypeChk10");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyTypeAll");
            SeleniumSetMethods.Click(ElementType.Id, "propertyTypeAll");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyListingsNone");
            SeleniumSetMethods.Click(ElementType.Id, "propertyListingsNone");
            SeleniumSetMethods.Click(ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Click(ElementType.Id, "listingTypeChk1");
            SeleniumSetMethods.Click(ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Click(ElementType.Id, "propertyListingLink");
            SeleniumSetMethods.Wait(ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Click(ElementType.Id, "listingTypeChk3");
            SeleniumSetMethods.Click(ElementType.Id, "listingTypeChk2");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyListingsAll");
            SeleniumSetMethods.Click(ElementType.Id, "propertyListingsAll");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusNone");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusNone");
            SeleniumSetMethods.Wait(ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(ElementType.Id, "SearchPrelisted");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusChk2");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusChk3");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusChk6");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "propertyStatusAll");
            SeleniumSetMethods.Click(ElementType.Id, "propertyStatusAll");
            SeleniumSetMethods.Wait(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "minSqFt");
            SeleniumSetMethods.EnterText(ElementType.Id, "minSqFt", "1000+");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "minLotSize");
            SeleniumSetMethods.EnterText(ElementType.Id, "minLotSize", "4000+");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Wait(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "yearBuilt");
            SeleniumSetMethods.EnterText(ElementType.Id, "yearBuilt", "1960");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertySearchOptionContainer > form:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(9) > div:nth-child(2) > a:nth-child(1)");
            
        }

        public static void Sample()
        {
            // Sample Code to Execute
            String PropertyID = "507635";
            Global.OrderID = PropertyID;

            Login.qaBuyer("qapaidbuyer03", "P@ssw0rd1");

            SeleniumSetMethods.Wait(ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#propertiesTabLink > span > b");
            SeleniumSetMethods.Wait(ElementType.Id, "location");
            SeleniumSetMethods.EnterText(ElementType.Id, "location", "Atlanta, GA");
            SeleniumSetMethods.Click(ElementType.Id, "propertiesSubmit");
            SeleniumSetMethods.Wait(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Click(ElementType.Id, "additionalInfoLnk");
            SeleniumSetMethods.Wait(ElementType.Id, "searchPropertyID");
            SeleniumSetMethods.EnterText(ElementType.Id, "searchPropertyID", Global.OrderID);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.searchbtn > #propertiesSubmit > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.searchbtn > #propertiesSubmit > span > b");
            // Click on Property Returned
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Properties/Details/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Properties/Details/']");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#tab_offers > a > span > b");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#tab_offers > a > span > b");
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.expandable");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.expandable");
            // Click on First Offer
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#poffer_tbl > tbody > tr > td > a");
            SeleniumSetMethods.Click(ElementType.CssSelector, "#poffer_tbl > tbody > tr > td > a");
            SeleniumSetMethods.Wait(ElementType.Id, "offerAction");
            SeleniumSetMethods.EnterText(ElementType.Id, "offerAction", "Counter");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(ElementType.Id, "offerAction", "Counter");
            SeleniumSetMethods.Wait(ElementType.Id, "copyRecentOfferLink");
            SeleniumSetMethods.Click(ElementType.Id, "copyRecentOfferLink");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Clear(ElementType.CssSelector, "td[id=\"Offer#2\"] input[id$=\"__LoanAmount\"]");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(ElementType.CssSelector, "td[id=\"Offer#2\"] input[id$=\"__LoanAmount\"]", "300000.00");

        }


    }


}
