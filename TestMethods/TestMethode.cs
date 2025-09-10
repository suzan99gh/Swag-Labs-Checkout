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
using SwagLabs.AssistantMethods;
using SwagLabs.POM;

namespace SwagLabs.TestMethods
{
    [TestClass]
    public class TestMethode
    {

        [TestMethod]
        [Priority(1)]
        public void Login()
        {
            try
            {
                CommonMethods.NavigateToURL(GlobalConstant.LoginLink);
                ManageDriver.MaximizeDriver();
                Login_AssistantMethods.UserLogin();
                var expectedURL = "https://www.saucedemo.com/v1/inventory.html";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl);
                Console.WriteLine("Login test Completed Successfully.");
                string screenshotPath = CommonMethods.TakeScreenShot();
                Console.WriteLine($"Screenshot saved at: {screenshotPath}");
                Products_AssistantMethods.AddToCart();
            }
            catch (Exception ex)
            {
                Console.WriteLine("The issue is : " + ex.Message);
            }
        }

        [TestMethod]
        [Priority(2)]
        public void AddProduct()
        {
            Products_POM products_POM = new Products_POM(ManageDriver.driver);
            try
            {
                Products_AssistantMethods.AddToCart();
                products_POM.ScrollUp();
                products_POM.CheckCartNumber();
                string number = products_POM.CheckCartNumber();
                Console.WriteLine("Actual number on cart " + number);
                Assert.AreEqual("2", number);
                Console.WriteLine("Add two product test Completed Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        [Priority(3)]
        public void Checkout()
        {
            CheckOut_POM checkOut_POM = new CheckOut_POM(ManageDriver.driver);
            try
            {
                Chechout_AssistantMethods.CheckOutProccess();
                string massege = checkOut_POM.CheckProccessCompleted();
                Console.WriteLine("Actual Massege " + massege);
                Assert.AreEqual("Checkout: Overview", massege);
                Console.WriteLine("Add two product test Completed Successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        [Priority(4)]
        public void LOGOUT()
        {
         Logout_AssistantMethods.Logout();
        }       
        
        //[ClassCleanup]
        //public static void ClassCleanup()
        //{
        //    ManageDriver.CloseDriver();

        //}
    } 
}
