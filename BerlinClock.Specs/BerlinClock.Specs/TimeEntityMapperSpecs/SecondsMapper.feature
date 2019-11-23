Feature: SecondsMapperSteps
	As a Seconds Mapper 
	I want to map an integer value into a code 
	so that I can have the partial value of the clock for the blinking LED

@mytag
Scenario: Even value of seconds
	Given the value for the seconds is "0"
	Given the colors for the seconds is "Y"
	Then the code value for the blinking led should look like "Y"

Scenario: Odd value of seconds
	Given the value for the seconds is "1"
	Given the colors for the seconds is "Y"
	Then the code value for the blinking led should look like "O"