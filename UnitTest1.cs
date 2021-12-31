using BitcoinProgram.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace BitcoinProgram
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            
           
        }

        [Test]
        public void Test1()
        {
            Driver.driver.Navigate().GoToUrl("https://www.coindesk.com/price/bitcoin/");
            NavigationPage navigationPage = new NavigationPage();
            Thread.Sleep(5000);
            Actions action = new Actions(Driver.driver);
            Thread.Sleep(6000);
            IWebElement graph = navigationPage.GraphHover;
            int X = (graph.Size.Width) / 2;
            int Y = (graph.Size.Height) / 2;
            for (int i = 0; i < graph.Size.Width; i++)
            {
                action.MoveToElement(graph).MoveByOffset(X+i,Y+i).Perform();
                string date = Driver.driver.FindElement(By.XPath("//span[@class='date']")).Text;
                Console.WriteLine(date);

            }
        }
    }
}