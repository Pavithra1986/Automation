using automationpractice.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace automationpractice.Steps
{
    [Binding]
    public sealed class Shopping
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public HomePage ObjHomePage = new HomePage();

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


    }
}
