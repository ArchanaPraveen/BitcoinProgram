using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinProgram.PageObjects
{
    public class NavigationPage
    {
        public NavigationPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.XPath, Using = "((//*[name()='svg' and @class='highcharts-root'])[1]//*[name()='rect'])[4]")]
        public IWebElement GraphHover { get; set; }
       
    }
}
