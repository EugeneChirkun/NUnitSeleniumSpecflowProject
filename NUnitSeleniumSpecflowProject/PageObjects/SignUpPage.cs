using NUnitSeleniumSpecflowProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitSeleniumSpecflowProject.PageObjects
{
    internal class SignUpPage
    {
        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement submitButton => driver.FindElement(By.XPath("//button[contains(text(), 'Sign up')]"));

        public void EnterUsername()
        {
            username.SendKeys("UsernameTest");
        }

        public void EnterEmail()
        {
            email.SendKeys("EmailTest@test.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordTest");
        }
        public void ClickSignUpBtn()
        {
            submitButton.Click();
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }
    }
}
