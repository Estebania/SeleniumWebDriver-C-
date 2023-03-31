using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObject
{
    /*
     * Clase para representar la pantalla de login
     */
    public class LoginPage : BasePage
    {
        

        //Localizadores
        protected By UserInput = By.Id("user");
        protected By PasswordInput = By.Id("pass");
        protected By LoginBotton = By.Id("loginButton");

        //Constructor, lanza una exepcion si el titulo de la pagina del login no es el correto
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

            if (!Driver.Title.Equals("AUT Login – TestFaceClub"))
            {
                throw new Exception("Esta no es la pagina del login");
            }

        }

        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }
        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginBotton).Click();
        }
        //Metodo para loguearse retorna la pagina del formulario de Empleado 
        public EmployeePage LoginAs(string user, string password) { 

            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new EmployeePage(Driver);
        }

    }
}
