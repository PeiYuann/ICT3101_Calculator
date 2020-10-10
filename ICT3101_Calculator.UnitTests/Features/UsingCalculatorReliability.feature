Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metricenthusiast
I want to use my calculator to do this

@Reliability
Scenario: Calculating CFI
 Given I have a calculator
 When I have entered "10" and "50" and "100" into the calculator and press CFI
 Then the reliability result should be "5"

 @Reliability
Scenario: Calculating AEF
 Given I have a calculator
 When I have entered "10" and "10" and "100" into the calculator and press AEF
 Then the reliability result should be "63"