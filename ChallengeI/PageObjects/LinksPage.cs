using OpenQA.Selenium;

namespace ChallengeI.PageObjects
{
    public class LinksPage : BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksPage"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used by the page.</param>
        public LinksPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Gets the first button in the navigation bar.
        /// </summary>
        private IWebElement FirstButton => _driver.FindElement(By.CssSelector("#nav a:nth-child(1)"));

        /// <summary>
        /// Gets the 'Go Back' button.
        /// </summary>
        private IWebElement GoBackButton => _driver.FindElement(By.CssSelector(".btn.btn-green"));

        /// <summary>
        /// Gets the text of the first button in the navigation bar.
        /// </summary>
        /// <returns>The text of the first button.</returns>
        public string GetFirstButtonText() => FirstButton.Text;

        /// <summary>
        /// Clicks a button based on its visible text.
        /// </summary>
        /// <param name="buttonName">The visible text of the button to be clicked.</param>
        public void ClickButton(string buttonName)
        {
            var button = _driver.FindElement(By.XPath($"//a[text()='{buttonName}']"));
            button.Click();
        }

        /// <summary>
        /// Gets the text content of the current page.
        /// </summary>
        /// <returns>The text content of the body element of the page.</returns>
        public string GetPageContent()
        {
            return _driver.FindElement(By.TagName("body")).Text;
        }

        /// <summary>
        /// Clicks the 'Go Back' button.
        /// </summary>
        public void ClickGoBack()
        {
            GoBackButton.Click();
        }
    }
}
