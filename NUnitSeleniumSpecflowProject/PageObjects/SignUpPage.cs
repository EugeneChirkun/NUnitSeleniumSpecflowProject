using NUnitSeleniumSpecflowProject.Utilities;
using OpenQA.Selenium;
using System;

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
        IWebElement popularTags => driver.FindElement(By.XPath("//p[text() = 'Popular Tags']"));

        public void EnterUsername()
        {
            username.SendKeys(UniqueNameHelper.RandomStringWithNumbers(15));
        }

        public void EnterEmail()
        {
            email.SendKeys(UniqueNameHelper.RandomStringWithNumbers(15) + "@test.com");
        }

        public void EnterPassword()
        {
            password.SendKeys(UniqueNameHelper.RandomStringWithNumbers(15));
        }
        public void ClickSignUpBtn()
        {
            submitButton.Click();
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }
        public bool IsPopularTagsDisplayed()
        {
            return popularTags.Displayed;
        }
    }
}
