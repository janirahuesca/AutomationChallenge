using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using ChallengeI.PageObjects;
using ChallengeI.Support;

namespace ChallengeI.StepDefinitions
{
    [Binding] 
    public sealed class ChallengeIStepDefinitions
    {
        private IWebDriver _driver;
        private LinksPage _linksPage;    
        private BasePage _currentPage = null!;

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _linksPage = new LinksPage(_driver); 
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

        [Given(@"a user navigates to the website ""([^""]*)""")] 
        public void GivenAUserNavigatesToTheWebsite(string url)
        {
            _driver.Navigate().GoToUrl(url); 
        }

        [Then(@"the first selected button should be ""([^""]*)""")] 
        public void ThenTheFirstSelectedButtonShouldBe(string expectedButtonName)
        {
            string firstButtonName = _linksPage.GetFirstButtonText(); 
            Assert.AreEqual(expectedButtonName, firstButtonName, $"Expected '{expectedButtonName}' button, but found '{firstButtonName}'."); // Compara con el nombre esperado y afirmamos
        }

        [When(@"the user clicks on the ""([^""]*)"" button")] 
        public void WhenTheUserClicksOnTheButton(string buttonName)
        {
            _linksPage.ClickButton(buttonName); 

            switch (buttonName.ToLowerInvariant()) 
            {
                case "about":
                    _currentPage = new AboutPage(_driver);
                    break;
                case "blog":
                    _currentPage = new BlogPage(_driver);
                    break;
                case "portfolio":
                    _currentPage = new PortfolioPage(_driver);
                    break;
                case "contact":
                    _currentPage = new ContactPage(_driver);
                    break;
                default:
                    _currentPage = new LinksPage(_driver);
                    break;

            }
        }

        [Then(@"the user should see the ""([^""]*)"" page")] 
        public void ThenTheUserShouldSeeThePage(string expectedPageContent)
        {
            string actualPageContent = _linksPage.GetPageContent(); 
            Assert.IsTrue(actualPageContent.Contains(expectedPageContent, StringComparison.OrdinalIgnoreCase), $"Expected to find '{expectedPageContent}' in page content."); // Verificamos que el contenido esperado esté presente en la página
        }

        [When(@"the user click on the ""GO BACK"" button")] 
        public void WhenTheUserClickOnTheGoBackButton()
        {
            if (_currentPage is IReturnable page) 
            {
                page.ClickGoBack(); 
            }
        }

        [Then(@"the user should be back on the home page")] 
        public void ThenTheUserShouldBeBackOnTheHomePage()
        {
            string actualUrl = _driver.Url;
            Assert.AreEqual("https://qaplayground.dev/apps/links/", actualUrl, "Expected to be back on the home page."); 
        }
    }
}
