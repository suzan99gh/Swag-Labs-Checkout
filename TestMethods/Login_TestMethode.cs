using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efwatercom.AssistantMethods;
using Efwatercom.Data;
using SwagLabs.Helpers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Model;
using static System.Net.Mime.MediaTypeNames;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class Login_TestMethode
    {
        public static void ClassInitialize(TestContext testContext)
        {
            CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
            ManageDriver.MaximizeDriver();

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ManageDriver.CloseDriver();

        }

        [TestMethod]
        public void Login()
        {

            
            try
            {
                Login_AssistantMethods.UserLogin();
                var expectedURL = "https://www.saucedemo.com/v1/inventory.html";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl);
                Console.WriteLine("TC1 Completed Successfully.");
                string screenshotPath = CommonMethods.TakeScreenShot();
                Console.WriteLine($"Screenshot saved at: {screenshotPath}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
