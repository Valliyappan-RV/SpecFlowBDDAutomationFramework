Feature: PageObjectModel

Search Secret Book in youtube

@SecretBook @POM
Scenario:  PageObjectModel
	Given Enter the youtube URL
	When Search for the Secret book in youtube
	And Navigate to channel
	Then Verify title of the page
