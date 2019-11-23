Feature: HoursMapperSteps
	As an Hours Mapper 
	I want to map an integer value into a code 
	so that I can have the partial value of the clock for the hours row of LEDs 

@mytag


Scenario: Hours Row, value 0
	Given the value for the hours row is "0"
	Given the color for the hours row is "R"
	Then the hours row sequence should look like "OOOO"

Scenario: Hours Row, value 1
	Given the value for the hours row is "1"
	Given the color for the hours row is "R"
	Then the hours row sequence should look like "ROOO"

Scenario: Hours Row, value 2
	Given the value for the hours row is "2"
	Given the color for the hours row is "R"
	Then the hours row sequence should look like "RROO"

Scenario: Hours Row, value 3
	Given the value for the hours row is "3"
	Given the color for the hours row is "R"
	Then the hours row sequence should look like "RRRO"

Scenario: Hours Row, value 4
	Given the value for the hours row is "5"
	Given the color for the hours row is "R"
	Then the hours row sequence should look like "RRRR"