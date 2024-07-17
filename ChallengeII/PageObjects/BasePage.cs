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

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void SwitchToIframe(string iframeId)
        {
            _driver.SwitchTo().Frame(iframeId);
        }

        public void SwitchToDefaultContent()
        {
            _driver.SwitchTo().DefaultContent();
        }
    }
}
