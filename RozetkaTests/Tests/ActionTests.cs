using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using RozetkaTests.Pages;
using System;
using System.Threading;

namespace RozetkaTests.Tests
{
    class ActionTests
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]

        public void LinkAsus ()
        {
            Actions actions = new Actions(driver);
            MainPage mainPage = new MainPage(driver);

            actions.Click(mainPage.catalogButton);
            Thread.Sleep(2000);
            actions.Click(mainPage.asusCatalogMenuLink);



            Thread.Sleep(6000);


        }
        


    }
}
