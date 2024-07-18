Feature: Tags Addition

  As a user of the QA Playground
  I want to verify the addition functionality of the tags input box
  So that I can ensure that the tags are added correctly

@tagsaddition
Scenario Outline: Add a tag
	Given a user navigates to the website "https://qaplayground.dev/apps/tags-input-box/"
	When the user adds the "<Tag>" tag
	Then the "<Tag>" tag should be loaded

	Examples:
	  | Tag     | 
	  | Wolters    |
	  | Kluwers    | 
	  | Automation | 
