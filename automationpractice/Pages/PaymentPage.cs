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
    public class PaymentPage
    {
        
        [FindsBy(How = How.XPath, Using = "//a[@title='Pay by bank wire']")]
        public IWebElement PayByBank { get; set; }
        
        
        [FindsBy(How = How.XPath, Using = "//button[@class='button btn btn-default button-medium']")]
        public IWebElement ConfirmOrder { get; set; }


        [FindsBy(How = How.XPath, Using = " //*[@class='cheque-indent']")]
        public IWebElement OrderVerfication { get; set; }

        private StringBuilder verificationErrors;

       
            public PaymentPage()
            {
            PageFactory.InitElements(Generic.driver, this);
            verificationErrors = new StringBuilder();
            }

        public void SelectpaymentmethodAndSubmitOrder()
        {
            PayByBank.Clicks();
            ConfirmOrder.Clicks();

            try
            {
              Console.WriteLine("OrderVerfication.Text  = " + OrderVerfication.Text);
              Assert.IsTrue(OrderVerfication.Text.Contains("Your order on My Store is complete"));
               
            }
            catch (AssertionException)
            {
                verificationErrors.Append("order is Not complete");
            }            
          }
    }
}
