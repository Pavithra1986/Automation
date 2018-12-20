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
    public class WomenDresses
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='product_list grid row']/li[1]/div[@class='product-container']")]
        public IWebElement SelectAProduct { get; set; }

        [FindsBy(How = How.Id, Using = "quantity_wanted")]
        public IWebElement Qunatity { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='attributes']//select")]
        public IWebElement SelectSize { get; set; }


        public WomenDresses()
        {
            PageFactory.InitElements(Generic.driver, this);
        }

        public void SelectADress()
        {
            SelectAProduct.Clicks();
        }

        public void EnterQunatityAndSize(string Count, string Size)
        {

            Qunatity.EnterText(Count);
            SelectSize.SelectDropDownValue(Size);


        }
    }
}
