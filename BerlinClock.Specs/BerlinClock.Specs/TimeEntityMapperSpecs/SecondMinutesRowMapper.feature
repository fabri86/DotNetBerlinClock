Feature: SecondMinutesRowMapperSteps
	As a Minutes Mapper 
	I want to map an integer value into a code 
	so that I can have the partial value of the clock for the second minutes row of LEDs 

@mytag

Scenario: Second Minutes Row, value 0
	Given the value for the second minutes row is "0"
	Given the color for the second minutes row is "Y"
	Then the second minutes row sequence should look like "OOOO"

Scenario: Second Minutes Row, value 1
	Given the value for the second minutes row is "1"
	Given the color for the second minutes row is "Y"
	Then the second minutes row sequence should look like "YOOO"

Scenario: Second Minutes Row, value 2
	Given the value for the second minutes row is "2"
	Given the color for the second minutes row is "Y"
	Then the second minutes row sequence should look like "YYOO"

	Scenario: Second Minutes Row, value 3
	Given the value for the second minutes row is "3"
	Given the color for the second minutes row is "Y"
	Then the second minutes row sequence should look like "YYYO"

	Scenario: Second Minutes Row, value 4
	Given the value for the second minutes row is "5"
	Given the color for the second minutes row is "Y"
	Then the second minutes row sequence should look like "YYYY"