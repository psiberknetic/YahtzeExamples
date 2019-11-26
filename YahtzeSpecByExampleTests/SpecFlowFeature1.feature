Feature: YahtzeScoresheet
    As a Yahtze player
    I need a way to keep score during a game
    So I can know if I've won or lost

@fast
Scenario: YahtzeScoredOnlyOnce
	Given I have a scorecard with a Yahtze scored
	And I get a Yahtze
	When I try to score a Yahzte
	Then I receive an exception

@fast
Scenario: YahtzeIs50Points
	Given I have a blank scorecard
	And I get a Yahtze
	When I try to score a Yahzte
	Then The Yahtze Score Should Be 50

@fast
Scenario: Try to Score Yahtze without Yahtze
	Given I have a blank scorecard
	And I do not have a Yahtze
	When I try to score a Yahzte
	Then I receive an exception

@fast
Scenario: Full House is 25 points
	Given I have a blank scorecard
	And I roll a Full House
	When I try to score a Full House
	Then The Full House score should be 25