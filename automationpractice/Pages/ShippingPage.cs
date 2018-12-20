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
    public class ShippingPage
    {
        [FindsBy(How = How.Id, Using = "uniform-cgv")]
        public IWebElement TermsAndCondition { get; set; }

        
        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement Procced { get; set; }




        public ShippingPage()
        {
            PageFactory.InitElements(Generic.driver, this);
           
        }

        public void AgresstermsandCondition()
        {
            TermsAndCondition.Clicks();
            Procced.Clicks();
        }
    }
}
