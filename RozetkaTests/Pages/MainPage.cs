using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RozetkaTests.Pages
{
    public class MainPage
    {
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "div.menu-outer button.menu-toggler .menu-toggler__text")]
        public IWebElement catalogButton;

        [FindsBy(How = How.CssSelector, Using = "a[href = 'https://rozetka.com.ua/notebooks/asus/c80004/v004/']")]
        public IWebElement asusCatalogMenuLink;

        [FindsBy(How = How.CssSelector, Using = ".header-actions__dummy-content.header-actions__dummy-content_type_cart")]
        public IWebElement headerPopUpBasket;

        [FindsBy(How = How.CssSelector, Using = "a[href='https://my.rozetka.com.ua/cart/']")]
        public IWebElement basketButton;
    }

}
