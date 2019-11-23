Feature: TimePartsValidator
	In order to validate a time
	as a Time Parts Validator
	I want to return the validation result

@mytag

Scenario: Negative hours
	Given the values -1 hours 30 minutes 00 seconds
	Then the validation should return false

Scenario: Hours Greater than 23
	Given the values 24 hours 30 minutes 1 seconds
	Then the validation should return false

Scenario: Negative minutes
	Given the values 12 hours -30 minutes 00 seconds
	Then the validation should return false

Scenario: Minutes greater than 59
	Given the values 12 hours 60 minutes 00 seconds
	Then the validation should return false

Scenario: Negative seconds
	Given the values 09 hours 25 minutes -20 seconds
	Then the validation should return false

Scenario: Seconds greater than 59
	Given the values 08 hours 46 minutes 61 seconds
	Then the validation should return false

Scenario: Valid time
	Given the values 08 hours 46 minutes 59 seconds
	Then the validation should return true

Scenario: Valid time with single digit
	Given the values 7 hours 5 minutes 7 seconds
	Then the validation should return true