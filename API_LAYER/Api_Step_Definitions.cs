using RestSharp;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace ApiTests.StepDefinitions
{
    [Binding]
    public class ApiStepDefinitions
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse response;

        [Given(@"I have the base URL ""(.*)""")]
        public void GivenIHaveTheBaseUrl(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }

        [When(@"I send a GET request to ""(.*)""")]
        public void WhenISendAGETRequestTo(string endpoint)
        {
            request = new RestRequest(endpoint, Method.GET);
            response = client.Execute(request);
        }

        [Then(@"I should receive a (.*) status code")]
        public void ThenIShouldReceiveAStatusCode(int statusCode)
        {
            response.StatusCode.Should().Be(statusCode);
        }

        [Then(@"the response should contain the correct data for post (.*)")]
        public void ThenTheResponseShouldContainTheCorrectDataForPost(int postId)
        {
            // Additional validation can be implemented here based on the expected response data
        }
    }
}