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
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set;}

        public void ClickOnlogin()
        {
            login.Click();
        }
    }
}
