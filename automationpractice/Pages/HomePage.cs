using automationpractice.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationpractice.Pages
{
    public class HomePage
    {

        public void LaunchShoppingPortal()
        {
            Generic.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
