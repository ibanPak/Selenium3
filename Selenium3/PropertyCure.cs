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
    class PropertyCure
    {

        public static void AddNewUser(string FirstName, string LastName, string Username, string Email, string Password)
        {
            // Add new User using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.username");           
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/User']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/User']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "i.fa.fa-plus");
            SeleniumSetMethods.Click(ElementType.CssSelector, "i.fa.fa-plus");
            SeleniumSetMethods.Wait(ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(ElementType.Id, "FirstName", FirstName);
            SeleniumSetMethods.EnterText(ElementType.Id, "LastName", LastName);
            SeleniumSetMethods.EnterText(ElementType.Id, "UserName", Username);
            SeleniumSetMethods.Clear(ElementType.Id, "Email");
            SeleniumSetMethods.EnterText(ElementType.Id, "Email", Email);
            SeleniumSetMethods.Clear(ElementType.Id, "Password");
            SeleniumSetMethods.EnterText(ElementType.Id, "Password", Password);
            SeleniumSetMethods.Click(ElementType.Id, "Show_Password");
            SeleniumSetMethods.EnterText(ElementType.Id, "PasswordConfirmation", Password);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "IsActive", "Yes");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[9]");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "input.check-all");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(ElementType.CssSelector, "input.check-all");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@type='checkbox'])[3]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@type='checkbox'])[4]");
            SeleniumSetMethods.Click(ElementType.XPath, "(//input[@type='checkbox'])[5]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_0__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_1__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_2__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_3__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_4__HasAccess", "True");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientPermissions_5__HasAccess", "True");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateDetail");

        }

        public static void AddNewProperty(string PropSTName, string PropCity, string PropState, string PropZipCode, string Client)
        {
            // Add New Property
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Add New Property");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyStreet1", Global.StreetNum + " " + PropSTName);
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyStreet2", "#150");
            SeleniumSetMethods.EnterText(ElementType.Id, "locality", PropCity);
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, PropState);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyStateLkUp", PropState);
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyZip", PropZipCode);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyTypeLkUp", "1 Unit");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyRefId", "RefID"+Global.LoanNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "PriorLoanNumber", "Prev Loan No");
            SeleniumSetMethods.EnterText(ElementType.Id, "InvestorLoanNumber", "Investor Loan No");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "VendorId", "FiveBrothers");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(ElementType.LinkText, "CSFB 2");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", Client);
            SeleniumSetMethods.EnterText(ElementType.Id, "PriorServicer", "Prior Servicer");
            SeleniumSetMethods.EnterText(ElementType.Id, "ListingAgentEmail", "Listing@agent.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "ForeclosureContact", "Foreclosure");
            SeleniumSetMethods.EnterText(ElementType.Id, "SPOC", "SPOC");
            SeleniumSetMethods.EnterText(ElementType.Name, "AcquisitionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ScheduledForeclosureDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.NextMonth);
            SeleniumSetMethods.Click(ElementType.Id, "IsOccupied_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsBankruptcyActive_0");

            SeleniumSetMethods.Click(ElementType.Id, "btnPropAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b");
            Global.PropteryID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b").Replace("Property ID", "").TrimStart();
            Global.ConsoleOut("Property ID: " + Global.PropteryID + " Successfully Created");

            SeleniumSetMethods.Wait(ElementType.Id, "MostRecentValue");
            SeleniumSetMethods.EnterText(ElementType.Id, "MostRecentValue", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "TaxAssesessedValueAmt", "100.02");
            SeleniumSetMethods.EnterText(ElementType.Id, "LPI", "100.03");
            SeleniumSetMethods.EnterText(ElementType.Id, "UnpaidLoanBalanceAmt", "100.04");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorpAdvancesAmt", "100.05");
            SeleniumSetMethods.EnterText(ElementType.Id, "EscrowAdvancesAmt", "100.06");
            SeleniumSetMethods.EnterText(ElementType.Id, "HazardProceedsAmt", "100.07");
            SeleniumSetMethods.EnterText(ElementType.Id, "OtherAdvancesAmt", "100.08");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[9]");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Appraisal");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[10]");
            SeleniumSetMethods.Click(ElementType.LinkText, "George Washington (DollarBill)");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "DirectorId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[11]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SupervisorId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[12]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SpecialistId", "George Washington (DollarBill)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[13]");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingStreet1", "25520 Commercentre Drive");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingCity", "Lake Forest");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingZip", "92630");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "MailingStateLkUp", "California");
            SeleniumSetMethods.Click(ElementType.Id, "IsDemo_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsFilingStayOfDemo_1");
            SeleniumSetMethods.Click(ElementType.Id, "IsFaceToFaceContractFlag_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsLitigation_1");
            SeleniumSetMethods.EnterText(ElementType.Name, "TenDayLetterDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PropertyClosedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "StopGrassCutDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateDeboard", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateToREO", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DemoDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ValuationOrderedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "CondemnedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "InitialSecureDate", Global.MMddyyDate);

            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody" + Global.PropteryID);

        }

        public static void AddNewViolation(string PropId, string ViolationRep)
        {
            // Add new Violation using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/Violations/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/Violations/']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddViolation");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddViolation");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Demo and Hearing");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationTypeLkUp", "Demo and Hearing");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(ElementType.LinkText, ViolationRep);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationRepresentative", ViolationRep);
            SeleniumSetMethods.EnterText(ElementType.Id, "CurrentFines", "100.00");
            SeleniumSetMethods.EnterText(ElementType.Id, "DailyFines", "5.05");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.LinkText, "All Data Received");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "HearingDataLkUp", "All Data Received");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.row");
            SeleniumSetMethods.EnterText(ElementType.Id, "ComplianceContactName", "Compliance Contact Name");
            SeleniumSetMethods.EnterText(ElementType.Id, "ComplianceContactTitle", "Compliance Contact Title");
            SeleniumSetMethods.EnterText(ElementType.Id, "ComplianceEntity", "Compliance Entity");
            SeleniumSetMethods.EnterText(ElementType.Id, "ComplianceEntityEmail", "ComplianceEntity@Email.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "ComplianceEntityFax", "949-111-1234");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyName", "Attorney Name");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyOfficeName", "Attorney Office");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyStreet1", "123 Main St.");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyCity", "Irvine");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "AttorneyState", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyZip", "92620");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyEmail", "Attorney@Email.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyPhone", "949-111-4321");
            
            SeleniumSetMethods.EnterText(ElementType.Id, "AttorneyFax", "949-111-4321");
            
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[8]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Borrower");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ResponsibilityLkUp", "Borrower");
            SeleniumSetMethods.EnterText(ElementType.Id, "SummaryRecommendation", "Hello it's me");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[7]");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Select All");
            SeleniumSetMethods.Click(ElementType.Id, "FnmaServicingError_0");

            SeleniumWindowMethods.Sleep(2);
            
            // Adding Dates
            SeleniumSetMethods.EnterText(ElementType.Name, "ServiceReceivedViolationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ViolationPostedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "HearingDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowupDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ChargeOffEscalatedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FormSubmittedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PackageToFnmaDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ClaimFiledDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "EscalationFormCompletedDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "btnViolAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
              "#page > span > b:nth-child(5)").Replace("Violation ID:", "").TrimStart();
            Global.ConsoleOut("Violation ID: " + Global.OrderID + " Successfully Created");
            
            // Add Violation Detail
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Wait(ElementType.Id, "ViolationReason");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationReason", Global.PropteryID + " Violation Reason");
            SeleniumSetMethods.EnterText(ElementType.Id, "WorkOrderNumber", Global.PropteryID + " Work Order Number");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationLevelLkUp", "1");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationDays", Global.StreetNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "OriginalViolationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Id, "CompliantDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationItemCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.CssSelector, "#newLineItemWrapper > td:nth-child(9) > a.mr10 > i");

        }

        public static void AddNewUtility(string PropId, string RepresentativeId)
        {
            // Add new Violation using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/Utilities/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/Utilities/']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddUtility");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddUtility");
            SeleniumSetMethods.Wait(ElementType.Id, "UtilityAcctNumber");
            SeleniumSetMethods.EnterText(ElementType.Id, "UtilityAcctNumber", "13456");
            SeleniumSetMethods.EnterText(ElementType.Id, "UtilityCompanyName", "SDG&E");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServiceAddress", "123 Main St.");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServiceCity", "San Diego");
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(ElementType.LinkText, "Electric");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "UtilityTypeLkUp", "Electric");
            SeleniumSetMethods.EnterText(ElementType.Id, "MeterNumber", "654321");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "UtilityStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(ElementType.Id, "AccountBalanceTransfer", "Do not transfer");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(ElementType.Id, "UtilityRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(ElementType.Name, "UtilityShutOffRequestedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "UtilityShutOffDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateServicerReceivedFinalBill", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "AccountTransferDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateUtilityCompanyDiscovered", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.Id, "btnUtilAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

            // Add Utility Detail
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabHead");
            SeleniumSetMethods.Wait(ElementType.Id, "ServiceMonthLkUp");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ServiceMonthLkUp", "September");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServiceYear", "2017");
            SeleniumSetMethods.EnterText(ElementType.Id, "InvoicePaymentAmt", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "BilledAmt", "105.90");
            SeleniumSetMethods.Click(ElementType.Id, "IsFinalBill_0");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServiceStartDate", Global.LastMonth);
            SeleniumSetMethods.EnterText(ElementType.Id, "ServiceEndDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Id, "EnteredDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.XPath, "//tr[@id='newLineItemWrapper']/td[11]/a/i");

        }

        public static void AddNewOTABid(string PropId, string RepresentativeId)
        {
            // Add new OTA Bid using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/OtaBids/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/OtaBids/']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddOtaBid");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddOtaBid");
            SeleniumSetMethods.Wait(ElementType.Id, "BidNumber");
            SeleniumSetMethods.EnterText(ElementType.Id, "BidNumber", "1456");
            SeleniumSetMethods.EnterText(ElementType.Id, "BidDetail", "OTA Bid Detail Description");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "OtaBidStatusLkUp", "Escalated to Director");
            SeleniumSetMethods.EnterText(ElementType.Id, "TotalBidAmt", "101.00");
            SeleniumSetMethods.EnterText(ElementType.Id, "ApprovedAmt", "102.00");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(ElementType.Id, "OtaBidRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(ElementType.Id, "IsForeclosureGroupNotified_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsViolationOnly_1");
            SeleniumSetMethods.EnterText(ElementType.Name, "ServicerReceivedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "OrgResponseDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DeniedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ApprovedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "BidCompleteDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Click(ElementType.Id, "btnOtaBidAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

            // Add OTA Bid Notes
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.EnterText(ElementType.Id, "taNoteDetail", "OTA Note text detail ");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Save");

        }

        public static void AddNewSE(string PropId, string RepresentativeId)
        {
            // Add new SE using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/ServErrors/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/ServErrors/']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddServiceError");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddServiceError");
            SeleniumSetMethods.EnterText(ElementType.Id, "BidNumber", "12345");
            SeleniumSetMethods.EnterText(ElementType.Id, "SubmittedBy", "submitted by someone");
            SeleniumSetMethods.EnterText(ElementType.Id, "BidDetail", "Service Error Bid Detail");
            SeleniumSetMethods.EnterText(ElementType.Id, "Bid1Amt", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "Bid2Amt", "100.02");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServicingErrorReason", "Service Error Reasoning");
            SeleniumSetMethods.EnterText(ElementType.Id, "FnmaComments", "FNMA Comments");
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepresentativeUserId", RepresentativeId);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ServicingErrorStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServicingErrorRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.Click(ElementType.Id, "IsCompletedInSecondarySystem_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsCausedByViolation_0");
            SeleniumSetMethods.EnterText(ElementType.Name, "ResponseDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(ElementType.Id, "btnSEAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

            // SE Bid Info
            SeleniumSetMethods.Wait(ElementType.Id, "VendorCost");

            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "EntityResponsibleLkUp", "Borrower");
            SeleniumSetMethods.EnterText(ElementType.Id, "OrgFaultReason", "Reason Servicer Errors");
            SeleniumSetMethods.EnterText(ElementType.Id, "VendorCost", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "ServicerCost", "100.02");
            SeleniumSetMethods.EnterText(ElementType.Id, "VendorCost", "100.03");
            SeleniumSetMethods.EnterText(ElementType.Id, "TotalCost", "100.04");
            SeleniumSetMethods.EnterText(ElementType.Id, "SecondarySystemAmt", "100.05");
            SeleniumSetMethods.EnterText(ElementType.Name, "SecondarySystemDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateToRI", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "CompletedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateAssignedBackToServicer", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ReviewedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "VendorReviewedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ResubmittedDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody");

        }

        public static void AddNewInspection(string PropId, string RepresentativeId)
        {
            // Add new OTA Bid using variables
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/Inspection/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/Inspection/']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddInspection");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddInspection");
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "InspectionStatusLkUp", "Open");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(ElementType.LinkText, "ReKey");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "InspectionTypeLkUp", "ReKey");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Demo");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationTypeLkUp", "Demo");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Pending");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "VendorStatusCodeLkUp", "Pending");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Fair");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ConditionCodeLkUp", "Fair");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.EnterText(ElementType.Id, "CurrentPropertyValue", "101.01");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepUserId", RepresentativeId);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[7]");
            SeleniumSetMethods.Click(ElementType.LinkText, "BPO");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "CurrentPropertyValueTypeLkUp", "BPO");
            SeleniumSetMethods.EnterText(ElementType.Id, "InspectionExpenses", "101.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "CitingAuthority", "Citing Authority");
            SeleniumSetMethods.EnterText(ElementType.Id, "CitingAuthorityPhoneNumber", "949-123-4567");
            SeleniumSetMethods.EnterText(ElementType.Id, "InspectionRefID", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DateGoalComplete", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "CurrentPropertyValueDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PropertyCondemnedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FtvDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PartiallyVacantDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "WinterizedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "InspectionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "InspectionCompletedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PropertyAbandonedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "TransfertoVendorDate", Global.MMddyyDate);

            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(ElementType.Id, "btnInspAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

            // Inspection Info
            SeleniumSetMethods.Wait(ElementType.Id, "IsVacant_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsVacant_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsTenantOccupied_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsUtilities_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsCommonWaterLines_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsCodeViolations_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsAccessDenied_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsBadAddress_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsReceivership_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsSumpPump_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsCodeViolationsCured_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsEnvironmentalHazard_0");
            SeleniumSetMethods.EnterText(ElementType.Id, "VendorComments", "No new damages. Bids has been rejected to address mold. Bids are pending to address roof leak and yard maintenance.");
            SeleniumSetMethods.EnterText(ElementType.Id, "Instructions", "VACANT is, as vacant does");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody");

            // Preservation/Construction Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Inspection/Preservation/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Inspection/Preservation/']");
            SeleniumSetMethods.Wait(ElementType.Id, "DamageDesc");
            SeleniumSetMethods.EnterText(ElementType.Id, "DamageAmt", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "RepairedValue", "100.02");
            SeleniumSetMethods.EnterText(ElementType.Id, "DamageDesc", "Damage Description");
            SeleniumSetMethods.Click(ElementType.Id, "IsConstructionStarted_0");
            SeleniumSetMethods.EnterText(ElementType.Name, "LastGrassCutDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GrassStopDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "CompletedDatetime", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "DamageIdentifiedDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "RekeyOrderDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "RekeyedDate", Global.MMddyyDate);

            SeleniumSetMethods.Click(ElementType.Id, "btnUpdatePreservation");

            // Sale/Rent Info
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Inspection/Sale/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Inspection/Sale/']");
            SeleniumSetMethods.Wait(ElementType.Id, "ListingAgentName");
            SeleniumSetMethods.EnterText(ElementType.Id, "ListingAgentName", "Listing Agent Name");
            SeleniumSetMethods.EnterText(ElementType.Id, "ListingAgentPhoneNumber", "949-123-4567");
            SeleniumSetMethods.EnterText(ElementType.Id, "ForRentBy", "For Rent By");
            SeleniumSetMethods.EnterText(ElementType.Id, "ForRentPhoneNumber", "888-333-5555");
            SeleniumSetMethods.Click(ElementType.Id, "IsPropertyForSale_1");
            SeleniumSetMethods.Click(ElementType.Id, "IsForRent_0");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateSale");

            // Corrected Property Address
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Inspection/Property/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Inspection/Property/']");
            SeleniumSetMethods.Wait(ElementType.Id, "CorrectedStreet1");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorrectedStreet1", "Street Address 1");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorrectedStreet2", "Street Address 2");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorrectedCity", "city");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[13]");
            SeleniumSetMethods.Click(ElementType.LinkText, "California");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "CorrectedStateLkUp", "California");
            SeleniumSetMethods.EnterText(ElementType.Id, "CorrectedZIP", "92620");
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateProperty");

            /*
            // Inspections Notes
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddNote ");
            SeleniumSetMethods.EnterText(ElementType.Id, "taNoteDetail", "test note");
            SeleniumSetMethods.Click(ElementType.LinkText, "Save");
            */
        }

        public static void AddNewHazardClaim(string PropId, string RepresentativeId)
        {
            // Add New Hazard Claim 
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/HazardClaims/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/HazardClaims/']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddHazardClaim");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddHazardClaim");
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "HazardClaimStatusLkUp", "Open");
            SeleniumSetMethods.EnterText(ElementType.Id, "PolicyNumber", "Loan Number");
            SeleniumSetMethods.EnterText(ElementType.Id, "DamageDescription", "Damage Description");
            SeleniumSetMethods.EnterText(ElementType.Id, "InsuranceCompany", "Insurance Co");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.EnterText(ElementType.Id, "Payee", "Payee");
            SeleniumSetMethods.EnterText(ElementType.Id, "HazardClaimRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "PaidAmt", "100.01");
            SeleniumSetMethods.EnterText(ElementType.Id, "ClaimProceedsAmt", "100.02");
            SeleniumSetMethods.EnterText(ElementType.Id, "PremiumAmt", "100.03");
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ProceedsRcvdDate", Global.MMddyyDate);

            SeleniumSetMethods.Click(ElementType.Id, "btnHazClaimAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

            SeleniumSetMethods.Wait(ElementType.Id, "ClaimInfo");
            SeleniumSetMethods.EnterText(ElementType.Id, "ClaimInfo", "Claim Info Area");
            SeleniumSetMethods.EnterText(ElementType.Id, "DisbursementType", "Disbursement Type Area");
            SeleniumSetMethods.EnterText(ElementType.Id, "DamagedBy", "Damaged By Area");
            SeleniumSetMethods.EnterText(ElementType.Name, "DecisionDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "LossDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ExpirationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "ClaimFiledDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "PaymentDueDate", Global.MMddyyDate);
            SeleniumSetMethods.Click(ElementType.Id, "btnUpdateTabBody");

        }

        public static void AddNewPropertyRegistration(string PropId, string RepresentativeId)
        {
            // Add New Property Registration
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Property/PropRegistration/']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Property/PropRegistration/']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddProperty");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddProperty");
            SeleniumSetMethods.Click(ElementType.XPath, "//button[@type='button']");
            SeleniumSetMethods.Click(ElementType.LinkText, "Open");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyRegStatusLkUp", "Open");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Registration Renewal");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyRegTypeLkUp", "Registration Renewal");
            SeleniumSetMethods.EnterText(ElementType.Id, "Municipality", "Marvel");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(ElementType.LinkText, RepresentativeId);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "RepresentativeId", RepresentativeId);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Select All");
            SeleniumSetMethods.Click(ElementType.Id, "IsBondRequired_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsDocsProvided_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsDocsSent_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsPostedNoticeRequired_0");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyRegRefId", "RefId" + Global.UniqueNum);
            SeleniumSetMethods.EnterText(ElementType.Name, "ExpirationDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "FollowUpDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "GoalDate", Global.MMddyyDate);
            SeleniumSetMethods.EnterText(ElementType.Name, "RenewalDate", Global.MMddyyDate);

            SeleniumSetMethods.Click(ElementType.Id, "btnAddPropReg");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
                "#page > span > b:nth-child(5)").TrimStart();
            Global.ConsoleOut(Global.UniversalID + " Successfully Created");

        }

        public static void AddNewNote(string PropId)
        {
            // Add New Property Registration
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/Note/Notes?']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddNote");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddNote");
            SeleniumSetMethods.Wait(ElementType.Id, "taNoteDetail");
            SeleniumSetMethods.EnterText(ElementType.Id, "taNoteDetail", "Adding a Note to the Notes Section");
            SeleniumSetMethods.Click(ElementType.LinkText, "Save");

            Global.UniversalID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
               "#page > span > b").TrimStart();
            Global.ConsoleOut("Note for : " + Global.UniversalID + " Successfully Created");

        }

        public static void FileUpload(string PropId, string FilePath)
        {
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Properties");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Click(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.Wait(ElementType.LinkText, PropId);
            SeleniumSetMethods.Click(ElementType.LinkText, PropId);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a[href *= '/UploadFile/FileUpload?']");
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpload");
            SeleniumSetMethods.EnterText(ElementType.Id, "fileUpload", FilePath);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAlertOk");
            SeleniumSetMethods.Click(ElementType.Id, "btnAlertOk");

            Global.PropteryID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
              "#page > span > b").TrimStart();
            Global.ConsoleOut("File Upload for : " + Global.UniversalID + " Successfully Created");

        }

    }

}
