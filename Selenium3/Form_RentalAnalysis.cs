﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    class Form_RentalAnalysis
    {
        public static void ClearRA(Driver driver)
        {
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SubjectMarketing_SubjectPropertyUnits");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Marketing_OwnerPercentage");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Marketing_TenantPercentage");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_SchoolDistrict");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_NumActiveListingsInNhood");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_PriceRangeActiveListingsFrom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_PriceRangeActiveListingsTo");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Unified_NeighDetailsAddnlComments");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__StreetAddress");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__StreetAddress");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__StreetAddress");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__City");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__City");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__City");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__PostalCode");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__PostalCode");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__PostalCode");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SubjectMarketing_SubjectListPast12MoOriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_0__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_1__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_2__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SubjectMarketing_SubjectListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_0__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_1__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_2__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SubjectMarketing_SubjectDom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R1MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R2MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R3MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_PropertyView");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R1PropertyView");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R2PropertyView");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R3PropertyView");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_Rooms");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Rooms");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Rooms");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Rooms");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_Beds");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Beds");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Beds");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Beds");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_Baths");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Baths");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Baths");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Baths");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_GrossLivingArea");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__GrossLivingArea");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__GrossLivingArea");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__GrossLivingArea");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_Bsmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Bsmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Bsmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Bsmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Subject_FunctionalUtility");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__FunctionalUtility");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__FunctionalUtility");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__FunctionalUtility");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Unified_CheckListListing1Comments");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Unified_CheckListListing2Comments");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Unified_CheckListListing3Comments");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_EstimatedMarketRent");

        }

        public static void CompleteRA(Driver driver)
        {
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Begin input @ " + DateTime.Now);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.r-button.r-button-collapse-all");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.r-button.r-button-expand-all");
            SeleniumWindowMethods.ThrottlingSleep();

            // Kill maskMoney
            Global.ConsoleOut("Kill Money Mask");
            IJavaScriptExecutor js = PropertiesCollection.driver as IJavaScriptExecutor;
            string killmoneymask1 = (string)js.ExecuteScript("$(':input.maskMoney').maskMoney('destroy').attr('type', 'number').val('0')");
            string killmoneymask2 = (string)js.ExecuteScript("$(':input').maskMoney('destroy')");
            string killmoneymask3 = (string)js.ExecuteScript("$(':input.maskMoney').maskMoney('destroy').attr('type', 'number')");

            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SubjectMarketing_SubjectListPast12MoOriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_0__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_1__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PennyMac_SaleComps_2__OriginalListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SubjectMarketing_SubjectListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__ListPrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_0__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_1__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "SaleComps_2__SalePrice");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_0__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_1__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "ListComps_2__Dom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R1MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R2MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_R3MonthlyRentalAmt");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_PriceRangeActiveListingsFrom");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_PriceRangeActiveListingsTo");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Rental_EstimatedMarketRent");
            SeleniumSetMethods.Click(driver, ElementType.Id, "Unified_InspectedDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectMarketing_SubjectPropertyUnits", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PennyMac_Marketing_ReoTrend", "Increasing");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Rental_PredominantOccupancy_LookupId", "Owner");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Rental_MarketingTime_LookupId", "Under 3 Months");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Marketing_OwnerPercentage", "98");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Marketing_TenantPercentage", "2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_SchoolDistrict", "Irvine");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Rental_TenancyTrend_LookupId", "Increasing");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_NumActiveListingsInNhood", "6");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_PriceRangeActiveListingsFrom");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_PriceRangeActiveListingsFrom", "450000");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_PriceRangeActiveListingsFrom");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_PriceRangeActiveListingsTo", "600000");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_PriceRangeActiveListingsTo");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PennyMac_Marketing_VacancyPercentage", "0-5%");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Rental_NeighborhoodBlight", "No");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Unified_NeighDetailsAddnlComments", "Really good schools 10/10");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__StreetAddress", "101 Rose Arch");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__StreetAddress", "102 Rose Arch");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__StreetAddress", "103 Rose Arch");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__City", "Irvine");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__City", "Irvine");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__City", "Irvine");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_0__State", "California");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_1__State", "California");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_2__State", "California");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__PostalCode", "92620");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__PostalCode", "92620");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__PostalCode", "92620");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SubjectMarketing_SubjectListPast12MoOriginalListDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_0__OriginalListDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_1__OriginalListDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_2__OriginalListDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PennyMac_SubjectMarketing_SubjectListPast12MoOriginalListPrice", "500000");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SubjectMarketing_SubjectListPast12MoOriginalListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PennyMac_SaleComps_0__OriginalListPrice", "500001");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_0__OriginalListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PennyMac_SaleComps_1__OriginalListPrice", "500002");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_1__OriginalListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PennyMac_SaleComps_2__OriginalListPrice", "500003");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "PennyMac_SaleComps_2__OriginalListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectMarketing_SubjectListPrice", "500004");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SubjectMarketing_SubjectListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__ListPrice", "500005");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListComps_0__ListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__ListPrice", "500006");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListComps_1__ListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__ListPrice", "500007");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListComps_2__ListPrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_0__SaleDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_1__SaleDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_2__SaleDate");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SaleComps_0__SalePrice", "500005");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_0__SalePrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SaleComps_1__SalePrice", "500006");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_1__SalePrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SaleComps_2__SalePrice", "500007");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "SaleComps_2__SalePrice");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubjectMarketing_SubjectDom", "30");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__Dom", "35");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__Dom", "40");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__Dom", "50");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_DateLeaseBegins");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R1DateLeaseBegins");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R2DateLeaseBegins");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R3DateLeaseBegins");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_DateLeaseExpires");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R1DateLeaseExpires");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R2DateLeaseExpires");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R3DateLeaseExpires");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Subject_DataSource", "MLS");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_0__DataSource", "MLS");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_1__DataSource", "MLS");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_2__DataSource", "MLS");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_MonthlyRentalAmt", "2500");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_MonthlyRentalAmt");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R1MonthlyRentalAmt", "2501");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R1MonthlyRentalAmt");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R2MonthlyRentalAmt", "2502");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R2MonthlyRentalAmt");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R3MonthlyRentalAmt", "2503");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_R3MonthlyRentalAmt");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Subject_LocationType");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Subject_LocationType", "Suburban");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#Subject_LocationType > option[value=\"2\"]");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_0__LocationType", "Suburban");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_1__LocationType", "Suburban");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_2__LocationType", "Suburban");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_PropertyView", "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R1PropertyView", "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R2PropertyView", "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_R3PropertyView", "1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "Subject_Condition", "Excellent");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_0__Condition", "Good");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_1__Condition", "Good");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ListComps_2__Condition", "Average");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_Rooms", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__Rooms", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__Rooms", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__Rooms", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_Beds", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__Beds", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__Beds", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__Beds", "3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_Baths", "2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__Baths", "2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__Baths", "2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__Baths", "2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_GrossLivingArea", "1200");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__GrossLivingArea", "1300");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__GrossLivingArea", "1400");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__GrossLivingArea", "1500");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_Bsmt", "100");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__Bsmt", "200");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__Bsmt", "300");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__Bsmt", "400");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Subject_FunctionalUtility", "Pool");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_0__FunctionalUtility", "Deck");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_1__FunctionalUtility", "Patio");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListComps_2__FunctionalUtility", "Door");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Unified_CheckListListing1Comments", "Lease Comment 1");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Unified_CheckListListing2Comments", "Lease Comment 2");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Unified_CheckListListing3Comments", "Lease Comment 3");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Rental_EstimatedMarketRent", "2567");
            SeleniumWindowMethods.ThrottlingSleep();
            SeleniumSetMethods.Click(driver, ElementType.Id, "Rental_EstimatedMarketRent");
            SeleniumWindowMethods.ThrottlingSleep();

        }

        public static void Attachments(Driver driver, ENV environment)
        {
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "button.r-button.r-button-expand-all");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "button.r-button.r-button-expand-all");

            // Add Exterior Attachments to RA Order
            Global.ConsoleOut("Begin adding Attachments at " + DateTime.Now);
            if (environment == ENV.QA)
            {
                SeleniumSetMethods.Clear(driver, ElementType.Id, "37_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "37_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C1.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "38_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "38_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C2.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "44_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "44_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C3.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "45_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "45_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C4.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "46_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "46_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C5.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "47_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "47_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "48_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "48_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "49_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "49_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "97_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "97_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "productUpload_159_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "productUpload_159_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
            }
            else if (environment == ENV.UAT)
            {
                SeleniumSetMethods.Clear(driver, ElementType.Id, "15_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "15_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C1.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "16_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "16_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C2.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "22_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "22_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C3.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "23_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "23_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C4.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "24_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "24_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\C5.jpg");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "32_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "32_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "33_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "33_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "34_1_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "34_1_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "1543_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.EnterText(driver, ElementType.Id, "1543_fileupload", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
                SeleniumWindowMethods.ThrottlingSleep();
                SeleniumSetMethods.Clear(driver, ElementType.Id, "1544_fileupload");
                SeleniumWindowMethods.ThrottlingSleep();

            }

            // Complete Attachment Section
            Global.ConsoleOut("Start praying for the next 30 seconds, beginning at  " + DateTime.Now);
            SeleniumWindowMethods.Sleep(30);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".r-footer > div:nth-child(1) > div:nth-child(1) > button:nth-child(3)");
            Global.ConsoleOut("Submit button Clicked " + DateTime.Now);
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[9]");
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(5);

        }

    }

}
