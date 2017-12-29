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
    class Portal_Agent
    {
        public static void AcceptScheduleAppointment(Driver driver)
        {
            // Accept Schedule Appointment - Datetime Now
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsAppointmentPresent = false;
            while (IsAppointmentPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Schedule Appointment");
                    Global.ConsoleOut("Appointment Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 10)
                {
                    Global.ConsoleOut("Appointment Not Found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "AppointmentDate");
            SeleniumSetMethods.Click(driver, ElementType.Id, "AppointmentDate");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSubmit");
            SeleniumWindowMethods.Sleep(1);
            Global.ConsoleOut("Accepted Scheduled Appointment @: " + DateTime.Now);
            SeleniumWindowMethods.Sleep(2);
            Global.ConsoleOut("Manually run Amp Order sync now");

        }

        public static void OpenBPO(Driver driver)
        {
            // Open BPO Task
            Global.ConsoleOut("Opening BPO :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find BPO: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "BPO");
                    Global.ConsoleOut("BPO Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut("BPO not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenRentalAnalysis(Driver driver)
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening Rental Analysis :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Rental Analysis: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "Rental Analysis");
                    Global.ConsoleOut("Rental Analysis Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut("Rental Analysis not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void OpenREOTasks(Driver driver, string TaskName)
        {
            // Open Rental Analysis
            Global.ConsoleOut("Opening REO Task for Property Id :" + Global.OrderID + "  @: " + DateTime.Now);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Click(driver, ElementType.Id, "clearButton");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Address");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Address", Global.StreetAddress);

            int tries = 0;
            bool IsOrderPresent = false;
            while (IsOrderPresent == false)
            {
                try
                {
                    SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1"); // refreshing results
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find Task: " + TaskName + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, TaskName);
                    Global.ConsoleOut("REO Task: " + TaskName + " Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOut(TaskName + " not found");
                    break; // handle error and break/return
                }
                SeleniumWindowMethods.Sleep(25);
                SeleniumSetMethods.Click(driver, ElementType.LinkText, "Tasks");
                SeleniumWindowMethods.Sleep(5);
            }

        }

        public static void SendToClient(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnBpoSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnBpoSubmit");
        }

        public static void ProAgent(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtSearch", "Springfield");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtSearch");
            string taddress = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector, "#ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral");
            Global.ConsoleOut("Address: " + taddress);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtSearch", "34747");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlRadius_ddlClassifierValues", "10 Miles");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsPriceMin_ddlClassifierValues", "$100K");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsPriceMax_ddlClassifierValues", "$500K");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBeds_ddlClassifierValues", "3+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBaths_ddlClassifierValues", "3+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtMLS", "545646");
            /* Search By Property Type */
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "noneProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_6");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            /* Search By Listing Type */
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            /* Search By Property Status */
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingTypehead");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyStatushead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_chkStatusPreListed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_chkStatusPreListed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyStatushead");
            SeleniumWindowMethods.Sleep(2);
            /* Search By Additional Information */
            SeleniumSetMethods.Click(driver, ElementType.Id, "AdditionalInfohead");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsSqFt_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsSqFt_ddlClassifierValues", "2000+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsLotSize_ddlClassifierValues", "7500+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlYearBuilt", "1990");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 7 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 30 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 60 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 90 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 180 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Greater than 180 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_txtPropertyID", "25987");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxOnlyWithPhotos");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Oldest Listings");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Price - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Price - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Square feet - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Square feet - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Beds - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Beds - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Baths - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Baths - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Lot Size - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Lot Size - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Days on Market - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Days on Market - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Year Built - oldest to newest");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Year Built - newest to oldest");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Street Number - low to high");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Street Number - high to low");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "City - A to Z");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "City - Z to A");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Newest Listings");
            SeleniumWindowMethods.Sleep(3);

        }

    }

}
