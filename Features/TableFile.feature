Feature: LoginwithTableintoDictoryKeyword

@mytag
Scenario: Login with table
                   Given as a user is on Home Page
                   And navigate to Login Page
                   When user enter credentials
                   | Key        | Value    |
                   | username   | Admin    |
                   | password   | admin123 |
                   
                   And user is clicking on login button.
                   Then user should lands on Dashboard Page.

 

                                                        