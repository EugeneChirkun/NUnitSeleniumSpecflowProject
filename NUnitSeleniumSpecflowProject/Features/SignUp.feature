Feature: SignUp

In order to use the benefit of the website
I will need to first sign up

@tag1
Scenario: Valid Sign Up
	Given I navigate to the website
	And I enter my Username
	And I enter my Email
	And I enter my Password
	When I click on Sign up
	Then I should be able to register succesfully