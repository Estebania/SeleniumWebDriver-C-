using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumProject.Handler;

namespace SeleniumProject.PageObject
{
    /*
     * Clase para representar el la pagina del formulario Empleado
     */
    public class EmployeePage : BasePage
    {
        

        //Localizadores
        protected By Form = By.Id("formEmployee");
        protected By NameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        protected By EmailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        protected By AddressTextArea = By.Id("address");
        protected By PhoneInput = By.Id("phone");
        protected By AddButton = By.Id("addButton");
        protected By CancelButton = By.Id("cancelButton");

        public EmployeePage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("AUT Form – TestFaceClub"))
            {
                throw new Exception("Esta no es la pagina del Empleados");
            }


        }

        //Metodo para detrminar si la pagina del formulario del empleado esta cargada.
        public  bool FormIsPrensent()
        {
            return WaitHandler.ElementIsPresent(Driver, Form);
        }

        //Metodo para agregar el empleado
        public void AddEmployee(string name, string email, string address,string phone)
        {
            Driver.FindElement(NameInput).SendKeys(name);
            Driver.FindElement(EmailInput).SendKeys(email);
            Driver.FindElement(AddressTextArea).SendKeys(address);
            Driver.FindElement(PhoneInput).SendKeys(phone);
            Driver.FindElement(AddButton).Click();

        }

        //Metodo para capturar y aceptar una alerta
        public bool IsSuccessAlertPrensent()
        {
            try
            {
                Driver.SwitchTo().Alert().Accept();
                return true;

            }
            catch (NoAlertPresentException)
            {

                throw;
            }
            return false;
        }
    }
}
