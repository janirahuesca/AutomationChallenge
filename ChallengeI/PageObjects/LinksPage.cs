using OpenQA.Selenium;

namespace ChallengeI.PageObjects
{
    public class LinksPage : BasePage
    {
        public LinksPage(IWebDriver driver) : base(driver) { }

        private IWebElement FirstButton => _driver.FindElement(By.CssSelector(".button-class-selector"));
        private IWebElement GoBackButton => _driver.FindElement(By.Id("go-back-button-id"));

        public string GetFirstButtonText() => FirstButton.Text;

        public void ClickButton(string buttonName)
        {
            var button = _driver.FindElement(By.LinkText(buttonName));
            button.Click();
        }

        public string GetPageContent()
        {
            return _driver.FindElement(By.TagName("body")).Text;
        }

        public void ClickGoBack()
        {
            GoBackButton.Click();
        }
    }
}
