Feature: HomeNavigation
	Scenario: Navigation to Pricing via toolbar button
		Given User is on Home Page
		When  User clicks Pricing toolbar button
		Then  User is navigated to Pricing section

	Scenario: Navigation to Pricing via drop arrow button
		Given User is on Home Page
		When  User clicks Pricing drop arrow button
		Then  User is navigated to Pricing section