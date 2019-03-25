Feature: Registration
	So that i can use the site
	I need to register

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter lastname
	And I enter email "test@mygiftrete.com"
	And I enter mobile number
	And I enter password
	And I confirm password
    And I click signUp
  # Then I should be registered
