Feature: Demowebshop_login

Login into the application for Demo Webshop

@Login
Scenario:Logging into Demowebshop
	Given I go to "Demowebshopurl" on "Chrome"
	When I click on "loginlink_xpath"
	And I enter "loginusername_xpath" as "gampakumar8090@gmail.com"
	And I enter "loginpassword_xpath" as "9989818805@ajay"
	When I click on "loginbutton_xpath"
	Then Login should be "successful"
