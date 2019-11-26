Feature: Yahtze Rolls
	As a Yahtze player
    I need the system to be able to recognize Yahtze rolls
    In order to accurately allow me to score my rolls

@mytag
Scenario Outline: Validate Yahtze
	Given a roll with the values <die1>, <die2>, <die3>, <die4> and <die5>
	When I check for a valid Yahtze
	Then the result should be <result>

	Examples:
		| die1 | die2 | die3 | die4 | die5 | result |
		| 1    | 1    | 1    | 1    | 1    | true   |
		| 1    | 2    | 3    | 4    | 5    | false  |
		| 2    | 2    | 2    | 2    | 2    | true   |
		| 3    | 3    | 3    | 3    | 3    | true   |
		| 1    | 1    | 1    | 1    | 5    | false  |

Scenario Outline: Validate Full House
	Given a roll with the values <die1>, <die2>, <die3>, <die4> and <die5>
	When I check for a valid Full House
	Then the result should be <result>

	Examples:
		| die1 | die2 | die3 | die4 | die5 | result |
		| 1    | 1    | 3    | 3    | 3    | true   |
		| 1    | 2    | 3    | 4    | 5    | false  |
		| 2    | 2    | 2    | 5    | 5    | true   |
		| 3    | 3    | 3    | 3    | 3    | false  |
		| 1    | 1    | 1    | 1    | 5    | false  |
		| 6    | 6    | 6    | 6    | 6    | false  |