using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject.Handler
{
    /*
     * Clase para manejar la esperas explicitas
     */
    public class WaitHandler
    {

        public static bool ElementIsPresent(IWebDriver driver, By Locator)
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(drv => drv.FindElement(Locator));
                return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

    }
}
