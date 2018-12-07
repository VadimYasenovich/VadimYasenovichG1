using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RozetkaTests.Pages
{
    class AsusLeptopSectionPage
    {
        public AsusLeptopSectionPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1[itemprop='name']")]
        public IWebElement nameOfSection;
    }
}
