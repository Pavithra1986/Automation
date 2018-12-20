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
    public sealed class SiginAndRegister
    {
        public SignInPage ObjSignInPage = new SignInPage();

        public readonly Properties ObjEmail;

        public SiginAndRegister(Properties prop)
        {
            this.ObjEmail = prop;
        }

        [Then(@"Create Account")]
        public void ThenCreateAccount(Table table)
        {
            try
            {
                var data = table.CreateDynamicSet();              

                foreach (var item in data)
                {
                    ObjEmail.Email = (string)item.Email;
                    ObjEmail.Title = (string)item.Title;
                    ObjEmail.Firstname = (string)item.Firstname;
                    ObjEmail.LastName = (string)item.LastName;
                    ObjEmail.Password = (string)item.Password;
                    ObjEmail.Address = (string)item.Address;
                    ObjEmail.City = (string)item.City;
                    ObjEmail.State = (string)item.State;
                    ObjEmail.PostalCode = (int)item.PostalCode;
                    ObjEmail.MobilePhone = (Int64)item.MobilePhone;
                    ObjEmail.AddressReference = (string)item.AddressReference;

                }
               
                ObjSignInPage.createAnAccount(ObjEmail.Email);
                ObjSignInPage.EnterDetailsForResgistration(ObjEmail.Firstname, ObjEmail.LastName, ObjEmail.Password, ObjEmail.Address, ObjEmail.City, ObjEmail.State, Convert.ToString(ObjEmail.PostalCode), Convert.ToString(ObjEmail.MobilePhone), ObjEmail.AddressReference);

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

    }
}
