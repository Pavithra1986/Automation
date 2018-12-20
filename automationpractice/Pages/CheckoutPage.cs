using automationpractice.Utilities;
using NUnit.Framework;
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


        [FindsBy(How = How.XPath, Using = "//input[@class='cart_quantity_input form-control grey']")]
        public IWebElement SelectedQunatity { get; set; }

        
        private StringBuilder verificationErrors;
    

        public CheckoutPage()
        {
            PageFactory.InitElements(Generic.driver, this);
            verificationErrors = new StringBuilder();
        }

        public void AddToCartandProceedToCheckout()
        {
           
                AddToCart.Clicks();
                ProceedToCheckOut.Clicks();
           
        }

        public void VerifySummaryPage(String Qunatity)
        {
            try
            {
                Assert.IsTrue(SelectedQunatity.GetText().Equals(Qunatity));
            }
            catch (AssertionException)
            {
                verificationErrors.Append("Mismatch In Selected Qunatity");
            }
        }
    }
}
