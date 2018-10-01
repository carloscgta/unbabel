Feature: Annotation
	Once logged into the application 
	As a User a I want to find a link of the task and click on it
	I want to be able to perform the annotation

@mytag
Scenario: Perform the annotation
	Given I have logged into the applicaton
	And I am in the home page
	When I click in the task link
	Then Perform the annotation task
