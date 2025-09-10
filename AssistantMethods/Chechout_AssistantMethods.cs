using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagLabs.Helpers;
using SwagLabs.POM;

namespace SwagLabs.AssistantMethods
{
    public class Chechout_AssistantMethods
    {
        public static void CheckOutProccess()
        {
            CheckOut_POM checkOut_POM = new CheckOut_POM(ManageDriver.driver);
            checkOut_POM.ClickCart();
            checkOut_POM.Scrolldown();
            checkOut_POM.ClickCheckout();
            checkOut_POM.FillFirstName("Suzan");
            checkOut_POM.FillLastName("Gharaibeh");
            checkOut_POM.FillZip(1123);
            checkOut_POM.ClickContinue();
            checkOut_POM.Scrolldown();
            checkOut_POM.ClickFinsh();

        }
    }
}

