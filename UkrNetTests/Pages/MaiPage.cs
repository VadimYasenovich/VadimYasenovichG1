using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UkrNetTests.Pages
{
    class MaiPage
    {
        public MaiPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);            
        }
        [FindsBy(How = How.CssSelector, Using = "#id-input-login")]
        public IWebElement loginInput;
    }
}
