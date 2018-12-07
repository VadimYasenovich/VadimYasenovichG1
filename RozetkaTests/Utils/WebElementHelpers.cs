using OpenQA.Selenium;
using System;

namespace RozetkaTests.Utils
{
    public static class WebElementHelpers
    {
        public static string GetText(this IWebElement element)
        {
            var text = string.Empty;

            if (element.GetAttribute("textContent") != null)
            {
                text = element.GetAttribute("textContent");
            }
            else if (element.GetAttribute("value") != null)
            {
                text = element.GetAttribute("value");
            }
            else if (element.Text != string.Empty)
            {
                text = element.Text;
            }
            else
            {
                throw new Exception("Unexpected exception while getting text from");
            }
            return text;
        }
    }
}
