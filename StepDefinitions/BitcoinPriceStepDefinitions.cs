using BitcoinProgram.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BitcoinProgram.StepDefinitions
{
    [Binding]
    public class BitcoinPriceStepDefinitions
    {
        [Given(@"Navigate to ""([^""]*)""")]
        public void GivenNavigateTo(string p0)
        {
           Driver.driver.Navigate().GoToUrl(p0);
        }

        [When(@"Hover on graph and enter ""([^""]*)""")]
        public void WhenHoverOnGraphAndEnter(string p0)

        {
           
            NavigationPage navigationPage = new NavigationPage();
            Thread.Sleep(5000);
            Actions action= new Actions(Driver.driver);
            Thread.Sleep(6000);
            IWebElement graph = navigationPage.GraphHover;
            int X = (graph.Size.Width) / 2;
            int Y = (graph.Size.Height) / 2;
            for (int i = 0; i < graph.Size.Width; i++)
            {


                action.MoveToElement(graph).MoveByOffset(X+i,Y+i).Perform();
                string date = Driver.driver.FindElement(By.XPath("//span[@class='date']")).Text;
                if (date == p0)
                {

                    Console.WriteLine();
                   
                }

            }
            


    }

        [Then(@"Bitcoin price at that time will be displayed")]
        public void ThenBitcoinPriceAtThatTimeWillBeDisplayed()
        {
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//span[@class='price']")).Text);
        }
    }
}
