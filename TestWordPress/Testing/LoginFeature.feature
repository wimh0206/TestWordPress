Feature: LoginFeature
	This feature is implemented to test login function in Word Press

@Daily
@TestLogin
Scenario Outline: Test Login  with valid multi user in Word Press
	Given I am in Login Page
	When  I click Login Link
		And I enter username '<username>'
		And I enter password '<password>'
		And I click login button
	Then I can log in successfully
	Examples: 
	| username   | password   |
	| nhunguyenq | test@1234  |
	| wimh0206   | test@12345 |

@Daily
@TestLogin
Scenario Outline: Test Login  with invalid multi users in Word Press
	Given I am in Login Page
	When  I click Login Link
		And I enter username '<username>'
		And I enter password '<password>'
		And I click login button
	Then I can log in unsuccessfully
	Examples: 
	| username   | password   |
	| nhunguyenq | test@123  |
	| wimh0205  | test@12345 |

	
	