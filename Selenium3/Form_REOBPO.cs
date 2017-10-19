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

        public static void BPOtask()
        {
            SeleniumSetMethods.Wait(ElementType.Name, "abNdList");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdList", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdLow", "500000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdHigh", "600000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdHouses", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdClose", "25");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdMktTime", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdSale", "30");
            SeleniumSetMethods.Click(ElementType.Name, "abNdPoo");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdConstr", "All new construction");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdAssess", "negative");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdNeg", "the price");
            SeleniumSetMethods.Click(ElementType.Name, "abNdAppr");
            SeleniumSetMethods.EnterText(ElementType.Name, "abNdMonthly", "10");
            SeleniumSetMethods.EnterText(ElementType.Name, "abStyle", "Nice");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFt", "1700");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRooms", "3000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBed", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBath", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRent", "2500");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmt", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGar", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLot", "120");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAge", "10");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCond", "Great");
            SeleniumSetMethods.EnterText(ElementType.Name, "abPrevDom", "20");
            SeleniumSetMethods.EnterText(ElementType.Name, "abPrevLP", "350000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCurrLP", "550000");
            SeleniumSetMethods.EnterText(ElementType.Id, "txtabMktComments", "this unit is priced to sell");
            SeleniumSetMethods.Click(ElementType.Name, "cbRI_roof");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRI_Haz", "none");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRI_Pers", "a Ferrari");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrS1", "Comp Sale 1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSaleDtS1", "2/17/2017");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtS1", "2000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalS1", "500");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedS1", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathS1", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxS1", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtS1", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarS1", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotS1", "5000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeS1", "10");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomS1", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpS1", "450000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSpS1", "475000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerS1", "Bank");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrS2", "Comp Sale 2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSaleDtS2", "2/15/2017");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtS2", "2100");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalS2", "300");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedS2", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathS2", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxS2", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtS2", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarS2", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotS2", "4750");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeS2", "10");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomS2", "20");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpS2", "400000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSaleDtS3", "1/15/2017");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtS3", "1950");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalS3", "200");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedS3", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathS3", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxS3", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtS3", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarS3", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotS3", "4500");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeS3", "11");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomS3", "30");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpS3", "400000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSpS3", "375000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerS3", "BofA");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrS3", "Comp Sale 3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpL1", "400000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerL1", "Wells");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondS1", "Good");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinS1", "None");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommS1", "Seller got a great deal");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondS2", "Good");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinS2", "30 year");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommS2", "No Beuno");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondS3", "Good");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinS3", "Standard");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommS3", "Meh");
            SeleniumSetMethods.Click(ElementType.Name, "cbInspS3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommS", "This and that");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrL1", "Comp List 1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abStyleL1", "Ranch");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSpS2", "425000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerS2", "Owner");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtL1", "1200");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalL1", "250");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedL1", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathL1", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxL1", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtL1", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarL1", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotL1", "2700");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeL1", "6");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomL1", "15");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOLpL1", "375000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrL2", "Comp List 2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abStyleL2", "Shaker");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtL2", "1300");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalL2", "225");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedL2", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathL2", "2");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxL2", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtL2", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarL2", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotL2", "3100");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeL2", "5");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomL2", "22");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOLpL2", "400000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpL2", "415000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerL2", "Wells");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAddrL3", "Comp List 3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abStyleL3", "Custom");
            SeleniumSetMethods.EnterText(ElementType.Name, "abSqFtL3", "1700");
            SeleniumSetMethods.EnterText(ElementType.Name, "abTotalL3", "200");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBedL3", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBathL3", "3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abProxL3", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abBsmtL3", "0");
            SeleniumSetMethods.EnterText(ElementType.Name, "abGarL3", "1");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLotL3", "2600");
            SeleniumSetMethods.EnterText(ElementType.Name, "abAgeL3", "4");
            SeleniumSetMethods.EnterText(ElementType.Name, "abDomL3", "12");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOLpL3", "450000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abLpL3", "450000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abOwnerL3", "BofA");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondL1", "Good");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinL1", "Conv");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommL1", "good example");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondL2", "Good");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinL2", "Conv");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommL2", "Keep an eye on this one");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCondL3", "Great");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinL3", "Cash");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommL3", "Boom");
            SeleniumSetMethods.Click(ElementType.Name, "abMostCompL");
            SeleniumSetMethods.Click(ElementType.Name, "cbInspL3");
            SeleniumSetMethods.EnterText(ElementType.Name, "abCommL", "Listing #3 is AMAZING");
            SeleniumSetMethods.EnterText(ElementType.Name, "abObo", "None");
            SeleniumSetMethods.EnterText(ElementType.Name, "abInflu", "it's the I, you need to know");
            SeleniumSetMethods.EnterText(ElementType.Name, "abResale", "nope.com");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinan", "n/a");
            SeleniumSetMethods.Click(ElementType.Name, "cbInvest");
            SeleniumSetMethods.EnterText(ElementType.Name, "abFinancier", "BofA");
            SeleniumSetMethods.EnterText(ElementType.Name, "abMktStrategy", "Price it to sell");
            SeleniumSetMethods.Click(ElementType.Name, "abViewed");
            SeleniumSetMethods.Click(ElementType.Id, "btnSaveWork");
            SeleniumSetMethods.Click(ElementType.CssSelector, "a > img");
            SeleniumSetMethods.EnterText(ElementType.Name, "abmv90asis", "400000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abmv90rep", "500000");
            SeleniumSetMethods.EnterText(ElementType.Name, "txtmvcomments", "A remodel would work wonders");
            SeleniumSetMethods.EnterText(ElementType.Name, "abslp90asis", "415000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abslp90rep", "525000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abEstLandValue", "315000");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoName", "Irvine");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoAcsz", "101 Irvine, Irvine, CA, 92614");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoPhone", "949-333-1234");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoDues", "350.00");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoWhen", "First of the month");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoLast", "2/12/2017");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoDelinq", "None");
            SeleniumSetMethods.EnterText(ElementType.Name, "abHoMaint", "none.");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRdesc1", "Paint");
            SeleniumSetMethods.EnterText(ElementType.Name, "abRcost1", "3000.00");
            SeleniumSetMethods.Click(ElementType.Id, "btnSaveWorkPg2");
            SeleniumSetMethods.Wait(ElementType.Id, "btnSaveSubmit");
            SeleniumSetMethods.Click(ElementType.Id, "btnSaveSubmit");

        }

        public static void BPOPictures()
        {
            SeleniumWindowMethods.Sleep(3);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Return");

            int SleepTime = 2;
            int i = 1;

            while (i < 37)
            {
                SeleniumSetMethods.EnterText(ElementType.CssSelector, "input.dz-hidden-input:nth-of-type(1)"
                //SeleniumSetMethods.EnterText(ElementType.CssSelector, "input.dz-hidden-input:nth-child(65)"
                    , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\Numbers\\" + i + ".jpg");
                SeleniumWindowMethods.Sleep(SleepTime);

                i = i + 1;
            }
            SeleniumSetMethods.Click(ElementType.Name, "upDoneDate");
            SeleniumSetMethods.Wait(ElementType.Name, "btnUploadPics");
            SeleniumSetMethods.Click(ElementType.Name, "btnUploadPics");
            SeleniumWindowMethods.Sleep(5);
            SeleniumSetMethods.Wait(ElementType.PartialLinkText, "Return");
            SeleniumSetMethods.Click(ElementType.PartialLinkText, "Return");

        }

    }

}
