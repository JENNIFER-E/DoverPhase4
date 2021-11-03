using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"E:\Training\phase 4");
            string url = "https://pizzastore-phase4.azurewebsites.net";
            driver.Navigate().GoToUrl(url);
           
            IWebElement element = driver.FindElement(By.Id("pizza"));
            


            element.Click();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
