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
    class Portal_PropertyCure
    {
        public static void AddNewUser(Driver driver, string FirstName, string LastName, string Username, string Email, string Password)
        {
            // Add new User using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "span.username");           
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "User Management");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "User Management");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "i.fa.fa-plus");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "i.fa.fa-plus");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FirstName", FirstName);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LastName", LastName);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UserName", Username);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Email");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Email", Email);
            SeleniumSetMethods.Clear(driver, ElementType.Id, "Password");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Password", Password);
            SeleniumSetMethods.Click(driver, ElementType.Id, "Show_Password");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PasswordConfirmation", Password);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "IsActive", "Yes");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[9]");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "input.check-all");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "input.check-all");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@type='checkbox'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@type='checkbox'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@type='checkbox'])[5]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_0__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_1__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_2__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_3__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_4__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientPermissions_5__HasAccess", "True");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateDetail");

        }

        public static void AddNewProperty(Driver driver, string PropSTName, string PropCity, string PropState, string PropZipCode, string Client)
        {
            // Add New Property
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyStreet1", Global.StreetNum + " " + PropSTName);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyStreet2", "#150");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "locality", PropCity);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, PropState);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyStateLkUp", PropState);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyZip", PropZipCode);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Aging");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Open");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "1 Unit");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyRefId", "RefID"+Global.LoanNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PriorLoanNumber", "Prev Loan No");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "InvestorLoanNumber", "Investor Loan No");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "VendorId", "FiveBrothers");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "CSFB 2");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ClientId", Client);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PriorServicer", "Prior Servicer");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListingAgentEmail", "Listing@agent.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ForeclosureContact", "Foreclosure");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SPOC", "SPOC");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "AcquisitionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ScheduledForeclosureDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.NextMonth);
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsOccupied_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsBankruptcyActive_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnPropAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b");
            Global.PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b").Replace("Property ID", "").TrimStart();
            Global.ConsoleOut("Property ID: " + Global.PropertyID + " Successfully Created");
            // Adding Property Details
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "MostRecentValue");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MostRecentValue", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "TaxAssesessedValueAmt", "100.02");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "LPI", "100.03");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UnpaidLoanBalanceAmt", "100.04");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CorpAdvancesAmt", "100.05");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "EscrowAdvancesAmt", "100.06");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "HazardProceedsAmt", "100.07");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OtherAdvancesAmt", "100.08");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[9]");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Appraisal");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[10]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "George Washington (DollarBill)");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "DirectorId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[11]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SupervisorId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[12]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "SpecialistId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[13]");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MailingStreet1", "25520 Commercentre Drive");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MailingCity", "Lake Forest");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MailingZip", "92630");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "MailingStateLkUp", "California");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsDemo_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsFilingStayOfDemo_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsFaceToFaceContractFlag_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsLitigation_1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "TenDayLetterDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PropertyClosedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "StopGrassCutDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateDeboard", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateToREO", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DemoDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ValuationOrderedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "CondemnedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "InitialSecureDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabBody" + Global.PropertyID);

        }

        public static void AddNewViolation(Driver driver, string PropId, string ViolationRep)
        {
            // Add new Violation using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/Violations/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/Violations/']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddViolation");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddViolation");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Demo and Hearing");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ViolationTypeLkUp", "Demo and Hearing");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ViolationRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, ViolationRep);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ViolationRepresentative", ViolationRep);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CurrentFines", "100.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DailyFines", "5.05");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "All Data Received");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "HearingDataLkUp", "All Data Received");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.row");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ComplianceContactName", "Compliance Contact Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ComplianceContactTitle", "Compliance Contact Title");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ComplianceEntity", "Compliance Entity");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ComplianceEntityEmail", "ComplianceEntity@Email.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ComplianceEntityFax", "949-111-1234");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyName", "Attorney Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyOfficeName", "Attorney Office");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyStreet1", "123 Main St.");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "AttorneyState", "California");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyZip", "92620");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyEmail", "Attorney@Email.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyPhone", "949-111-4321");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AttorneyFax", "949-111-4321");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Borrower");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ResponsibilityLkUp", "Borrower");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SummaryRecommendation", "Hello it's me");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[7]");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(driver, ElementType.Id, "FnmaServicingError_0");
            SeleniumWindowMethods.Sleep(2);            
            // Adding Dates
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ServiceReceivedViolationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ViolationPostedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "HearingDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowupDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ChargeOffEscalatedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FormSubmittedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PackageToFnmaDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ClaimFiledDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "EscalationFormCompletedDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnViolAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.OrderID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
              "#page > span > b:nth-child(5)").Replace("Violation ID:", "").TrimStart();
            Global.ConsoleOut("Violation ID: " + Global.OrderID + " Successfully Created");
            // Add Violation Detail
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ViolationReason");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ViolationReason", Global.PropertyID + " Violation Reason");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "WorkOrderNumber", Global.PropertyID + " Work Order Number");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ViolationLevelLkUp", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ViolationDays", Global.StreetNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OriginalViolationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CompliantDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ViolationItemCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#newLineItemWrapper > td:nth-child(9) > a.mr10 > i");

        }

        public static void AddNewUtility(Driver driver, string PropId, string RepresentativeId)
        {
            // Add new Violation using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/Utilities/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/Utilities/']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddUtility");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddUtility");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "UtilityAcctNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UtilityAcctNumber", "13456");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UtilityCompanyName", "SDG&E");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServiceAddress", "123 Main St.");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServiceCity", "San Diego");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Electric");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "UtilityTypeLkUp", "Electric");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "MeterNumber", "654321");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "UtilityStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "AccountBalanceTransfer", "Do not transfer");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "UtilityRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "UtilityShutOffRequestedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "UtilityShutOffDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateServicerReceivedFinalBill", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "AccountTransferDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateUtilityCompanyDiscovered", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUtilAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");
            // Add Utility Detail
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ServiceMonthLkUp");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ServiceMonthLkUp", "September");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServiceYear", "2017");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "InvoicePaymentAmt", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BilledAmt", "105.90");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsFinalBill_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServiceStartDate", Global.LastMonth);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServiceEndDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "EnteredDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//tr[@id='newLineItemWrapper']/td[11]/a/i");

        }

        public static void AddNewOTABid(Driver driver, string PropId, string RepresentativeId)
        {
            // Add new OTA Bid using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/OtaBids/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/OtaBids/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddOtaBid");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddOtaBid");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "BidNumber");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BidNumber", "1456");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BidDetail", "OTA Bid Detail Description");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "OtaBidStatusLkUp", "Escalated to Director");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "TotalBidAmt", "101.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ApprovedAmt", "102.00");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OtaBidRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsForeclosureGroupNotified_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsViolationOnly_1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ServicerReceivedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "OrgResponseDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DeniedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ApprovedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "BidCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnOtaBidAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");
            // Add OTA Bid Notes
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "taNoteDetail", "OTA Note text detail ");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Save");

        }

        public static void AddNewSE(Driver driver, string PropId, string RepresentativeId)
        {
            // Add new SE using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/ServErrors/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/ServErrors/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddServiceError");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddServiceError");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BidNumber", "12345");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SubmittedBy", "submitted by someone");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "BidDetail", "Service Error Bid Detail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Bid1Amt", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Bid2Amt", "100.02");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServicingErrorReason", "Service Error Reasoning");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "FnmaComments", "FNMA Comments");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepresentativeUserId", RepresentativeId);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ServicingErrorStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServicingErrorRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsCompletedInSecondarySystem_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsCausedByViolation_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ResponseDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSEAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");
            // SE Bid Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "VendorCost");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "EntityResponsibleLkUp", "Borrower");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "OrgFaultReason", "Reason Servicer Errors");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "VendorCost", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ServicerCost", "100.02");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "VendorCost", "100.03");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "TotalCost", "100.04");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "SecondarySystemAmt", "100.05");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "SecondarySystemDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateToRI", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "CompletedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateAssignedBackToServicer", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ReviewedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "VendorReviewedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ResubmittedDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabBody");

        }

        public static void AddNewInspection(Driver driver, string PropId, string RepresentativeId)
        {
            // Add new OTA Bid using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/Inspection/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/Inspection/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddInspection");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddInspection");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "InspectionStatusLkUp", "Open");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "ReKey");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "InspectionTypeLkUp", "ReKey");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Demo");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ViolationTypeLkUp", "Demo");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Pending");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "VendorStatusCodeLkUp", "Pending");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Fair");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "ConditionCodeLkUp", "Fair");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CurrentPropertyValue", "101.01");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepUserId", RepresentativeId);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[7]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "BPO");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CurrentPropertyValueTypeLkUp", "BPO");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "InspectionExpenses", "101.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CitingAuthority", "Citing Authority");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CitingAuthorityPhoneNumber", "949-123-4567");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "InspectionRefID", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DateGoalComplete", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "CurrentPropertyValueDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PropertyCondemnedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FtvDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PartiallyVacantDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "WinterizedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "InspectionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "InspectionCompletedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PropertyAbandonedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "TransfertoVendorDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnInspAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");
            // Inspection Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "IsVacant_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsVacant_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsTenantOccupied_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsUtilities_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsCommonWaterLines_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsCodeViolations_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsAccessDenied_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsBadAddress_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsReceivership_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsSumpPump_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsCodeViolationsCured_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsEnvironmentalHazard_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "VendorComments", "No new damages. Bids has been rejected to address mold. Bids are pending to address roof leak and yard maintenance.");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Instructions", "VACANT is, as vacant does");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabBody");
            // Preservation/Construction Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Inspection/Preservation/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Inspection/Preservation/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "DamageDesc");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DamageAmt", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "RepairedValue", "100.02");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DamageDesc", "Damage Description");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsConstructionStarted_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "LastGrassCutDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GrassStopDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "CompletedDatetime", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DamageIdentifiedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "RekeyOrderDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "RekeyedDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdatePreservation");
            // Sale/Rent Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Inspection/Sale/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Inspection/Sale/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ListingAgentName");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListingAgentName", "Listing Agent Name");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ListingAgentPhoneNumber", "949-123-4567");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ForRentBy", "For Rent By");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ForRentPhoneNumber", "888-333-5555");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsPropertyForSale_1");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsForRent_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateSale");
            // Corrected Property Address
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Inspection/Property/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Inspection/Property/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "CorrectedStreet1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CorrectedStreet1", "Street Address 1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CorrectedStreet2", "Street Address 2");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CorrectedCity", "city");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[13]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "California");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "CorrectedStateLkUp", "California");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "CorrectedZIP", "92620");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateProperty");
           
        }

        public static void AddNewHazardClaim(Driver driver, string PropId, string RepresentativeId)
        {
            // Add New Hazard Claim 
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/HazardClaims/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/HazardClaims/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddHazardClaim");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddHazardClaim");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "HazardClaimStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PolicyNumber", "Loan Number");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DamageDescription", "Damage Description");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "InsuranceCompany", "Insurance Co");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Payee", "Payee");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "HazardClaimRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PaidAmt", "100.01");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ClaimProceedsAmt", "100.02");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PremiumAmt", "100.03");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ProceedsRcvdDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnHazClaimAdd");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");
            // Add Hazard Claim Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "ClaimInfo");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "ClaimInfo", "Claim Info Area");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DisbursementType", "Disbursement Type Area");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "DamagedBy", "Damaged By Area");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "DecisionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "LossDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ExpirationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ClaimFiledDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "PaymentDueDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateTabBody");

        }

        public static void AddNewPropertyRegistration(Driver driver, string PropId, string RepresentativeId)
        {
            // Add New Property Registration
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Property/PropRegistration/']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Property/PropRegistration/']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddProperty");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddProperty");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyRegStatusLkUp", "Open");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Registration Renewal");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "PropertyRegTypeLkUp", "Registration Renewal");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Municipality", "Marvel");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, RepresentativeId);
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Select All");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsBondRequired_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsDocsProvided_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsDocsSent_0");
            SeleniumSetMethods.Click(driver, ElementType.Id, "IsPostedNoticeRequired_0");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "PropertyRegRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "ExpirationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "RenewalDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddPropReg");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

        }

        public static void AddNewNote(Driver driver, string PropId)
        {
            // Add New Property Registration
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAddNote");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAddNote");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "taNoteDetail");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "taNoteDetail", "Adding a Note to the Notes Section");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Save");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
               "#page > span > b").TrimStart();
            Global.ConsoleOut("Note for : " + Global.UniversalID + " Successfully Created");

        }

        public static void FileUpload(Driver driver, string PropId, string FilePath)
        {
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(driver, ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(driver, ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpload");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "fileUpload", FilePath);
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnAlertOk");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnAlertOk");
            Global.PropertyID = SeleniumGetMethods.GetTextContent(driver, ElementType.CssSelector,
              "#page > span > b").TrimStart();
            Global.ConsoleOut("File Upload for : " + Global.UniversalID + " Successfully Created");

        }

    }

}
