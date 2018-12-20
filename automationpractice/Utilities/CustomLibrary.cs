using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationpractice.Utilities
{
    public static class CustomLibrary
    {

        public static void EnterText(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDownValue(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetSelectedValue(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().ToString();
        }

    }

}
