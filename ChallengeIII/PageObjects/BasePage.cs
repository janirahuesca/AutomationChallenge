using OpenQA.Selenium;

namespace ChallengeIII.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Clicks on the element located by the specified locator.
        /// </summary>
        /// <param name="locator">The locator (By object) used to find the element.</param>
        public void ClickElement(By locator)
        {
            _driver.FindElement(locator).Click();
        }

        /// <summary>
        /// Enters text into the element located by the specified locator.
        /// Clears any existing text in the element before entering the new text.
        /// </summary>
        /// <param name="locator">The locator (By object) used to find the element.</param>
        /// <param name="text">The text to be entered into the element.</param>
        public void EnterText(By locator, string text)
        {
            var element = _driver.FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        /// <summary>
        /// Retrieves the visible text of the element located by the specified locator.
        /// </summary>
        /// <param name="locator">The locator (By object) used to find the element.</param>
        /// <returns>The visible text of the element.</returns>
        public string GetElementText(By locator)
        {
            return _driver.FindElement(locator).Text;
        }

        /// <summary>
        /// Checks if an element identified by the specified locator is present on the current page.
        /// </summary>
        /// <param name="locator">The locator (By object) used to find the element.</param>
        /// <returns>True if the element is present, otherwise False.</returns>
        public bool IsElementPresent(By locator)
        {
            try
            {
                _driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
