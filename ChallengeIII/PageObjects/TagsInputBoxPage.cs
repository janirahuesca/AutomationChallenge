using OpenQA.Selenium;

namespace ChallengeIII.PageObjects
{
    public class TagsInputBoxPage : BasePage
    {
        private By tagInputBox = By.CssSelector("ul input[type='text']"); // Selector for the input box to add tags
        private By removeAllButton = By.CssSelector(".details button"); // Selector for the "Remove All" button
        private By tagLocator(string tagName) => By.XPath($"//li[normalize-space(text())='{tagName}']/i[@class='uit uit-multiply']"); // Locator for removing a specific tag
        private By tagElement(string tagName) => By.XPath($"//li[normalize-space(text())='{tagName}']"); // Locator for checking if a tag is loaded

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsInputBoxPage"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used by the page.</param>
        public TagsInputBoxPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Adds a tag to the input box.
        /// </summary>
        /// <param name="tagName">The name of the tag to add.</param>
        public void AddTag(string tagName)
        {
            EnterText(tagInputBox, tagName + Keys.Enter); // Enters the tag name into the input box and presses Enter
        }

        /// <summary>
        /// Removes a specific tag.
        /// </summary>
        /// <param name="tagName">The name of the tag to remove.</param>
        public void RemoveTag(string tagName)
        {
            ClickElement(tagLocator(tagName)); // Clicks on the remove button of the specified tag
        }

        /// <summary>
        /// Removes all tags using the "Remove All" button.
        /// </summary>
        public void RemoveAllTags()
        {
            ClickElement(removeAllButton); // Clicks on the "Remove All" button to remove all tags
        }

        /// <summary>
        /// Checks if a specific tag is loaded.
        /// </summary>
        /// <param name="tagName">The name of the tag to check.</param>
        /// <returns>True if the tag is loaded; false otherwise.</returns>
        public bool IsTagLoaded(string tagName)
        {
            return IsElementPresent(tagElement(tagName)); // Checks if the specified tag element is present
        }

        /// <summary>
        /// Checks if all tags are removed.
        /// </summary>
        /// <returns>True if no tags are present; false if tags are still present.</returns>
        public bool AreAllTagsRemoved()
        {
            return !IsElementPresent(By.CssSelector("ul li")); // Checks if there are no list items under the unordered list
        }
    }
}
