using System;
using System.IO;

class Test
{

    public static void Main()
    {
        
        string path3 = @"imgFailed";

        

        Console.WriteLine("The full path of {0} is {1}.", path3, Path.GetFullPath(@"~\SeleniumProject\imgFailed"));
        //Console.WriteLine("{0} is the location for temporary files.", Path.GetTempPath());
        //Console.WriteLine("{0} is a file available for use.", Path.GetTempFileName());

        /* This code produces output similar to the following:
         * c:\temp\MyTest.txt has an extension.
         * c:\temp\MyTest has no extension.
         * The string temp contains no root information.
         * The full path of temp is D:\Documents and Settings\cliffc\My Documents\Visual Studio 2005\Projects\ConsoleApplication2\ConsoleApplication2\bin\Debug\temp.
         * D:\Documents and Settings\cliffc\Local Settings\Temp\8\ is the location for temporary files.
         * D:\Documents and Settings\cliffc\Local Settings\Temp\8\tmp3D.tmp is a file available for use.
         */
    }
}