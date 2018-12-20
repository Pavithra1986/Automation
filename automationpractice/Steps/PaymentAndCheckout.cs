using automationpractice.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace automationpractice.Steps
{
    [Binding]
    public sealed class PaymentAndCheckout
    {

        ShippingPage ObjShippingPage = new ShippingPage();
        PaymentPage ObjPaymentPage = new PaymentPage();

        [Then(@"Continue With Shipping")]
        public void ThenContinueWithShipping()
        {
            ObjShippingPage.AgresstermsandCondition();
        }

        [Then(@"Payment And Submit")]
        public void ThenPaymentAndSubmit()
        {
            ObjPaymentPage.SelectpaymentmethodAndSubmitOrder();
        }


    }
}
