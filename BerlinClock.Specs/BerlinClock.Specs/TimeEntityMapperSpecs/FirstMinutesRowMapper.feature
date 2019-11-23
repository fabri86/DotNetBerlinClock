Feature: FirstMinutesRowMapperSteps
	As a Minutes Mapper 
	I want to map an integer value into a code 
	so that I can have the partial value of the clock for first minutes row of LEDs 

@mytag


Scenario: First Minutes Row, value 0
	Given the value for the first minute row is "0"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "OOOOOOOOOOO"

Scenario: First Minutes Row, value 1
	Given the value for the first minute row is "1"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YOOOOOOOOOO"

Scenario: First Minutes Row, value 2
	Given the value for the first minute row is "2"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYOOOOOOOOO"

Scenario: First Minutes Row, value 3
	Given the value for the first minute row is "3"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYROOOOOOOO"

Scenario: First Minutes Row, value 4
	Given the value for the first minute row is "4"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYOOOOOOO"

Scenario: First Minutes Row, value 5
	Given the value for the first minute row is "5"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYOOOOOO"

Scenario: First Minutes Row, value 6
	Given the value for the first minute row is "6"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYROOOOO"

Scenario: First Minutes Row, value 7
	Given the value for the first minute row is "7"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYRYOOOO"

Scenario: First Minutes Row, value 8
	Given the value for the first minute row is "8"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYRYYOOO"
	 
Scenario: First Minutes Row, value 9
	Given the value for the first minute row is "9"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYRYYROO"

Scenario: First Minutes Row, value 10
	Given the value for the first minute row is "10"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYRYYRYO"

Scenario: First Minutes Row, value 11
	Given the value for the first minute row is "11"
	Given the colors are "Y,R"
	Then the first minute row sequence should look like "YYRYYRYYRYY"