using FluentAssertions;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TestableYahtze;

namespace YahtzeSpecByExampleTests
{
    [Binding]
    public class YahtzeRollsSteps
    {
        IEnumerable<IDie> currentRoll;
        bool checkResult = false;

        [Given(@"a roll with the values (.*), (.*), (.*), (.*) and (.*)")]
        public void GivenARollWithTheValuesAnd(int p0, int p1, int p2, int p3, int p4)
        {
            currentRoll = new[]{DieTestMockingHelper.CreateMockD6(p0),
                DieTestMockingHelper.CreateMockD6(p1),
                DieTestMockingHelper.CreateMockD6(p2),
                DieTestMockingHelper.CreateMockD6(p3),
                DieTestMockingHelper.CreateMockD6(p4)};
        }

        [When(@"I check for a valid Yahtze")]
        public void WhenICheckForAValidYahtze()
        {
            checkResult = currentRoll.IsYahtze();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(bool p0)
        {
            checkResult.Should().Be(p0);
        }

        [When(@"I check for a valid Full House")]
        public void WhenICheckForAValidFullHouse()
        {
            checkResult = currentRoll.IsFullHouse();
        }

    }
}
