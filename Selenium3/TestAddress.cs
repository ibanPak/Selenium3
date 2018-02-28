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
                Global.subjectstreetnumber = "235";      // "Random";
                Global.subjectstreetname = "GreatLawn";
                Global.subjectcity = "Irvine";
                Global.subjectstate = "California";
                Global.subjectzipcode = "92620";

                Global.sc1street = "100 Rush Lily";
                Global.sc1city = "Irvine";
                Global.sc1zipcode = "92620";
                Global.sc1state = "California";

                Global.sc2street = "255 Roosevelt";
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
                Global.subjectstreetnumber = "237";      // "Random";
                Global.subjectstreetname = "GreatLawn";
                Global.subjectcity = "Irvine";
                Global.subjectstate = "California";
                Global.subjectzipcode = "92620";

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

        }

        /* 
       

        //
        string sc1street = "3594 Northpointe";
        string sc1city = "Melvindale";
        string sc1zipcode = "48122";
        string sc1state = "Michigan";

        string sc2street = "3277 Northpointe";
        string sc2city = "Melvindale";
        string sc2zipcode = "48122";
        string sc2state = "Michigan";

        string sc3street = "3551 Northpointe";
        string sc3city = "Melvindale";
        string sc3zipcode = "48122";
        string sc3state = "Michigan";

        string lc1street = "3607 Whittaker";
        string lc1city = "Melvindale";
        string lc1zipcode = "48122";
        string lc1state = "Michigan";

        string lc2street = "3292 Wilkerson";
        string lc2city = "Melvindale";
        string lc2zipcode = "48122";
        string lc2state = "Michigan";

        string lc3street = "4326 Schaefer";
        string lc3city = "Dearborn";
        string lc3zipcode = "48126";
        string lc3state = "Michigan";
        */
    }

}
