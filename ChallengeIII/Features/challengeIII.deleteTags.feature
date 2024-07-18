Feature: Tags Deletion

  As a user of the QA Playground
  I want to verify the deletion functionality of the tags input box
  So that I can ensure that the tags are removed correctly

@tagsdeletion
Scenario Outline: Remove each loaded tag one by one
	Given a user navigates to the website "https://qaplayground.dev/apps/tags-input-box/"
	And the user has the "<Tag>" tag loaded
	When the user removes the "<Tag>" tag
	Then the "<Tag>" tag should be removed

	Examples:
	  | Tag        |
	  | node       |
	  | javaScript |

Scenario: Remove all tags at once
	Given a user navigates to the website "https://qaplayground.dev/apps/tags-input-box/"
	When the user clicks on the "Remove All" button
	Then all the tags should be removed

