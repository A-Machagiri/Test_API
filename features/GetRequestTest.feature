Feature: Test GET Request for User's API

  Scenario: Testing GET request to /posts/1 endpoint
    Given I have the base URL "https://jsonplaceholder.typicode.com"
    When I send a GET request to "/posts/1"
    Then I should receive a 200 status code
    And the response should contain the correct data for post 1