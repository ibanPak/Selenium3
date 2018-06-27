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
            Global.ConsoleOut("Accepting Appointment:" + Global.OrderID + "  @: " + DateTime.Now);
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
                    Global.ConsoleOutTab("Attempting to Schedule Appointment: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Schedule Appointment");
                    Global.ConsoleOutTab("Appointment Found");
                    IsAppointmentPresent = true;
                    break;
                }
                catch (Exception)
                {
                    if (tries == 10)
                    {
                        Global.ConsoleOutAlert("Apoinment Not found & and MAX tries reached: " + tries);
                        break; // handle error and break/return
                    }
                    Global.ConsoleOutAlert("Appointment Not Found");
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
            Global.ConsoleOutTab("Accepted Scheduled Appointment @: " + DateTime.Now);
            SeleniumWindowMethods.Sleep(2);

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
                    Global.ConsoleOutTab("Attempting to find BPO: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "BPO");
                    Global.ConsoleOutTab("BPO Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception)
                {
                    if (tries == 10)
                    {
                        Global.ConsoleOutAlert("BPO Not found & and MAX tries reached: " + tries);
                        break; // handle error and break/return
                    }
                    Global.ConsoleOutAlert("BPO not found");
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
                    Global.ConsoleOutTab("Attempting to find Rental Analysis: " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, "Rental Analysis");
                    Global.ConsoleOutTab("Rental Analysis Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert("Rental Analysis not found");
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
                    Global.ConsoleOutTab("Attempting to find Task: " + TaskName + " " + tries + " Attempt(s)");
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.LinkText, TaskName);
                    Global.ConsoleOutTab("REO Task: " + TaskName + " Found");
                    IsOrderPresent = true;
                    break;
                }
                catch (Exception) { }
                if (tries == 15)
                {
                    Global.ConsoleOutAlert(TaskName + " not found");
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

            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtSearch", "Springfield");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtSearch");
            SeleniumGetMethods.DisplayTextContent(driver, ElementType.CssSelector, "#ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral", "Springfield Address validation");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtSearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtSearch", "34747");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlRadius_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlRadius_ddlClassifierValues", "10 Miles");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsPriceMin_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsPriceMin_ddlClassifierValues", "$100K");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsPriceMax_ddlClassifierValues", "$500K");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBeds_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBeds_ddlClassifierValues", "3+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBaths_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsBaths_ddlClassifierValues", "3+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtMLS");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtMLS", "545646");
            /* Search By Property Type */
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtMLS");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "txtMLS");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "noneProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_3");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_4");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
       
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_5");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyType_cblClassifierValues_6");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            /* Search By Listing Type */
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PropertyTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyTypehead");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ListingTypehead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingTypehead");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ListingNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingNone");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListListingType_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
            SeleniumWindowMethods.Sleep(3);
            /* Search By Property Status */
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingTypehead");
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyStatushead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusNone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_chkStatusPreListed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_chkStatusPreListed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_chkStatusPreListed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxListPropertyStatus_cblClassifierValues_2");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "PropertyStatushead");
           
            /* Search By Additional Information */
            SeleniumSetMethods.Click(driver, ElementType.Id, "AdditionalInfohead");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsSqFt_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsSqFt_ddlClassifierValues", "2000+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsLotSize_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsLotSize_ddlClassifierValues", "7500+");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlYearBuilt");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlYearBuilt", "1990");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 7 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");
        
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 30 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");


            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 60 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 90 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Less than 180 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_ddlClsDaysOnMarket_ddlClassifierValues", "Greater than 180 days");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnClear");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_txtPropertyID", "25987");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");

            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");

            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");

            SeleniumSetMethods.Click(driver, ElementType.Id, "btnClear");

            SeleniumSetMethods.Click(driver, ElementType.Id, "allProps");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ListingAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "StatusAll");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_checkBoxOnlyWithPhotos");
         
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_SearchForm1_btnSubmit");


            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//*[@id='ctl00_contentPlaceHolder_repeaterResults_ctl00_hyperLinkGeneral']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctrHeader_MainMenu_hplPropertySearch");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Search All RES.NET Listings");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Oldest Listings");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Price - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Price - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Square feet - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Square feet - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Beds - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Beds - high to low"); 
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Baths - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Baths - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Lot Size - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Lot Size - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Days on Market - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Days on Market - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Year Built - oldest to newest");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Year Built - newest to oldest");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Street Number - low to high");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Street Number - high to low");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "City - A to Z");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "City - Z to A");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ctl00_contentPlaceHolder_searchResultsSortDD", "Newest Listings");

        }

        public static void Agentsearch(Driver driver, string PropID)
        {
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Tasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "PropertyID");
            SeleniumSetMethods.Clear(driver, ElementType.Id, "PropertyID");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyID", PropID);
            SeleniumSetMethods.Click(driver, ElementType.Id, "searchButton1");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, ".TaskQueueGrid > tbody:nth-child(3) > tr:nth-child(1) > td:nth-child(3) > div:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, ".TaskQueueGrid > tbody:nth-child(3) > tr:nth-child(1) > td:nth-child(3) > div:nth-child(1) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericTaskTab_ctl00_ctrGeneralComments_txtComment");
            Global.ConsoleOut("Property details page opened for " + PropID);

        }

        public static void OccupancyStatusTask(Driver driver)
        {
            string OccChkDate = DateTime.Today.AddDays(-3).ToString("MM-dd-yy");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Occupancy Status Task");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "osCurChkDt");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "osCurChkDt", OccChkDate);
            Global.ConsoleOut(" Occupancy Check Date: " + SeleniumGetMethods.GetTextValue(driver, ElementType.Name, "osCurChkDt"));
            SeleniumSetMethods.Wait(driver, ElementType.Name, "osVacant");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osVacant", "Yes");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osPropType", "SFR");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osList", "Yes");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "txtosAgentNote");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtosAgentNote", "Agent comments - Occupancy status report ");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");
            SeleniumWindowMethods.Sleep(1);
            SeleniumGetMethods.GetWindowTitle(driver);
            Global.ConsoleOut("Agent submitted OccupancyStatusTask");

        }

        public static void PublishProperty(Driver driver, string PropertyID)
        {
            SeleniumGetMethods.GetWindowTitle(driver);
            // Need to Complete the steps

        }

        public static void ListAgentOffer(Driver driver)
        {
            // Listing Agent placing the offer to REO property
            string OfrDate = DateTime.Now.ToString("MM/dd/yy");

            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "td.tabCenter:nth-child(6) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "td.tabCenter:nth-child(6) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericOfferTab_ctl00_ctrOffersLog_hplAddNewOffer");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericOfferTab_ctl00_ctrOffersLog_hplAddNewOffer");

            // Agent Offer Worksheet
            SeleniumSetMethods.Wait(driver, ElementType.Name, "omOfrDt");
            SeleniumSetMethods.Click(driver, ElementType.Name, "omOfrDt");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "omOfrDt");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omOfrDt", OfrDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omBuyer", "TestBuyer1");   //"TestBuyer1"
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omOfrPrice", "490000");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "omLoanType", "Conv");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omLoanAmt", "450000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omDaysToClose", "30");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omCloseDt", DateTime.Today.AddDays(30).ToString("MM/dd/yy"));
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "omClosingCosts", "2500");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "omBt", "Owner");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSubmit");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.Assertion(driver, Alert.Accept);
            SeleniumGetMethods.GetWindowTitle(driver);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Back To Previous Page");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Back To Previous Page");

        }

        // NEED TO CREATE THE TESTCASES - check the offer is accepted in Agent portal

        public static void UploadSignedContract(Driver driver, string PropertyID)
        {
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "td.tabCenter:nth-child(6) > a:nth-child(1)");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "td.tabCenter:nth-child(6) > a:nth-child(1)");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericOfferTab_ctl00_ctrOffersLog_hplAddNewOffer");
            SeleniumWindowMethods.ScreenShot(driver, "Agent Offer tab_" + PropertyID);
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericOfferTab_ctl00_ctrOffersLog_hplAddNewOffer");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Click here to View or Upload Signed Contracts");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Click here to View or Upload Signed Contracts");
            SeleniumWindowMethods.WindowType(driver, WinType.Popup);
            SeleniumGetMethods.GetWindowTitle(driver);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "pcu_Buyer");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "pcu_Buyer", "TestBuyer1");  //TestBuyer1  , sree buyer       
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtpcu_Note", "Agent uploaded signed contracts.");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "pcu_" + PropertyID + "_0", "\\\\hqfs1\\Public\\IT\\QA\\QA Automation\\Platinum\\TestDoc.pdf");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumWindowMethods.ScreenShot(driver, "Contract upload_" + PropertyID);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "img");
            SeleniumWindowMethods.WindowType(driver, WinType.Main);
            SeleniumWindowMethods.Sleep(1);
            SeleniumGetMethods.GetWindowTitle(driver);
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Back To Previous Page");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Back To Previous Page");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_contentPlaceHolder_ctrPropertyTabControl_CnrGenericOfferTab_ctl00_ctrOffersLog_hplAddNewOffer");

        }


        public static void CancelAgentTask(Driver driver, string TaskName)
        {
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplTasks");
            SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_MainMenu_hplTasks");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "searchButton1");

        }

        public static void OpenAgentTask(Driver driver, string TaskName)
        {
            SeleniumWindowMethods.Sleep(1);
            SeleniumWindowMethods.Refresh(driver);
            SeleniumWindowMethods.Sleep(1);

            int tries = 0;
            bool IsTaskPresent = false;
            while (IsTaskPresent == false)
            {
                try
                {
                    SeleniumWindowMethods.Sleep(2);
                    tries = tries + 1;
                    Global.ConsoleOut("Attempting to find " + TaskName + " task. Number of attempts is  " + tries);
                    SeleniumWindowMethods.Sleep(2);
                    SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, TaskName);
                    Global.ConsoleOut("Task: " + TaskName + " found");
                    IsTaskPresent = true;
                    break;

                }

                catch (Exception)
                {
                    Global.ConsoleOut(TaskName + " not found");
                    SeleniumWindowMethods.Refresh(driver);
                }
                if (tries == 3)
                {
                    Global.ConsoleOut(TaskName + " not found. " + tries + " maxmium attempts has been reached.");
                    break;
                }

            }

        }

    }

}
