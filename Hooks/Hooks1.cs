using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BitcoinProgram.Hooks
{
    [Binding]
    public sealed class Hooks1
    {


        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();

        }

       

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Close();
        }
    }
}