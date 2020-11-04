Feature: SpecFlowFeature1
As Lektor
I want to prepare Single Choice Questions


Scenario: Create Single Choice question

Given I select Create Single Choice questions
And enter <Agile Method> as name of Single Choice question
And enter <Which of the methods has an agile approach?> as question text
When I enter <Waterfall> as answer option
And I enter <V-Modell> as answer option
And I enter <Scrum> as right answer option
Then the single choice question with the name <Agile Method> is stored in my system
And <Scrum> is the right choice
But <Waterfall> is not the right choice
But <V-Modell> is not the right choice 
