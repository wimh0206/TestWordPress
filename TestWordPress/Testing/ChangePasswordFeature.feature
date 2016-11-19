Feature: ChangePasswordFeature
	In order to check function change password
	As a user
	I want to check with valid & invalid case


@TestWithoutLogin
@UpdatenewPasswordintoappconfig
Scenario: Change password in Word Press
	Given I am in Login Page
	When Move mouse hover to avatar and click on the avarta
	And From the left panel, I select security
	And I Enter new password
		Then I verify password can be saved
	When Click button Save Password
		Then I verify save successfully
	When I Click Sign-out and sign-in again 
		Then I can log in successfully
