using OpenQA.Selenium;

namespace ChallengeII.PageObjects
{
    internal class IFrame2Page : BasePage
    {
        private const string ButtonSelector = ".btn.btn-green-outline"; // Selector del botón dentro del iframe
        private const string MessageSelector = "#msg"; // Selector del mensaje que aparece después de hacer clic en el botón

        public IFrame2Page(IWebDriver driver) : base(driver)
        {
        }

        public void ClickButton()
        {
            var button = _driver.FindElement(By.CssSelector(ButtonSelector)); // Encuentra el botón
            button.Click(); // Haz clic en el botón
        }

        public string GetMessage()
        {
            var message = _driver.FindElement(By.CssSelector(MessageSelector)).Text; // Encuentra el mensaje y obtiene el texto
            return message; // Devuelve el texto del mensaje
        }
    }
}
