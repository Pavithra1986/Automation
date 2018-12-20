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
    public class SignInPage
    {

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EnterEmailAddress { get; set; }
       
        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement CreateAccount { get; set; }

        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement Customer_Firstname { get; set; }            

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement Customer_Lasttname { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstNameForAddress { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement LastnameForAddress { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address { get; set; }
                
        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement city { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement Postcode { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement Phone_mobile { get; set; }


        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement AddressReference { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement SubmitAccount { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//ul[@id='address_delivery']//li[@class='address_firstname address_lastname']")]
        public IWebElement VerifyFirstNameLastName { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//ul[@id='address_delivery']//li[@class='address_address1 address_address2']")]
        public IWebElement VerifyAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//ul[@id='address_delivery']//li[@class='address_city address_state_name address_postcode']")]
        public IWebElement VerifyCityStatePinCode { get; set; }
        
        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement ProccedWithAddress { get; set; }

        private StringBuilder verificationErrors;

        public SignInPage()
        {
           PageFactory.InitElements(Generic.driver, this);
           verificationErrors = new StringBuilder();
        }

        public void createAnAccount(string EmailAddress)
        {

            Random rnd = new Random();

            String card = Convert.ToString(rnd.Next(100));

            EmailAddress = card + EmailAddress;

            EnterEmailAddress.EnterText(EmailAddress);
            CreateAccount.Clicks();
           
        }

       
        public void EnterDetailsForResgistration(String Firstname, String LastName, String PasswordText, String AddressText, String CityText, String StateText, String PostalCode, String MobilePhone, string AddressReferenceText)
            {
            
               
                    Title.Clicks();
               
                   Customer_Firstname.EnterText(Firstname);
                   Customer_Lasttname.EnterText(LastName);
                   Password.EnterText(PasswordText);
                   FirstNameForAddress.EnterText(Firstname);
                   LastnameForAddress.EnterText(LastName);
                   Address.EnterText(AddressText);
                   city.EnterText(CityText);
                   State.SelectDropDownValue(StateText);
                   Postcode.EnterText(PostalCode);
                   Phone_mobile.EnterText(MobilePhone);
                   AddressReference.EnterText(AddressReferenceText);
                   SubmitAccount.Clicks();
            
            }

        public void VerficationNameAndAddress(string element, string value)
        {

            try
            {
                
                if (element.Equals("Firstname") || element.Equals("Lastname"))
                {
                  //  Console.WriteLine("VerifyFirstNameLastName.Text =" + VerifyFirstNameLastName.Text);
                    Assert.IsTrue(VerifyFirstNameLastName.Text.Contains(value));               
                }
                if (element.Equals("Address"))
                {
                  //  Console.WriteLine("VerifyAddress.Text = " + VerifyAddress.Text);
                    Assert.IsTrue(VerifyAddress.Text.Contains(value));
                }
                if (element.Equals("City") || element.Equals("State") || element.Equals("PostalCode"))
                {
                  //  Console.WriteLine("VerifyCityStatePinCode.Text = " + VerifyCityStatePinCode.Text);
                    Assert.IsTrue(VerifyCityStatePinCode.Text.Contains(value));
                }
            }
            catch (AssertionException)
            {
                verificationErrors.Append("Mismatch In "+ element +"Displayed");
            }            
        }

        public void processAddress()
        {
            ProccedWithAddress.Clicks();
        }
    }
        
}
