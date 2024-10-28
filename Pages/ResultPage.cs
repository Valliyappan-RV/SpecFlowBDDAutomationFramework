using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ResultPage
    {
        #region Variables
        private IWebDriver driver;
        BasePage basePage;
        #endregion

        #region Locators
        By channelName = By.XPath("//a[@href=\"/@TheSecretByRhondaByrne\"][@id=\"main-link\"]");
        #endregion 

        #region Constructor
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            basePage = new BasePage(driver);
        }
        #endregion

        #region Page Methods
        public ResultPage ClickOnChannel()
        {
            //driver.FindElement(channelName).Click();
            basePage.ElementClick(channelName);
            return new ResultPage(driver);
        }
        #endregion
    }
}
