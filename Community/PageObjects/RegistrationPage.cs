using Community.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.Id, Using = "//a[ @href='https://giftrete.com/logout/']")]
        private IWebElement logout { get; set; }

        public bool logoutIsDisplayed()
        {
            return logout.Displayed;
        }

     


        public void enterConfirmPassword()
        {
            confirmPassword.SendKeys("AJIBAde29");
        }

        public void enterPassword()
        {
            password.SendKeys("AJIBAde29");
        }

        public void EnterMobileNumber()
        {
            mobileNumber.SendKeys("0951741221");
        }

        public void ClickSignUp()
        {
            signUp.Click();
        }

        public void ClickOnRegister()
        {
            register.Click();
        }
        public void EnterFirstName()
        {
            firstName.SendKeys("Femi");
        }

        public void EnterEmailAddress (string myEmail)

        {
            emailAddress.SendKeys(myEmail);

    }
        public void EnterlastName()
        {
            lastName.SendKeys("Ola");
        }

    
}
}
