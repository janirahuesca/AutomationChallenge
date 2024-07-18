using OpenQA.Selenium;

namespace ChallengeII.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Navigates the WebDriver to the specified URL.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Switches the WebDriver's focus to the specified iframe by its ID or name.
        /// </summary>
        public void SwitchToIframe(string iframeId)
        {
            _driver.SwitchTo().Frame(iframeId);
        }

        /// <summary>
        /// Switches the WebDriver's focus back to the default content (main page).
        /// </summary>
        public void SwitchToDefaultContent()
        {
            _driver.SwitchTo().DefaultContent();
        }
    }
}
