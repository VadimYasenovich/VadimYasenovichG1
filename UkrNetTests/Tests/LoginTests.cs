using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using UkrNetTests.Pages;

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

        public void TestMethod1()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.searchInput.Click();
            mainPage.searchInput.Clear();
            mainPage.searchInput.SendKeys("Test");

            Thread.Sleep(2000);


        }

    }
}
