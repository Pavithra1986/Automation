using automationpractice.Pages;
using automationpractice.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace automationpractice.Steps
{
    [Binding]
    public sealed class Shopping
    {
       
       //Concept Used Context Injection
        

        public HomePage ObjHomePage = new HomePage();
        public WomenDresses ObjWomenDresses = new WomenDresses();
        public CheckoutPage ObjCheckoutPage = new CheckoutPage();
        public CartSummary ObjCartSummary = new CartSummary();

        public readonly Properties Dressdetails;

        public Shopping(Properties prop)
        {
            this.Dressdetails = prop;
        }

        [Given(@"Launch Shopping Portal")]
        public void GivenLaunchShoppingPortal()
        {
            ObjHomePage.LaunchShoppingPortal();
        }

        [Then(@"Navigate To Women Summer Dress")]
        public void ThenNavigateToWomenSummerDress()
        {
            ObjHomePage.NavigateToWomenSummerDress();
        }

        [Then(@"Pick a Dress And Choose Size and Qunatity")]
        public void ThenPickADressAndChooseSizeAndQunatity(Table table)
        {
            try
            {
                var data = table.CreateDynamicSet();

                foreach (var item in data)
                {
                    Dressdetails.Qunatity = (int)item.Qunatity;
                    Dressdetails.Size = (string)item.Size;

                }

                Console.WriteLine("Dressdetails.Qunatity = " + Dressdetails.Qunatity);
                Console.WriteLine("Dressdetails.Size =  " + Dressdetails.Size);

                ObjWomenDresses.SelectADress();
                ObjWomenDresses.EnterQunatityAndSize(Convert.ToString(Dressdetails.Qunatity), Dressdetails.Size);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }


        [Then(@"Add To Cart And Proceed Checkout")]
        public void ThenAddToCartAndProceedCheckout()
        {
            ObjCheckoutPage.AddToCartandProceedToCheckout();
            ObjCartSummary.proceedToCheckout();
        }

        
    }
}
