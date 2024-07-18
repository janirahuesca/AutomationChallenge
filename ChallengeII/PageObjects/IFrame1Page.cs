using OpenQA.Selenium;

namespace ChallengeII.PageObjects
{
    internal class IFrame1Page : BasePage
    {
        /// <summary>
        /// The ID of the iframe.
        /// </summary>
        public static string Id => "frame1";

        /// <summary>
        /// Initializes a new instance of the <see cref="IFrame1Page"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used by the page.</param>
        public IFrame1Page(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the inner iframe element.
        /// </summary>
        private IWebElement InnerIframe => _driver.FindElement(By.CssSelector("#frame2"));

        /// <summary>
        /// Switches the WebDriver's focus to the inner iframe.
        /// </summary>
        public void SwitchToInnerIframe()
        {
            SwitchToIframe(InnerIframe.GetAttribute("id"));
        }
    }
}
