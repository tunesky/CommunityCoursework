using Community.PageObjects;
using Community.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class LoginSteps : Hooks

    {
        LoginPage loginPage;

       public  LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
          // Driver.
        }
        
        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.ClickOnlogin();
        }
        
        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter null my username")]
        public void WhenIEnterNullMyUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter null my password")]
        public void WhenIEnterNullMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be login")]
        public void ThenIShouldBeLogin()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
