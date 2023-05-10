Feature: OrangeTest

Search testers talk in youtube

@OrangeTest
Scenario:  Verify Orange Login functionality
	Given Enter the Orange login URL
	When user enters "Admin" and "admin123" to login
	Then Verify title of the page
	Then logout from the application

@OrangeTest
Scenario:  Verify Links in Orange home page
	Given Enter the Orange login URL
	When user enters "Admin" and "admin123" to login
	Then Verify Links in Orange home page
	Then logout from the application
