using ChallengeI.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace ChallengeI.StepDefinitions
{
    [Binding]
    public sealed class ChallengeIStepDefinitions
    {
        private IWebDriver _driver;
        private LinksPage _linksPage;

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _linksPage = new LinksPage(_driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Given(@"a user navigates to the website ""([^""]*)""")]
        public void GivenAUserNavigatesToTheWebsite(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [Then(@"the first selected button should be ""([^""]*)""")]
        public void ThenTheFirstSelectedButtonShouldBe(string expectedButtonName)
        {
            string actualButtonName = _linksPage.GetFirstButtonText();
            Assert.AreEqual(expectedButtonName, actualButtonName);
        }

        [When(@"the user clicks on the ""([^""]*)"" button")]
        public void WhenTheUserClicksOnTheButton(string buttonName)
        {
            _linksPage.ClickButton(buttonName);
        }

        [Then(@"the user should see the ""([^""]*)"" page")]
        public void ThenTheUserShouldSeeThePage(string expectedPageContent)
        {
            string actualPageContent = _linksPage.GetPageContent();
            Assert.IsTrue(actualPageContent.Contains(expectedPageContent), $"Expected to find {expectedPageContent} in page content.");
        }

        [When(@"the user click on the ""GO BACK"" button")]
        public void WhenTheUserClickOnTheButton(string p0)
        {
            _linksPage.ClickGoBack();
        }

        [Then(@"the user should be back on the home page")]
        public void ThenTheUserShouldBeBackOnTheHomePage()
        {
            string actualButtonName = _linksPage.GetFirstButtonText();
            Assert.AreEqual("Home", actualButtonName);
        }

    }
}
