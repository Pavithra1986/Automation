using automationpractice.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace automationpractice.Pages
{
    public class HomePage
    {
        /* Concepts Used
        * 1. FindBy
        * 2. Used Extensive Custome Methods
        * 3. Page Navigation
        * */

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']//a[contains(text(),'Women')]")]
        public IWebElement WomenSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='subcategories']//a[contains(text(),'Dresses')]")]
        public IWebElement CasualDress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='subcategories']//a[contains(text(),'Summer Dresses')]")]
        public IWebElement SummerDress { get; set; }

        public HomePage()
        {
            PageFactory.InitElements(Generic.driver, this);
        }

        public void LaunchShoppingPortal()
        {
            Generic.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Generic.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        public void NavigateToWomenSummerDress()
        {
            //Clicks() is a Extensive Custome control. Located Under utilites Folder CustomLibrary class

            try
            {
                WomenSection.Clicks();
                CasualDress.Clicks();
                SummerDress.Clicks();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }



    }
}
