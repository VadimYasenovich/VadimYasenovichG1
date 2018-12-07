using OpenQA.Selenium;

namespace UkrNetTests.Utils
{
    public static class IWebElementHelpers
    {
        public static void InputTextInToField(IWebDriver driver, IWebElement element, string text)
        {
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }

    }
}
