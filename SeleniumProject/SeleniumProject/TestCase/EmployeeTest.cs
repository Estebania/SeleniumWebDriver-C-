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
     * Clase con los casos de prueba de pruebas de Emplados
     */
    [TestFixture]
    public class EmployeeTest : BaseTest
    {
        //Selemium driver
        
        private EmployeePage EmployeePage;
        //SetUp: Anotacion de NUnit para ejecutar un metodo antes de cada test
        [SetUp]
        public void BeforeTest()
        { //Merodo para iniciar el navegador y navedar a una URL y logearse en la aplicacion

            
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage  = loginPage.LoginAs("Admin", "Admin123");


        }

        //TestCase: Anotacion de NUnit que permite validar un caso de pruba con varios datos 
        [TestCase("", "maria@gmail.com", "Zona 5", "458632")]
        [TestCase("Tania", "tania@gmail.com", "Zona 6", "458638")]
        public void AddEmployeeTest(string name, string email, string address, string phone)
        {
            EmployeePage.AddEmployee(name, email, address, phone);
            Assert.IsTrue(EmployeePage.IsSuccessAlertPrensent());

        }

    }
}
