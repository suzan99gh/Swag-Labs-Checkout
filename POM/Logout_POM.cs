using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SwagLabs.Helpers;

namespace SwagLabs.POM
{
    public class Logout_POM
    {
        public IWebDriver webDriver;
        public Logout_POM(IWebDriver driver) 
        {
            webDriver = driver; 
        }
        By burgerMenu = By.XPath("//button[@id='react-burger-menu-btn']");
        By logout = By.XPath("//a[@id='logout_sidebar_link']");
        public void ClickMenu() 
        {
            IWebElement menu = CommonMethods.WaitAndFindElement(burgerMenu);
            CommonMethods.Highlightelement(menu);
            menu.Click();
        }
        public void ClickLogout() 
        {
            IWebElement clickBtn = CommonMethods.WaitAndFindElement(logout);
            CommonMethods.Highlightelement(clickBtn);
            clickBtn.Click();
        }
    }
}
