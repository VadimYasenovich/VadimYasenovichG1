using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using UkrNetTests.Pages;
using UkrNetTests.Utils;

namespace UkrNetTests.Tests
{
    class LoginTests
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://www.ukr.net/");
        }
        
        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]

        public void TestLogin()
        {
            MainPage mainPage = new MainPage(driver);
            var text = XmlHelpers.GetNodeText("LoginCorrect1");
            IWebElementHelpers.InputTextInToField(driver, mainPage.loginInput, text);
            text = XmlHelpers.GetNodeText("PasswordCorrect1");
            IWebElementHelpers.InputTextInToField(driver, mainPage.PasswordInput, text);
                        
            Thread.Sleep(6000);
            
            
        }

       

    }
}
