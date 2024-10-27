using AventStack.ExtentReports.Model.ExtensionMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class BasePage
    {
        #region Variables
        public IWebDriver driver;
        #endregion

        #region Constructor
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElement Methods
        public string GetTitle()
        {
           return driver.Title;
        }

        public BasePage ElementClick(By locator)
        {
            driver.FindElement(locator).Click();
            return this;
        }

        public BasePage ElementClear(By locator)
        {
            driver.FindElement(locator).Clear();
            return this;
        }

        public BasePage ElementInputText(By locator, String text)
        {
            driver.FindElement(locator).SendKeys(text);
            return this;
        }

        public BasePage ElementInputTextAndEnter(By locator, String text)
        {
            driver.FindElement(locator).SendKeys(text);
            driver.FindElement(locator).SendKeys(Keys.Enter);
            return this;
        }

        public BasePage ElementClearAndInputText(By locator, String text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
            return this;
        }

        public BasePage ElementAttributeValue(By locator, String attributeName)
        {
            string attributeValue = driver.FindElement(locator).GetAttribute(attributeName);
            return this;
        }

        public BasePage IsElementEnabled(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            bool status = element.Enabled;
            return this;
        }

        public BasePage IsElementSelected(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            bool status = element.Selected;
            return this;
        }

        public BasePage ElementText(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            String elementText = element.Text;
            return this;
        }

        public BasePage CheckElementVisible(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the element is visible
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));            
            return this;
        }

        public BasePage WaitUntilVisibleAndClickElement(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the element is visible and then click it
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            element.Click();
            return this;
        }

        public BasePage WaitAndClickElement(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the element is clickable and then click it
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            element.Click();
            return this;
        }

        public BasePage ElementIsSelected(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the element is clickable and then click it
            bool elementIsSelected = wait.Until(ExpectedConditions.ElementToBeSelected(locator));
            return this;
        }

        public BasePage ElementExists(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the element is exist in the page
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(locator));
            return this;
        }

        public BasePage WaitAndAcceptAlert()
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the Alert is present and accept it
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            return this;
        }

        public BasePage WaitAndSwitchToFrame(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until the Frame is available and switch to it
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(locator));
            return this;
        }

        public BasePage ElementIsNotVisible(By locator)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait and check Element is not visible
            bool elementNotVisible = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
            return this;
        }

        public BasePage TextIsPresentInElement(By locator, String text)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Check text is present in the element
            bool elementIsSelected = wait.Until(ExpectedConditions.TextToBePresentInElementLocated(locator, text));
            return this;
        }

        public BasePage IsTitleContainsExpectedText(String text)
        {
            // Create an instance of WebDriverWait with a timeout of 20 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Check title contains expected text
            bool elementIsSelected = wait.Until(ExpectedConditions.TitleContains(text));
            return this;
        }

        public BasePage SelectByVisibleTextFromDropdown(By locator, String text)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            oSelect.SelectByText(text);
            return this;
        }

        public BasePage SelectByValueFromDropdown(By locator, String value)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            oSelect.SelectByValue(value);
            return this;
        }
        
        public BasePage SelectByIndexFromDropdown(By locator, int index)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            oSelect.SelectByIndex(index);
            return this;
        }

        public BasePage DeselectAllFromDropdown(By locator)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            oSelect.DeselectAll();
            return this;
        }

        public BasePage CountElementsInDropdown(By locator)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            IList<IWebElement> elementCount = oSelect.Options;
            Console.Write(elementCount.Count);
            return this;
        }

        public BasePage PrintAllElementsFromDropdown(By locator)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(locator));
            IList<IWebElement> elementCount = oSelect.Options;
            int iSize = elementCount.Count;
            for (int i = 0; i > iSize; i++)
            {
                String sValue = elementCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }
            return this;
        }

        public BasePage AcceptAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            return this;
        }

        public BasePage GetAlertTextAndAccept()
        {
            IAlert alert = driver.SwitchTo().Alert();
            String alertText = alert.Text;
            Console.WriteLine("Alert text is " + alertText);
            alert.Accept();
            return this;
        }

        public BasePage DismissAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
            return this;
        }

        public BasePage VerifyAlertTextAndAccept(By locator, String expectedAlertText)
        {
            var alertButton = driver.FindElement(locator);
            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Assert.Equals(expectedAlertText, alert.Text);
            return this;
        }
        #endregion

    }
}
