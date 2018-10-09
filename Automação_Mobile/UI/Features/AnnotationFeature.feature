Feature: Annotation
	


Scenario: Perform an Annotation Task
	Given I am logged into the Annotation tool
	When I select one test for perform the annotation
	And Select the Sorty by radio 
	Then select the text to perform the annotation
	And Click in Annotate
	And Select the Error type
	And Click in Finish or Report and choose Finish
	Then set the task Comment text in the text field
	And Click in Finish button
	Then the Annotation is finished
