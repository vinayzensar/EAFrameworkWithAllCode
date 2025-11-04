Feature: Calculator

Simple calculator for adding two numbers


Background: 
	Given the first number is 90
	And the second number is 40

@smoke @regression @bug-1568
Scenario: Add two numbers
	Then the result for "addition" should be 130
	And I am happy to say its "PASSED"



@smoke @regression @bug-1568
Scenario: Subtract two numbers
	Then the result for "substraction" should be 50

# Tables
# Scenario Outlines
# Scenario Context