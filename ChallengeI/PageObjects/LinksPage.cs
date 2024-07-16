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
        /// Gets the home button in the navigation bar.
        /// </summary>
        private IWebElement HomeButton => _driver.FindElement(By.CssSelector("#nav a[href='#']"));

        /// <summary>
        /// Gets the about button in the navigation bar.
        /// </summary>
        private IWebElement AboutButton => _driver.FindElement(By.CssSelector("#nav a[href='about.html']"));

        /// <summary>
        /// Gets the blog button in the navigation bar.
        /// </summary>
        private IWebElement BlogButton => _driver.FindElement(By.CssSelector("#nav a[href='blog.html']"));

        /// <summary>
        /// Gets the portfolio button in the navigation bar.
        /// </summary>
        private IWebElement PorftolioButton => _driver.FindElement(By.CssSelector("#nav a[href='portfolio.html']"));

        /// <summary>
        /// Gets the contact button in the navigation bar.
        /// </summary>
        private IWebElement ContactButton => _driver.FindElement(By.CssSelector("#nav a[href='contact.html']"));

        /// <summary>
        /// Gets the text of the first button in the navigation bar.
        /// </summary>
        /// <returns>The text of the first button.</returns>
        public string GetFirstButtonText() => _driver.FindElement(By.CssSelector("#nav a:first-child")).Text;

        /// <summary>
        /// Clicks a button based on its visible text.
        /// </summary>
        /// <param name="buttonName">The visible text of the button to be clicked.</param>
        public void ClickButton(string buttonName)
        {
            var button = _driver.FindElement(By.XPath($"//a[text()='{buttonName}']"));
            button.Click();
        }
    }
}
