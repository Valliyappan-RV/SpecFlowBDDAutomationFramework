using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class SearchPage
    {
        #region Variables
        private IWebDriver driver;
        BasePage basePage;
        #endregion 

        #region Locators
        By searchTextbox = By.XPath("//*[@name='search_query']");
        #endregion

        #region Constructor
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            basePage = new BasePage(driver);
        }
        #endregion

        #region Page Methods
        public SearchPage SearchText(string text)
        {
            //driver.FindElement(searchTextbox).SendKeys(text);
            //driver.FindElement(searchTextbox).SendKeys(Keys.Enter);
            basePage.ElementInputTextAndEnter(searchTextbox,text);
            return new SearchPage(driver);
        }
        #endregion 

    }
}
