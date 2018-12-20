using automationpractice.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationpractice.Pages
{
    public class CartSummary
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='button btn btn-default standard-checkout button-medium'and contains(@title,'Proceed to checkout')]")]
        public IWebElement proceedCheckout { get; set; }

        public CartSummary()
        {
            PageFactory.InitElements(Generic.driver, this);
        }

        public void proceedToCheckout()
        {
            proceedCheckout.Clicks();
        }
    }
}
