using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.SDET.PageObject
{
    class JustChromeRepo
    {
        IWebDriver driver;

        public JustChromeRepo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
