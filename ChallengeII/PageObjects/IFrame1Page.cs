using OpenQA.Selenium;

namespace ChallengeII.PageObjects
{
    internal class IFrame1Page : BasePage
    {
        public static string Id => "frame1";

        public IFrame1Page(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement InnerIframe => _driver.FindElement(By.CssSelector("#frame2"));

        public void SwitchToInnerIframe() 
        {
            SwitchToIframe(InnerIframe.GetAttribute("id"));
        }
    }
}
