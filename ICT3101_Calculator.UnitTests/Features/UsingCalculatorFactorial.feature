﻿Feature: UsingCalculatorFactorial
In order to conquer factorial
As a factorial enthusiast
I want to understand a variety of factorial operations
@Factorial
Scenario: Factorial positive number
Given I have a calculator
When I have entered "4" into the calculator and press factorial
Then the factorial result should be "24"
@Factorial
Scenario: Factorial zero
Given I have a calculator
When I have entered "0" into the calculator and press factorial
Then the factorial result should be "1"
@Factorial
Scenario: Factorial negative number
Given I have a calculator
When I have entered "-5" into the calculator and press factorial
Then the factorial result should be invalid argument
