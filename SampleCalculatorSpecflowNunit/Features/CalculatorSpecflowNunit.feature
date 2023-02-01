Feature: CalculatorSpecflowNunit

This is test will show you an example on how to use specflow and Nunit together in your unit test.
Things to consider:
1. Make specflow as part of your extensions
2. Download all the required NUGET packages for NUnit
3. Download all the required NUGET packages for Specflow
4. Delete the default class that has been created when you initially created a new C# project library
5. Create 2 folders: 1 for Features and 1 for StepDefinitions

Background: 
	Given the first number is 20
	And the second number is 30

Scenario: Sum of two numbers
	When the two numbers are added
	Then the result should be 50

Scenario: Product of two numbers
	When the two numbers are multiplied
	Then the result should be 600
