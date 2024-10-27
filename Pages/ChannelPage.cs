using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ChannelPage
    {
        #region Variables
        private IWebDriver driver;
        #endregion

        #region Locators
        #endregion

        #region Constructor
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region Page Methods
        public string GetTitle()
        {
           return driver.Title;
        }
        #endregion

    }
}
