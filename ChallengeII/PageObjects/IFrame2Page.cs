using OpenQA.Selenium;

namespace ChallengeII.PageObjects
{
    internal class IFrame2Page : BasePage
    {
        private const string ButtonSelector = ".btn.btn-green-outline"; // Selector for the button inside the iframe
        private const string MessageSelector = "#msg"; // Selector for the message that appears after clicking the button

        /// <summary>
        /// Initializes a new instance of the <see cref="IFrame2Page"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used by the page.</param>
        public IFrame2Page(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Clicks the button inside the iframe.
        /// </summary>
        public void ClickButton()
        {
            var button = _driver.FindElement(By.CssSelector(ButtonSelector)); // Finds the button
            button.Click(); // Clicks the button
        }

        /// <summary>
        /// Retrieves the text of the message displayed after clicking the button.
        /// </summary>
        /// <returns>The text of the message.</returns>
        public string GetMessage()
        {
            var message = _driver.FindElement(By.CssSelector(MessageSelector)).Text; // Finds the message and gets its text
            return message; // Returns the text of the message
        }
    }
}
