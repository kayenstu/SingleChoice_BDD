using System;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace SingleChoice_BDD
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        SingleChoice mySingleChoice;

        [Given(@"I select Create Single Choice questions")]
        public void GivenISelectCreateSingleChoiceQuestions()
        {
            mySingleChoice = new SingleChoice();
        }
        [Given(@"enter (.*) as name of Single Choice question")]
        public void GivenEnterAsNameOfSingleChoiceQuestion(string p0)
        {
            mySingleChoice.name = p0;
        }
        [Given(@"enter (.*) as question text")]
        public void GivenEnterAsQuestionText(string p0)
        {
            mySingleChoice.question = p0;
        }

        [When(@"I enter (.*) as answer option")]
        public void WhenIEnterAsAnswerOption(string p0)
        {
            mySingleChoice.answers.Add(p0);
        }
        [When(@"I enter (.*) as right answer option")]
        public void WhenIEnterAsRightAnswerOption(string p0)
        {
            mySingleChoice.answers.Add(p0);
            mySingleChoice.choice = mySingleChoice.answers.Count() - 1;
        }

        [Then(@"the single choice question with the name (.*) is stored in my system")]
        public void ThenTheSingleChoiceQuestionWithTheNameIsStoredInMySystem(string p0)
        {
            var actual = String.Equals(mySingleChoice.name, p0);
            Assert.True(actual);
        }
        [Then(@"(.*) is the right choice")]
        public void ThenIsTheRightChoice(string p0)
        {
            var expected = mySingleChoice.choice;
            var actual = mySingleChoice.answers.IndexOf(p0);
            Assert.Equal(expected, actual);
        }
        [Then(@"(.*) is not the right choice")]
        public void ThenIsNotTheRightChoice(string p0)
        {
            var expected = mySingleChoice.choice;
            var actual = mySingleChoice.answers.IndexOf(p0);
            Assert.NotEqual(expected, actual);
        }
    }

}
