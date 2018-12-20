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
    public class CheckoutPage
    {

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement AddToCart { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = "Proceed to checkout")]
        public IWebElement ProceedToCheckOut { get; set; }


        public CheckoutPage()
        {
            PageFactory.InitElements(Generic.driver, this);
        }

        public void AddToCartandProceedToCheckout()
        {
            try
            {
                AddToCart.Clicks();
                ProceedToCheckOut.Clicks();
            }
            catch (Exception)
            {

                throw new Exception();
            }

        }
    }
}
