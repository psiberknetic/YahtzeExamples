using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TestableYahtze;

namespace YahtzeSpecByExampleTests
{
    [Binding]
    public class YahtzeScoresheetSteps
    {
        private ScoreSheet scoresheetWithYahtze
        {
            get
            {
                var ss = new ScoreSheet();

                ss.AddYahtze(DieTestMockingHelper.CreateYahtze(5));
                return ss;
            }
        }

        ScoreSheet currentScoreSheet;
        IEnumerable<IDie> currentRoll;
        Action currentScoreSheetAction;


        [Given(@"I have a scorecard with a Yahtze scored")]
        public void GivenIHaveAScorecardWithAYahtzeScored()
        {
            currentScoreSheet = scoresheetWithYahtze;
        }

        [Given(@"I get a Yahtze")]
        public void GivenIGetAYahtze()
        {
            currentRoll = DieTestMockingHelper.CreateYahtze(3);
        }

        [When(@"I try to score a Yahzte")]
        public void WhenITryToScoreAYahzte()
        {
            currentScoreSheetAction = () => currentScoreSheet.AddYahtze(currentRoll);
        }

        [Then(@"I receive an exception")]
        public void ThenIReceiveAnException()
        {
            currentScoreSheetAction.Should().Throw<ArgumentException>();
        }

        [Given(@"I have a blank scorecard")]
        public void GivenIHaveABlankScorecard()
        {
            currentScoreSheet = new ScoreSheet();
        }

        [Then(@"The Yahtze Score Should Be (.*)")]
        public void ThenTheYahtzeScoreShouldBe(int p0)
        {
            currentScoreSheetAction.Should().NotThrow();
            currentScoreSheet.YahzteScore.Should().Be(p0);
        }

        [Given(@"I do not have a Yahtze")]
        public void GivenIDoNotHaveAYahtze()
        {
            currentRoll = DieTestMockingHelper.CreateRollWithNoSpecialScore();
        }

        [Given(@"I roll a Full House")]
        public void GivenIRollAFullHouse()
        {
            currentRoll = DieTestMockingHelper.CreateRollWithFullHouse();
        }

        [When(@"I try to score a Full House")]
        public void WhenITryToScoreAFullHouse()
        {
            currentScoreSheetAction = () => currentScoreSheet.AddFullHouse(currentRoll);
        }

        [Then(@"The Full House score should be (.*)")]
        public void ThenTheFullHouseScoreShouldBe(int p0)
        {
            currentScoreSheetAction.Should().NotThrow();
            currentScoreSheet.FullHouseScore.Should().Be(p0);
        }
    }
}
