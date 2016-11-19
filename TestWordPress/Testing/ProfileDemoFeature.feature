Feature: ProfileDemoFeature
	This feature is implemented to test update profile function in Word Press

@TestWithoutLogin
Scenario: Update my Profile
	Given I am in Login Page
	When Move mouse hover to avatar and click on the avarta
		And From the left panel, I select My Profile
		And  Enter first name "Nhu", last name "Nguyen", about me "I'm Nhu"
		And Click Save Profile Detail
	Then I verify save successfully

@Monthly
Scenario: send email my Profile
	Given I am in Login Page