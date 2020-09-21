using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Tests.SDET.Specs.Steps
{
    [Binding]
    public sealed class JustChromeSteps
    {
        IWebDriver driver;

        [Given(@"I am using Chrome")]
        public void GivenIAmUsingChrome()
        {
            driver = new ChromeDriver();
           
        }

        [When(@"I visit the JustChrome page")]
        public void WhenIVisitTheJustChromePage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/chrome/");
            driver.Manage().Window.Maximize();
        }

        [Then(@"I am shown the JustChrome page")]
        public void ThenIAmShownTheJustChromePage()
        {
            Console.WriteLine("just chrome page");
        }

        [Given(@"I am using Internet Explorer")]
        public void GivenIAmUsingInternetExplorer()
        {
            
        }

        [Then(@"I am shown an error page")]
        public void ThenIAmShownAnErrorPage()
        {
            
        }

    }
}
