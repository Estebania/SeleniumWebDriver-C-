using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using System.Configuration;


namespace SeleniumProject.Handler
{
    public class ScreenShotHandler
    {
       
        //Metodo para realizar la captura de pantalla con selenium
        //Retorna la direccion de la imagen que se capturo
        public static string TakeScreenShot(IWebDriver driver)
        {
             string DirectoryPath = Path.GetFullPath(@"SeleniumProject\imgFailed");
             long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string imagePath = DirectoryPath + "//img_" + milliseconds + ".png";
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);

            return imagePath;
                
        }

    }
}
