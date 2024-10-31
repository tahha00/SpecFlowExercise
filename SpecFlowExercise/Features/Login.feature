Feature: Login

A short summary of the feature

@tag1
Scenario: Valid Login
	Given I am on the login page
	When I login with 'Edgewords' and 'edgewords123'
	Then The add record page appears

Scenario: Login Links
	Given I am on the login page
	When I login with 'Edgewords' and 'edgewords123'
	Then The add record page appears
	And I see the following nav links
		| link          |
		| Add Record    |
		| Edit Record   |
		| Remove Record |
		| List Records  |
		| Log Out       |

	

