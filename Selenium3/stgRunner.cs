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
    class stgRunner
    {
        public static void PCAddDefaultUsers()
        {
            // Adding Default Users
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(ENV.STG, "ditechadmin", "Pwd12345678!");
            PropertyCure.AddNewUser("Ivan", "Ngyen-Cuu", "ibenPn", "Ivan.Nguyen-Cuu@usres.com", "Green!23");
            SeleniumWindowMethods.Sleep(3);
            PropertyCure.AddNewUser("George", "Washington", "DollarBill", "QATest121@usres.com", "Green!23");
            Logout.Portal(Portals.PropertyCure);
        }

        public static void PCFlow1()
        {
            // Property Cure Regresssion Flow 1
            SeleniumWindowMethods.Sleep(3);
            Login.PropertyCure(ENV.STG, "ibenPn", "Green!23");
            PropertyCure.AddNewProperty("Encore", "Irvine", "California", "92620", "CSFB 2");
            PropertyCure.AddNewViolation(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewUtility(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewOTABid(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewSE(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewInspection(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewHazardClaim(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewPropertyRegistration(Global.PropertyID, "George Washington (DollarBill)");
            PropertyCure.AddNewNote(Global.PropertyID);
            PropertyCure.FileUpload(Global.PropertyID, "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            Logout.Portal(Portals.PropertyCure);

        }

    }

}