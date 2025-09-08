using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SwagLabs.Helpers;

namespace SwagLabs.POM
{
    public class Products_POM
    {
        public IWebDriver webDriver;
        public Products_POM(IWebDriver driver) // IwebDriver driver = new chromeDriver()
        {
            webDriver = driver; // _webDriver = new chromeDriver()
        }
        By productCard = By.XPath("//div[@class='inventory_item']");
        By addToCartBtn = By.XPath(".//button[contains(text(), 'Add to cart')]");

        public void ClickRandomProduct()
        {
            IList<IWebElement> products = webDriver.FindElements(productCard);
            int numberOfItems = products.Count;
            if (numberOfItems == 0)
            {
                throw new Exception("No products found.");
            }
            Random rand = new Random();
            int randomIndex = rand.Next(0, numberOfItems);
            Console.WriteLine($"Clicked random item at index: {randomIndex}");

            IWebElement button = products[randomIndex].FindElement(addToCartBtn);
            CommonMethods.Highlightelement(button);
            button.Click();

        }


    }
}
