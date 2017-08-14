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
            SeleniumSetMethods.Wait(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.CssSelector, "span.username");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-2");
            SeleniumSetMethods.Click(ElementType.XPath, "//div[@id='dtUserSearch_wrapper']/div/div[3]/div/a[3]/span");
            SeleniumSetMethods.Wait(ElementType.Id, "FirstName");
            SeleniumSetMethods.EnterText(ElementType.Id, "FirstName", "Fred");
            SeleniumSetMethods.EnterText(ElementType.Id, "LastName", "Flinstone");
            SeleniumSetMethods.EnterText(ElementType.Id, "UserName", "Bedrock");
            SeleniumSetMethods.EnterText(ElementType.Id, "EmailAddress", "Bedrock@gmail.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "Password", "passwrod1");
            SeleniumSetMethods.Click(ElementType.Id, "Show_Password");
            SeleniumSetMethods.EnterText(ElementType.Id, "PasswordConfirmation", "password1");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "IsActive", "Yes");
            SeleniumSetMethods.Click(ElementType.Id, "UserRoles");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.multiSelectOptions:nth-child(2) > label:nth-child(1)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");

        }

        public static void AddNewProperty(string PropSTName, string PropCity, string PropState, string PropZipCode, string Client)
        {
            // Add new property using variables      
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
            SeleniumSetMethods.Click(ElementType.LinkText, "1 Unit");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "PropertyTypeLkUp", "1 Unit");
            SeleniumSetMethods.EnterText(ElementType.Id, "PropertyRefId", "RefID3");
            SeleniumSetMethods.EnterText(ElementType.Id, "LoanNumber", Global.LoanNum);
            SeleniumSetMethods.EnterText(ElementType.Id, "PriorLoanNumber", "Prev Loan No");
            SeleniumSetMethods.EnterText(ElementType.Id, "InvestorLoanNumber", "Investor Loan No");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Aging");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "LoanStatusLkUp", "Aging");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
            SeleniumSetMethods.Click(ElementType.XPath, "//section[@id='wrapperPropAdd']/div/div/div[2]/div[6]/div/div/div/ul/li[3]/a/span[2]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "VendorId", "FiveBrothers");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[6]");
            SeleniumSetMethods.Click(ElementType.LinkText, "CSFB 2");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ClientId", Client);
            SeleniumSetMethods.EnterText(ElementType.Id, "PriorServicer", "Prior Servicer");
            SeleniumSetMethods.EnterText(ElementType.Id, "ListingAgentEmail", "Listing@agent.com");
            SeleniumSetMethods.EnterText(ElementType.Id, "ForeclosureContact", "Foreclosure");
            SeleniumSetMethods.EnterText(ElementType.Id, "SPOC", "SPOC");
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
            SeleniumSetMethods.Click(ElementType.XPath, "//form[@id='formPropInfo']/section/div/div[3]/div[3]/div/div/div/ul/li[9]/a/span[2]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SupervisorId", "QA Tester (qatest)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[12]");
            SeleniumSetMethods.Click(ElementType.XPath, "//form[@id='formPropInfo']/section/div/div[3]/div[4]/div/div/div/ul/li[12]/a/span[2]");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "SpecialistId", "QATester PropertyCure (PropertyCure)");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[13]");
            SeleniumSetMethods.Click(ElementType.XPath, "//form[@id='formPropInfo']/section/div/div[3]/div[7]/div/div/div/ul/li[7]/a");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingStreet1", "25520 Commercentre Drive");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingCity", "Lake Forest");
            SeleniumSetMethods.EnterText(ElementType.Id, "MailingZip", "92630");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "MailingStateLkUp", "California");
            SeleniumSetMethods.Click(ElementType.Id, "IsDemo_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsFilingStayOfDemo_1");
            SeleniumSetMethods.Click(ElementType.Id, "IsFaceToFaceContractFlag_0");
            SeleniumSetMethods.Click(ElementType.Id, "IsLitigation_1");
            SeleniumSetMethods.EnterText(ElementType.Name, "AcquisitionDate", Global.MMddyyDate);
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
            SeleniumSetMethods.Wait(ElementType.Id, "ui-id-6");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-6");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(ElementType.Id, "btnAddViolation ");
            SeleniumSetMethods.Click(ElementType.Id, "btnAddViolation ");
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[2]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Demo and Hearing");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationTypeLkUp", "Demo and Hearing");
            SeleniumSetMethods.EnterText(ElementType.Id, "ViolationRefId", "RefID123");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[3]");
            SeleniumSetMethods.Click(ElementType.LinkText, ViolationRep);
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ViolationRepresentative", ViolationRep);
            SeleniumSetMethods.EnterText(ElementType.Id, "CurrentFines", "100.00");
            SeleniumSetMethods.EnterText(ElementType.Id, "DailyFines", "5.05");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[4]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Info Complete");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "HearingDataLkUp", "Info Complete");
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[5]");
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
            SeleniumSetMethods.Click(ElementType.XPath, "(//button[@type='button'])[12]");
            SeleniumSetMethods.Click(ElementType.LinkText, "Borrower");
            SeleniumSetMethods.SelectDropDown(ElementType.Id, "ResponsibilityLkUp", "Borrower");
            SeleniumSetMethods.EnterText(ElementType.Id, "SummaryRecommendation", "Hello it's me");
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
            //SeleniumSetMethods.Click(ElementType.Id, "btnBackViolSearch");
            SeleniumSetMethods.Click(ElementType.Id, "btnViolAdd");

            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "#page > span > b:nth-child(5)");
            Global.OrderID = SeleniumGetMethods.GetTextContent(ElementType.CssSelector,
              "#page > span > b:nth-child(5)").Replace("Violation ID:", "").TrimStart();
            Global.ConsoleOut("Violation ID: " + Global.OrderID + " Successfully Created");

        }

        public static void FileUpload(string FilePath)
        {
            SeleniumSetMethods.Wait(ElementType.Id, "btnSearchFilters");
            SeleniumSetMethods.EnterText(ElementType.Id, "searchBar", Global.PropteryID);
            SeleniumWindowMethods.Sleep(2);
            SeleniumSetMethods.EnterText(ElementType.Id, "searchBar", Keys.Return);
            SeleniumSetMethods.Wait(ElementType.Id, "ui-id-22");
            SeleniumSetMethods.Click(ElementType.Id, "ui-id-22");
            SeleniumSetMethods.Wait(ElementType.Id, "btnUpload");
            SeleniumSetMethods.EnterText(ElementType.Id, "fileUpload", FilePath);
            SeleniumSetMethods.Wait(ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Click(ElementType.CssSelector, "div.ui-dialog-buttonset > #btnUpload");
            SeleniumSetMethods.Wait(ElementType.Id, "btnAlertOk");
            SeleniumSetMethods.Click(ElementType.Id, "btnAlertOk");
        }

    }

}
