using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ChallengeIII.PageObjects;

namespace ChallengeIII.StepDefinitions
{
    [Binding]
    public class TagsStepDefinitions
    {
        private IWebDriver _driver;
        private TagsInputBoxPage _tagsPage;

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _tagsPage = new TagsInputBoxPage(_driver);
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
        }

        [Given(@"the user has the ""(.*)"" tag loaded")]
        public void GivenTheUserHasTheTagLoaded(string tagName)
        {
            if (!_tagsPage.IsTagLoaded(tagName))
            {
                _tagsPage.AddTag(tagName);
                Assert.IsTrue(_tagsPage.IsTagLoaded(tagName), $"Failed to load the tag: {tagName}");
            }
        }

        [When(@"the user adds the ""(.*)"" tag")]
        public void WhenTheUserAddsTheTag(string tagName)
        {
            _tagsPage.AddTag(tagName);
        }

        [Then(@"the ""(.*)"" tag should be loaded")]
        public void ThenTheTagShouldBeLoaded(string tagName)
        {
            Assert.IsTrue(_tagsPage.IsTagLoaded(tagName), $"Tag '{tagName}' was not loaded.");
        }

        [When(@"the user removes the ""(.*)"" tag")]
        public void WhenTheUserRemovesTheTag(string tagName)
        {
            _tagsPage.RemoveTag(tagName);
        }

        [Then(@"the ""(.*)"" tag should be removed")]
        public void ThenTheTagShouldBeRemoved(string tagName)
        {
            Assert.IsFalse(_tagsPage.IsTagLoaded(tagName), $"Tag '{tagName}' was not removed.");
        }

        [When(@"the user clicks on the ""Remove All"" button")]
        public void WhenTheUserClicksOnTheRemoveAllButton()
        {
            _tagsPage.RemoveAllTags();
        }

        [Then(@"all the tags should be removed")]
        public void ThenAllTheTagsShouldBeRemoved()
        {
            Assert.IsTrue(_tagsPage.AreAllTagsRemoved(), "Not all tags were removed.");
        }
    }
}
