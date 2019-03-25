Feature: login
	As a registered user of giftrete
	I would like to login
	So that i can use the site

@mytag
Scenario: Login to the site
	Given I navigate to the website
	When I click on login link
	And I enter my username
	And I enter my password
	And I click on login button
    Then I should be login

Scenario: Invalid login to the site
     Given I navigate to the website
	 When I click on login link
	 And I enter null my username
	 And I enter null my password
	 And I click on login button
     Then I should be login 