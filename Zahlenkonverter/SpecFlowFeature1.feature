Feature: SpecFlowFeature1
	In order to convert numbers
	As a math idiot
	I want to be told the coverted numbers of hexadecimal, octal and binary 

@mytag
Scenario: hexadecimal conversion
	Given the number is "affe"
	When the conversion is hexadecimal
	Then the result should be 45054