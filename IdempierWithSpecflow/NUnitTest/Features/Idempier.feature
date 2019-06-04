Feature: Create Business Partner
In order to create Business Partner
As a admin of site
I want to login to the site and create business partner 

Scenario: Logging in with valid credentials
Given I navigated on login page from link
And I enter username and password
|field|Value|
|UserName|admin @ gardenworld.com|
|Password|GardenAdmin|
When Click on Login button
Then I should get navigated on dashboard

Scenario:Navigate to Business Partner search window and Cancel it
Given I navigated on Favorties
And I selecte Business Partner 
When I Clicked on Cancel button
Then Business Partner Search Window should get closed

Scenario: Navigate to Business Partner search window and check for reset
Given I navigated on Favorties
And I selecte Business Partner 
And I entered values in all fields
|Field|Value|
|Search Key|SK1|
|Name|TestName|
|Name2|TestName2|
|Description|Test|
When I clicked on Reset button
Then All values should get reset to blank

Scenario:Search business partner
Given I navigated on Favorties
And I selecte Business Partner 
And I entered values in all fields
|Field|Value|
|Search Key|SK1|
|Name|TestName|
|Name2|TestName2|
|Description|Test|
When I Cliked on OK button
Then I should get navigated on Business Partner window


Scenario:Create new record for busiess partner
{Given:I
 navigated on Business Partner by clicking Ok on searche window with search values
When I Cliked on New Record Icon button
And Entered value
|Field|Value|
|Name|TestBP|} Convert it into given and And
When Cliked on Save Icon button
Then New Business Partner should get created and saved