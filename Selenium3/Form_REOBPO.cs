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
    class Form_REOBPO
    {
        public static void BPOtask(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "abNdList");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdList", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdLow", "500000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdHigh", "600000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdHouses", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdClose", "25");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdMktTime", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdSale", "30");
            SeleniumSetMethods.Click(driver, ElementType.Name, "abNdPoo");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdConstr", "All new construction");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdAssess", "negative");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdNeg", "the price");
            SeleniumSetMethods.Click(driver, ElementType.Name, "abNdAppr");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abNdMonthly", "10");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abStyle", "Nice");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFt", "1700");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRooms", "3000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBed", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBath", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRent", "2500");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmt", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGar", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLot", "120");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAge", "10");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCond", "Great");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abPrevDom", "20");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abPrevLP", "350000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCurrLP", "550000");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtabMktComments", "this unit is priced to sell");
            SeleniumSetMethods.Click(driver, ElementType.Name, "cbRI_roof");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRI_Haz", "none");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRI_Pers", "a Ferrari");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrS1", "Comp Sale 1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSaleDtS1", "2/17/2017");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtS1", "2000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalS1", "500");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedS1", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathS1", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxS1", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtS1", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarS1", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotS1", "5000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeS1", "10");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomS1", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpS1", "450000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSpS1", "475000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerS1", "Bank");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrS2", "Comp Sale 2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSaleDtS2", "2/15/2017");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtS2", "2100");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalS2", "300");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedS2", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathS2", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxS2", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtS2", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarS2", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotS2", "4750");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeS2", "10");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomS2", "20");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpS2", "400000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSaleDtS3", "1/15/2017");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtS3", "1950");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalS3", "200");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedS3", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathS3", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxS3", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtS3", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarS3", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotS3", "4500");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeS3", "11");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomS3", "30");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpS3", "400000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSpS3", "375000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerS3", "BofA");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrS3", "Comp Sale 3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpL1", "400000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerL1", "Wells");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondS1", "Good");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinS1", "None");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommS1", "Seller got a great deal");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondS2", "Good");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinS2", "30 year");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommS2", "No Beuno");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondS3", "Good");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinS3", "Standard");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommS3", "Meh");
            SeleniumSetMethods.Click(driver, ElementType.Name, "cbInspS3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommS", "This and that");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrL1", "Comp List 1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abStyleL1", "Ranch");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSpS2", "425000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerS2", "Owner");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtL1", "1200");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalL1", "250");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedL1", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathL1", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxL1", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtL1", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarL1", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotL1", "2700");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeL1", "6");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomL1", "15");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOLpL1", "375000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrL2", "Comp List 2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abStyleL2", "Shaker");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtL2", "1300");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalL2", "225");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedL2", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathL2", "2");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxL2", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtL2", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarL2", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotL2", "3100");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeL2", "5");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomL2", "22");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOLpL2", "400000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpL2", "415000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerL2", "Wells");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAddrL3", "Comp List 3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abStyleL3", "Custom");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abSqFtL3", "1700");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abTotalL3", "200");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBedL3", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBathL3", "3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abProxL3", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abBsmtL3", "0");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abGarL3", "1");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLotL3", "2600");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abAgeL3", "4");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abDomL3", "12");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOLpL3", "450000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abLpL3", "450000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abOwnerL3", "BofA");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondL1", "Good");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinL1", "Conv");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommL1", "good example");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondL2", "Good");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinL2", "Conv");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommL2", "Keep an eye on this one");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCondL3", "Great");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinL3", "Cash");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommL3", "Boom");
            SeleniumSetMethods.Click(driver, ElementType.Name, "abMostCompL");
            SeleniumSetMethods.Click(driver, ElementType.Name, "cbInspL3");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abCommL", "Listing #3 is AMAZING");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abObo", "None");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abInflu", "it's the I, you need to know");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abResale", "nope.com");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinan", "n/a");
            SeleniumSetMethods.Click(driver, ElementType.Name, "cbInvest");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abFinancier", "BofA");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abMktStrategy", "Price it to sell");
            SeleniumSetMethods.Click(driver, ElementType.Name, "abViewed");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSaveWork");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a > img");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abmv90asis", "400000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abmv90rep", "500000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtmvcomments", "A remodel would work wonders");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abslp90asis", "415000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abslp90rep", "525000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abEstLandValue", "315000");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoName", "Irvine");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoAcsz", "101 Irvine, Irvine, CA, 92614");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoPhone", "949-333-1234");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoDues", "350.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoWhen", "First of the month");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoLast", "2/12/2017");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoDelinq", "None");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abHoMaint", "none.");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRdesc1", "Paint");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "abRcost1", "3000.00");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSaveWorkPg2");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnSaveSubmit");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnSaveSubmit");

        }

        public static void BPOPictures(Driver driver, int numberphoto)
        {
            // Loop through attaching 36 pictures
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnUploadPics");
            int SleepTime = 2;
            int i = 1;
            while (i <= numberphoto)
            {
                SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "input.dz-hidden-input:nth-of-type(1)"
                    , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\Numbers\\" + i + ".jpg");
                SeleniumWindowMethods.Sleep(SleepTime);
                i = i + 1;
            }
            // Complete BPO Pictures Section
            SeleniumSetMethods.Click(driver, ElementType.Name, "upDoneDate");
            SeleniumSetMethods.Wait(driver, ElementType.Name, "btnUploadPics");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUploadPics");
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "//input[@name='btnUpdate' and @value='Update as Done']");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "//input[@name='btnUpdate' and @value='Update as Done']");

        }

    }

}
