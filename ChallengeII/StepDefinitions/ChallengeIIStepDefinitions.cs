using ChallengeII.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ChallengeII.StepDefinitions
{
    [Binding]
    public class IframeStepDefinitions
    {
        private IWebDriver _driver;
        private IFrame1Page _iframe1Page;
        private IFrame2Page _iframe2Page;

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _iframe1Page = new IFrame1Page(_driver);
            _iframe2Page = new IFrame2Page(_driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }

        [Given(@"a user navigates to the website ""(.*)""")]
        public void GivenAUserNavigatesToTheWebsite(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.SwitchTo().Frame(IFrame1Page.Id);
        }

        [When(@"the user clicks on the ""Click Me"" button inside the iframe")]
        public void WhenTheUserClicksOnTheClickMeButtonInsideTheIframe()
        {
            _iframe1Page.SwitchToInnerIframe();
            _iframe2Page.ClickButton();
        }

        [Then(@"the user should see the message ""Button Clicked""")]
        public void ThenTheUserShouldSeeTheMessageButtonClicked()
        {
            var message = _iframe2Page.GetMessage();
            Assert.AreEqual("Button Clicked", message);
        }
    }
}
