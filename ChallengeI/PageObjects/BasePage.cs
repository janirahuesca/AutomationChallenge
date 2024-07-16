using OpenQA.Selenium;

namespace ChallengeI.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Gets the text content of the current page.
        /// </summary>
        /// <returns>The text content of the body element of the page.</returns>
        public string GetPageContent()
        {
            return _driver.FindElement(By.TagName("body")).Text;
        }
    }
}
