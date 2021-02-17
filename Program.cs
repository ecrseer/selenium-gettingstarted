using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace net23
{
    class Program
    {
        static void Main(string[] args)
        {
            var drver = new ChromeDriver("./chromedriver");
            WebDriverWait wait= new WebDriverWait(drver,TimeSpan.FromSeconds(12));
            drver.Url ="https://images.google.com/?gws_rd=ssl";
            
            drver.FindElement(By.XPath("//*[@id='sbtc']/div/div[3]/div[2]/span"))
                .Click();
            Console.WriteLine("Hello World!");
        }
    }
}
