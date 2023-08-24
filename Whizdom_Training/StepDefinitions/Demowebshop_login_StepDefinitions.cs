namespace Whizdom_Training.StepDefinitions
{
    
    [Binding]
    public sealed class Demowebshop_login_StepDefinitions
    {
        Utility utility = new Utility();

        [Given(@"I go to \""(.*)"" on \""(.*)""")]
        public void GivenIGoToOn(string url, string browser)
        {
            Console.WriteLine($"Navigate to {url}- On the browser {browser}");
            Utility.GetConfigurationUsingSection();
            utility.openbrowser(browser);
            utility.Navigateurl(url);
        }
           
        [When(@"I click on \""(.*)""")]
        public void WhenIClickOn(string objct)
        {
            Console.WriteLine($"Click on : {objct}");
            utility.click(objct);

        }

        [When(@"I enter \""(.*)"" as \""(.*)""")]
        public void WhenIEnterAs(string objct, string text)
        {
            Console.WriteLine($"Entering - {objct}, with value as - {text}");
            utility.type(objct, text);

        }

        [Then(@"Login should be \""(.*)""")]
        public void ThenLoginShouldBe(string expectedresult)
        {
            Console.WriteLine($"Login is {expectedresult}");
        }

    }
}