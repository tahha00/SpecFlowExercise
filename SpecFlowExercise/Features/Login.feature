Feature: Login

Background: 
Given I am on the login page
When I login with 'edgewords' and 'edgewords123'

@SmokeTests
Scenario: Valid Login
	Then The add record page appears

@SmokeTests
Scenario: Login Links
	Then The add record page appears
	And I see the following nav links
		| link          |
		| Add Record    |
		| Edit Record   |
		| Remove Record |
		| List Records  |
		| Log Out       |

	

