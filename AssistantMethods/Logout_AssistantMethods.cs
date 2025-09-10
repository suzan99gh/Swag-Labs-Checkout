using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagLabs.Helpers;
using SwagLabs.POM;

namespace SwagLabs.AssistantMethods
{
    public class Logout_AssistantMethods
    {
        public static void Logout()
        {
            Logout_POM logout_POM = new Logout_POM(ManageDriver.driver);
            logout_POM.ClickMenu();
            logout_POM.ClickLogout();
        }
    }
}
