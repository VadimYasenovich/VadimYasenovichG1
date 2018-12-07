using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UkrNetTests.Pages
{
    public class MainPage
    {
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);            
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='d - input - login']")]
        public IWebElement loginInput;

        [FindsBy(How = How.CssSelector, Using = "# id-input-password")]
        public IWebElement PasswordInput;

        [FindsBy(How = How.CssSelector, Using = "input[id = 'search-input']")]
        public IWebElement searchInput;





    }
}
