# Automation Challenge

This repository contains a testing framework for automating tests on various web applications using Selenium WebDriver, SpecFlow and NUnit. 

## Challenges description

- **Challenge I**: The goal is to test the navigation functionality of a web page (https://qaplayground.dev/apps/links/). The tasks include navigating to the website, verifying that the first selected button is “Home”, clicking on each button, asserting the content of each new page that opens, clicking on “GO BACK”, and repeating this process for each button.
  
- **Challenge II**: The objective is to test the functionality of an iframe on a web page (https://qaplayground.dev/apps/iframe/). The tasks involve navigating to the website, clicking on the “Click Me” button, and asserting that the message “Button Clicked” appears.
  
- **Challenge III**: The aim is to test the functionality of a tags input box on a web page (https://qaplayground.dev/apps/tags-input-box/). The tasks include navigating to the website, deleting the loaded tags one by one and asserting that the tags have been deleted, loading the tags “Wolters”, “Kluwers”, “Automation” and asserting that the tags have been loaded, deleting the tags with the “Remove All” button, and asserting that all tags have been deleted.

## Prerequisites

Before running the tests, ensure you have the following installed:

- **Visual Studio**: The solution is built using Visual Studio.
- **Chrome WebDriver**: Ensure Chrome WebDriver is installed and compatible with your Chrome browser version.

## Tests execution instructions (using Visual Studio)

1. **Clone the repository:**

   ```bash
   git clone https://github.com/janirahuesca/AutomationChallenge.git
   ```

2. **Open the solution in Visual Studio:** Navigate to the cloned repository folder. Open the AutomationChallenge.sln file in Visual Studio.

3. **Restore NuGet packages:** Right-click on the solution in Solution Explorer. Select “Restore NuGet Packages” to restore all necessary packages.
   
4. **Build the solution:** Build the solution (Ctrl + Shift + B) to ensure all projects build successfully.
   
5. **Run the tests:** Open the Test Explorer in Visual Studio (Test > Test Explorer). Click on “Run All” to execute all tests. Alternatively, you can run individual tests by right-clicking on them in Test Explorer and selecting “Run Selected Tests”.
   
6. **View test results**: After running the tests, view the test results in the Test Explorer window. Check the output for each test to verify if they passed or failed.

## Tests execution instructions (using CLI)

1. **Clone the repository:**

   ```bash
   git clone https://github.com/janirahuesca/AutomationChallenge.git
   ```
   
2. **Build the solution:** Navigate to the cloned repository folder and build the solution using the .NET Core CLI.

   ```bash
   cd AutomationChallenge
   dotnet build
   ```
   Ensure all projects build successfully.
   
3. **Run the tests:** Execute the tests using the .NET Core CLI.

   ```bash
   dotnet test
   ```
   This command runs all the tests in the solution.
   
4. **View test results**: After running the tests, view the test results in the console output. Check the output for each test to verify if they passed or failed.

## Technologies

- **Repository:** GitHub
- **Stack:** .NET
- **Programming languages:** C#, Gherkin
- **Libraries:** Selenium Webdriver, SpecFlow, NUniT
- **Design patterns:** Page Object Model

## References

- BDD Testing using SpecFlow and NUnit with .NET Core - [https://andrewhalil.com](https://andrewhalil.com/2020/11/13/bdd-testing-using-specflow-and-nunit-with-net-core/)
- SpecFlow Selenium C# Tutorial Full Course 2023 - [https://www.youtube.com](https://www.youtube.com/watch?v=7xPcalwU76c&list=PLUeDIlio4THEvoy4oRApx9zaQnXGp3aQl)
- Page Object Model (POM) In Selenium With Examples - [https://www.toolsqa.com](https://www.toolsqa.com/selenium-webdriver/page-object-model/)
- Page object models - [https://www.selenium.dev](https://www.selenium.dev/documentation/test_practices/encouraged/page_object_models/)
- Working with IFrames and frames - [https://www.selenium.dev](https://www.selenium.dev/documentation/webdriver/interactions/frames/)




