Feature: TMFeature

As an admin of the Turnup portal
I would like to create,edit and delete records
so that i can manage employee time and material records sucessfully

@tag1
Scenario: create time and material records sucessfully
	Given I logged into turnup portal sucessfully
	When I navigate to time and material page
	When I create time and material record sucessfully
	Then Time and material record should be created sucessfully
