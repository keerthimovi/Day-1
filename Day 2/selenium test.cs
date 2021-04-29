

using OpenQA.Selenium;  
using OpenQA.Selenium.Chrome;  
using System;  
 

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Automation test started ");
            IWebDriver driver = new ChromeDriver(@"F:\driver c sharp");
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("KLA Tencor");
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();
            driver.Close();
            Console.Write("The Test case is ended ");
        }
    }
}







