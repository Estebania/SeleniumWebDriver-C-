using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;

namespace SeleniumProject.Handler
{
    public class ScreenShotHandler
    {
        //Optener la direccion del directorio donde se va a guardar la imagen 
        private static string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        //Metodo para realizar la captura de pantalla con selenium
        //Retorna la direccion de la imagen que se capturo
        public static string TakeScreenShot(IWebDriver driver)
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string imagePath = DirectoryPath + "//img_" + milliseconds + ".png";
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);

            return imagePath;
                
        }

    }
}
