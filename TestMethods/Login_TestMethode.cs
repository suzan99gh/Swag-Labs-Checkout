using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efwatercom.AssistantMethods;
using Efwatercom.Data;
using SwagLabs.Helpers;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class Login_TestMethode
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();

        }

        [TestMethod]
        public void Login()
        {
            //Login_AssistantMethods login_Assistant = new Login_AssistantMethods();
            //login_Assistant.UserLogin();
            Login_AssistantMethods.UserLogin();

        }
    }
}
