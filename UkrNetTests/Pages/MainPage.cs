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
        [FindsBy(How = How.CssSelector, Using = "input[class='form__input'][type='Text'][name='login']")]
        public IWebElement loginInput;

        [FindsBy(How = How.CssSelector, Using = "input[id = 'search-input']")]
        public IWebElement searchInput;

       

    }
}
