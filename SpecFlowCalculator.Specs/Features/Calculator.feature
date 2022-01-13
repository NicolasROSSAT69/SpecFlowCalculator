Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**
		
@add
Scenario: Add numbers
	Given the list number is 30, 2, 1
	When the n numbers are added
	Then the result should be 33
	
@multiply
Scenario: Multiply numbers
	Given the list number is 30, 2, 1
	When the n numbers are multiplied
	Then the result should be 60
	
@divide
Scenario: Divide numbers
	Given the list number is 20, 2, 2 
	When the n numbers are divided
	Then the result should be 5