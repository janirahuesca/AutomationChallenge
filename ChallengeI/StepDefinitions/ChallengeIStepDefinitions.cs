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
        private IWebDriver _driver; // Instancia del WebDriver para interactuar con el navegador
        private LinksPage _linksPage; // Instancia de la p�gina de objetos para interactuar con los elementos de la p�gina        
        private BasePage _currentPage = null!;

        [BeforeScenario] // M�todo ejecutado antes de cada escenario de prueba
        public void Setup()
        {
            _driver = new ChromeDriver(); // Inicializa ChromeDriver para Chrome
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Establece un tiempo de espera impl�cito
            _linksPage = new LinksPage(_driver); // Inicializa la p�gina de objetos pas�ndole el WebDriver
        }

        [AfterScenario] // M�todo ejecutado despu�s de cada escenario de prueba
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit(); // Cierra el navegador
                _driver = null; // Libera recursos
            }
        }

        [Given(@"a user navigates to the website ""([^""]*)""")] // Navegar a una URL espec�fica
        public void GivenAUserNavigatesToTheWebsite(string url)
        {
            _driver.Navigate().GoToUrl(url); // Navegamos a la URL especificada
        }

        [Then(@"the first selected button should be ""([^""]*)""")] // Verificar el nombre del primer bot�n seleccionado
        public void ThenTheFirstSelectedButtonShouldBe(string expectedButtonName)
        {
            string firstButtonName = _linksPage.GetFirstButtonText(); // Obtiene el nombre del primer bot�n
            Assert.AreEqual(expectedButtonName, firstButtonName, $"Expected '{expectedButtonName}' button, but found '{firstButtonName}'."); // Compara con el nombre esperado y afirmamos
        }

        [When(@"the user clicks on the ""([^""]*)"" button")] // Hacer clic en un bot�n espec�fico
        public void WhenTheUserClicksOnTheButton(string buttonName)
        {
            _linksPage.ClickButton(buttonName); // Hacemos clic en el bot�n especificado

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

        [Then(@"the user should see the ""([^""]*)"" page")] // Verificar que se vea una p�gina espec�fica
        public void ThenTheUserShouldSeeThePage(string expectedPageContent)
        {
            string actualPageContent = _linksPage.GetPageContent(); // Obtenemos el contenido de la p�gina
            Assert.IsTrue(actualPageContent.Contains(expectedPageContent, StringComparison.OrdinalIgnoreCase), $"Expected to find '{expectedPageContent}' in page content."); // Verificamos que el contenido esperado est� presente en la p�gina
        }

        [When(@"the user click on the ""GO BACK"" button")] // Hacer clic en el bot�n "GO BACK"
        public void WhenTheUserClickOnTheGoBackButton()
        {
            if (_currentPage is IReturnable page) 
            {
                page.ClickGoBack(); // Hacemos clic en el bot�n "GO BACK"
            }
        }

        [Then(@"the user should be back on the home page")] // Verificar que se est� de vuelta en la p�gina de inicio
        public void ThenTheUserShouldBeBackOnTheHomePage()
        {
            string actualUrl = _driver.Url;
            Assert.AreEqual("https://qaplayground.dev/apps/links/", actualUrl, "Expected to be back on the home page."); // Verificamos que el nombre del bot�n sea "HOME"
        }
    }
}
