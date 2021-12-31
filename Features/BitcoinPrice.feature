Feature: BitcoinPrice

A short summary of the feature

@tag1
Scenario: Bitcoin Price
	Given Navigate to "https://www.coindesk.com/price/bitcoin/"
	When Hover on graph and enter "30 Dec 2021, 05:03 GMT+5:30"
	Then Bitcoin price at that time will be displayed
