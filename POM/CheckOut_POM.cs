using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using SwagLabs.Helpers;

namespace SwagLabs.POM
{
    public class CheckOut_POM
    {
        public IWebDriver webDriver;
        public CheckOut_POM(IWebDriver driver) 
        {
            webDriver = driver; 
        }
       
        By Cart = By.XPath("//div[@id='shopping_cart_container']");
        By checkOutBtn = By.XPath("//a[@class='btn_action checkout_button']");
        By firstName = By.XPath("//div/input[@id='first-name']");
        By lastName = By.XPath("//div/input[@id='last-name']");
        By zip = By.XPath("//div/input[@id='postal-code']");
        By continueBtn = By.XPath("//div/input[@id='continue']");
        By finishBtn = By.XPath("//div/button[@id='finish']");
        By checkoutComplete = By.XPath("//div/span[@class='title']");

        public string CheckProccessCompleted()
        {

            IWebElement CheckMessage = webDriver.FindElement(checkoutComplete);
            string value = CheckMessage.Text;
            Console.WriteLine(value);
            return (value);
        }
        public void FillFirstName (string name)
        {
            IWebElement fillFirstName = CommonMethods.WaitAndFindElement(firstName);
            CommonMethods.Highlightelement(fillFirstName);
            fillFirstName.SendKeys(name);
        }

        public void FillLastName (string name)
        {
            IWebElement fillLastName = CommonMethods.WaitAndFindElement(lastName);
            CommonMethods.Highlightelement (fillLastName);
            fillLastName.SendKeys(name);    
        }
        public void FillZip (int num)
        {
            IWebElement fillZip = CommonMethods.WaitAndFindElement(zip);
            CommonMethods.Highlightelement (fillZip);
            fillZip.SendKeys(num.ToString());
        }
        public void ClickCart()
        {
            IWebElement cartBtn = CommonMethods.WaitAndFindElement(Cart);
            CommonMethods.Highlightelement(cartBtn);
            cartBtn.Click();
        }

        public void ClickContinue ()
        {
            IWebElement clickBtn = CommonMethods.WaitAndFindElement(continueBtn);
            CommonMethods.Highlightelement(clickBtn);
            clickBtn.Click();
        }
        public void ClickFinsh ()
        {
            IWebElement clickFinsh = CommonMethods.WaitAndFindElement(finishBtn);
            CommonMethods.Highlightelement(clickFinsh);
            clickFinsh.Click();
        }
        public void ClickCheckout()
        {
            IWebElement checktBtn = CommonMethods.WaitAndFindElement(checkOutBtn);
            checktBtn.Click();
        }

        public void Scrolldown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollBy(0, 500);");
        }

    }
}
