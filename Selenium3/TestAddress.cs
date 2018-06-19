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
    class TestAddress
    {

        public static void Address(City city)
        {
            if (city == City.Irvine)
            {
                // New Address
                Global.subjectstreetname = "GreatLawn";
                Global.subjectcity = "Irvine";
                Global.subjectzipcode = "92620";
                Global.subjectstate = "California";

                Global.sc1street = "100 Rush Lily";
                Global.sc1city = "Irvine";
                Global.sc1zipcode = "92620";
                Global.sc1state = "California";

                Global.sc2street = "255 Rinaldi";
                Global.sc2city = "Irvine";
                Global.sc2zipcode = "92620";
                Global.sc2state = "California";

                Global.sc3street = "100 Townsend";
                Global.sc3city = "Irvine";
                Global.sc3zipcode = "92620";
                Global.sc3state = "California";

                Global.lc1street = "211 Tulip";
                Global.lc1city = "Irvine";
                Global.lc1zipcode = "92620";
                Global.lc1state = "California";

                Global.lc2street = "100 Scented Violet";
                Global.lc2city = "Irvine";
                Global.lc2zipcode = "92620";
                Global.lc2state = "California";

                Global.lc3street = "255 Encore";
                Global.lc3city = "Irvine";
                Global.lc3zipcode = "92620";
                Global.lc3state = "California";

            }
            else if (city == City.IrvineGCFail)
            {
                Global.subjectstreetname = "GreatLawn";
                Global.subjectcity = "Irvine";
                Global.subjectzipcode = "92620";
                Global.subjectstate = "California";

                Global.sc1street = "100 Testland";
                Global.sc1city = "Irvine";
                Global.sc1zipcode = "92620";
                Global.sc1state = "California";

                Global.sc2street = "100 Testland";
                Global.sc2city = "Irvine";
                Global.sc2zipcode = "92620";
                Global.sc2state = "California";

                Global.sc3street = "100 Testland";
                Global.sc3city = "Irvine";
                Global.sc3zipcode = "92620";
                Global.sc3state = "California";

                Global.lc1street = "100 Testland";
                Global.lc1city = "Irvine";
                Global.lc1zipcode = "92620";
                Global.lc1state = "California";

                Global.lc2street = "100 Testland";
                Global.lc2city = "Irvine";
                Global.lc2zipcode = "92620";
                Global.lc2state = "California";

                Global.lc3street = "100 Testland";
                Global.lc3city = "Irvine";
                Global.lc3zipcode = "92620";
                Global.lc3state = "California";
            }
            else if (city == City.Melvindale)
            {
                Global.subjectstreetname = "Hanna St";
                Global.subjectcity = "Melvindale";
                Global.subjectzipcode = "48122";
                Global.subjectstate = "Michigan";

                Global.sc1street = "17711 Henry St";
                Global.sc1city = "Melvindale";
                Global.sc1zipcode = "48122";
                Global.sc1state = "Michigan";

                Global.sc2street = "2580 David St";
                Global.sc2city = "Melvindale";
                Global.sc2zipcode = "48122";
                Global.sc2state = "Michigan";

                Global.sc3street = "3551 Northpointe";
                Global.sc3city = "Melvindale";
                Global.sc3zipcode = "48122";
                Global.sc3state = "Michigan";

                Global.lc1street = "3607 Whittaker";
                Global.lc1city = "Melvindale";
                Global.lc1zipcode = "48122";
                Global.lc1state = "Michigan";

                Global.lc2street = "3292 Wilkerson";
                Global.lc2city = "Melvindale";
                Global.lc2zipcode = "48122";
                Global.lc2state = "Michigan";

                Global.lc3street = "4326 Schaefer";
                Global.lc3city = "Dearborn";
                Global.lc3zipcode = "48126";
                Global.lc3state = "Michigan";
            }
            else if (city == City.ModestoGCFail)
            {
                Global.subjectstreetname = "Rose Arch";
                Global.subjectcity = "Irvine";
                Global.subjectzipcode = "92620";
                Global.subjectstate = "California";

                Global.sc1street = "100 Testland";
                Global.sc1city = "Modesto";
                Global.sc1zipcode = "95350";
                Global.sc1state = "California";

                Global.sc2street = "100 Testland";
                Global.sc2city = "Modesto";
                Global.sc2zipcode = "95350";
                Global.sc2state = "California";

                Global.sc3street = "100 Testland";
                Global.sc3city = "Modesto";
                Global.sc3zipcode = "95350";
                Global.sc3state = "California";

                Global.lc1street = "100 Testland";
                Global.lc1city = "Modesto";
                Global.lc1zipcode = "95350";
                Global.lc1state = "California";

                Global.lc2street = "100 Testland";
                Global.lc2city = "Modesto";
                Global.lc2zipcode = "95350";
                Global.lc2state = "California";

                Global.lc3street = "100 Testland";
                Global.lc3city = "Modesto";
                Global.lc3zipcode = "95350";
                Global.lc3state = "California";
            }
            else if (city == City.Naples)
            {
                Global.subjectstreetname = "Mill Pond Cir";
                Global.subjectcity = "NAPLES";
                Global.subjectzipcode = "34109";
                Global.subjectstate = "Florida";

                Global.sc1street = "6913 II REGALO";
                Global.sc1city = "NAPLES";
                Global.sc1zipcode = "34109";
                Global.sc1state = "Florida";

                Global.sc2street = "8123 WILSHIRE LAKES BLVD";
                Global.sc2city = "NAPLES";
                Global.sc2zipcode = "34109";
                Global.sc2state = "Florida";

                Global.sc3street = "4005 REFLECTION CT";
                Global.sc3city = "NAPLES";
                Global.sc3zipcode = "34109";
                Global.sc3state = "Florida";

                Global.lc1street = "13528 MANDARIN CIR";
                Global.lc1city = "NAPLES";
                Global.lc1zipcode = "34109";
                Global.lc1state = "Florida";

                Global.lc2street = "7112 SUGAR MAGNOLIA CIR";
                Global.lc2city = "NAPLES";
                Global.lc2zipcode = "34109";
                Global.lc2state = "Florida";

                Global.lc3street = "6821 II REGALO";
                Global.lc3city = "NAPLES";
                Global.lc3zipcode = "34109";
                Global.lc3state = "Florida";

            }

        }

    }

}
