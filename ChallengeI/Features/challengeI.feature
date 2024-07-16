Feature: Links Navigation

  As a user of the QA Playground
  I want to verify the functionality of the navigation links
  So that I can ensure that each link directs to the correct page and allows returning to the home page

@linksnavigation
Scenario: Verify Home is the default selected button
	Given a user navigates to the website "https://qaplayground.dev/apps/links/"
	Then the first selected button should be "HOME"

Scenario Outline: Navigate through each link and verify content
	Given a user navigates to the website "https://qaplayground.dev/apps/links/"
    When the user clicks on the "<Button>" button
    Then the user should see the "<PageContent>" page
    When the user click on the "GO BACK" button
    Then the user should be back on the home page

    Examples:
      | Button     | PageContent                   |
      | About      | Welcome to the About Page     |
      | Blog       | Welcome to the Blog Page      |
      | Portfolio  | Welcome to the Portfolio Page |
      | Contact    | Welcome to the Contact Page   |

