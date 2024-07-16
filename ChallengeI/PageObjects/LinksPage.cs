using OpenQA.Selenium;

namespace ChallengeI.PageObjects
{
    public class LinksPage : BasePage
    {
        public LinksPage(IWebDriver driver) : base(driver) { }

        private IWebElement FirstButton => _driver.FindElement(By.CssSelector("#nav a:nth-child(1)"));
        private IWebElement GoBackButton => _driver.FindElement(By.CssSelector(".btn.btn-green"));

        public string GetFirstButtonText() => FirstButton.Text;

        public void ClickButton(string buttonName)
        {
            var button = _driver.FindElement(By.XPath($"//a[text()='{buttonName}']"));
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
