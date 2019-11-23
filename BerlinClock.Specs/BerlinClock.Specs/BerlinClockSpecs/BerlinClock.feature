Feature: BerlinClock
	In order to avoid using regular clocks
	As a Berlin CLock
	I want to display a given time in a cool way

@mytag
Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Just before midnight
When the time is "23:59:58"
Then the clock should look like
"""
Y
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight 
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Almost time for a tea 16:59:59
When the time is "16:59:59"
Then the clock should look like
"""
O
RRRO
ROOO
YYRYYRYYRYY
YYYY
"""