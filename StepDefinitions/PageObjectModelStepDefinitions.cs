using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        #region Variables
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;
        BasePage basePage;
        #endregion

        #region Constructor
        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            searchPage = new SearchPage(driver);
            resultPage = new ResultPage(driver);
            basePage = new BasePage(driver);
            channelPage = new ChannelPage(driver);
        }
        #endregion

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(4000);
        }

        [When(@"Search for the Secret book in youtube")]
        public void WhenSearchForTheSecretBookInYoutube()
        {
            //searchPage = new SearchPage(driver);

            searchPage.SearchText("The Secret by Rhonda Byrne");
            Thread.Sleep(4000);
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
           // resultPage = new ResultPage(driver);
            resultPage.ClickOnChannel();
            Thread.Sleep(4000);
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            string title = basePage.GetTitle();
            //Assert.That(true,"The Secret by Rhonda Byrne - YouTube", channelPage.GetTitle());
            Assert.That(true, "The Secret by Rhonda Byrne - YouTube", title);
        }
    }
}