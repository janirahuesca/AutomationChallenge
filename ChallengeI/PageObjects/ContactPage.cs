using ChallengeI.Support;
using OpenQA.Selenium;

namespace ChallengeI.PageObjects
{
    public class ContactPage : BasePage, IReturnable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksPage"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used by the page.</param>
        public ContactPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Gets the h1 title in the navigation bar.
        /// </summary>
        private IWebElement Title => _driver.FindElement(By.CssSelector("h1#title"));

        /// <summary>
        /// Gets the 'Go Back' button.
        /// </summary>
        private IWebElement GoBackButton => _driver.FindElement(By.CssSelector(".btn.btn-green"));

        /// <summary>
        /// Clicks the 'Go Back' button.
        /// </summary>
        public void ClickGoBack()
        {
            GoBackButton.Click();
        }
    }
}
