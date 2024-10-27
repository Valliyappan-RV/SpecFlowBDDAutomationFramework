Feature: Examples Data Driven Testing

Search in the youtube

@SecretBook
Scenario Outline:  Examples Data Driven Testing
	#Given Open the browser
	When Enter the URL
	Then Search with <searchKey>
	Examples: 
	| searchKey                  |
	| The Secret by Rhonda Byrne |
