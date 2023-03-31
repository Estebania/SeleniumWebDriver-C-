using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;
using SeleniumProject.Handler;
using NUnit.Framework.Interfaces;

namespace SeleniumProject.TestCase
{
    /*
     * Clasre base para tidos los test
     */
    public class BaseTest
    {
        //Selemium driver
        protected IWebDriver Driver;

        protected string url = ConfigurationManager.AppSettings["Url"];

        //SetUp: Anotacion de NUnit para ejecutar un metodo antes de cada test
        [SetUp]
        public void BeforeBaseTest()
        { //Merodo para iniciar el navegador y navedar a una URL

            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);

        }
        //TearDown: Anotacion de NUnit para ejecutar un metodo despues de cada test
        [TearDown]
        public void AfterBaseTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                ScreenShotHandler.TakeScreenShot(Driver);
            }

            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
