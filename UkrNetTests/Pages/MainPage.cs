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
        [FindsBy(How = How.CssSelector, Using = "input[id='id-input-login'][class='form__input']")]
        public IWebElement loginInput;

        [FindsBy(How = How.CssSelector, Using = "input[id = 'search-input']")]
        public IWebElement searchInput;


        
    }
}
