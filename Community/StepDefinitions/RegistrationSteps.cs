using Community.PageObjects;
using Community.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Community.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
        
    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            registration.EnterlastName();
        }
        
        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.enterPassword();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.enterConfirmPassword();
        }
        
        [When(@"I click signUp")]
        public void WhenIClickSignUp()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Assert.IsTrue(registration.logoutIsDisplayed());
        }
    }
}
