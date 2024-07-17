Feature: Iframe Button Click

  As a user of the QA Playground
  I want to verify the functionality of the button inside the iframe
  So that I can ensure that the button click works correctly and displays the expected message

@iframebuttonclick
Scenario: Verify button click inside iframe
    Given a user navigates to the website "https://qaplayground.dev/apps/iframe/"
    When the user clicks on the "Click Me" button inside the iframe
    Then the user should see the message "Button Clicked"
