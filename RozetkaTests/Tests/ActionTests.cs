using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using RozetkaTests.Pages;
using RozetkaTests.Utils;
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

        public void OpenSectionLeptopAsus_PositiveTest ()
        {
            // Arrange

            var expectedText = "Ноутбуки Asus";

            // Act
            Actions actions = new Actions(driver);
            MainPage mainPage = new MainPage(driver);

            actions.Click(mainPage.catalogButton).MoveToElement(mainPage.asusCatalogMenuLink).Click().Perform();
            AsusLeptopSectionPage asusLeptopSectionPage = new AsusLeptopSectionPage(driver);
            var currentText = WebElementHelpers.GetText(asusLeptopSectionPage.nameOfSection);

            // Assert

            Assert.True(currentText.Contains(expectedText), $"Page not have expected text. CurrentText= {currentText} expectedText= {expectedText}");

            




            Thread.Sleep(6000);


        }
        


    }
}
