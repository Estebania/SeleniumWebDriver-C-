using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;

namespace SeleniumProject.TestCase 
{
    /*
     * Clase que contiene los casos de prueba del login
     */
    [TestFixture]//Anotacion de NUnit para marcar una clase que contenga casos de prueba
    public class LoginTest : BaseTest
    {
        
        //Test: Anotacion de NUnit para marcar a un metodo como un caso de prueba automatizado.
        [Test]
        public void SuccesfullLoginPage()
        {//Metodo que implementa el caso de prueba del login
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("Admin","Admin123");

            Assert.IsTrue(employeePage.FormIsPrensent());

        }
        
    }
}
