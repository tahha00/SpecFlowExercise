Feature: Login

A short summary of the feature

@tag1
Scenario: Valid Login
	Given I am on the login page
	When I login with 'Edgewords' and 'edgewords123'
	Then The add record page appears
