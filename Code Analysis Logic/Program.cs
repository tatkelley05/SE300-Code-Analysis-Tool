// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// C# program to print Hello World! 
using System;
using System.IO;
using System.Reflection;
using System.Text;

// namespace declaration 
namespace HelloWorldApp
{
    // Class declaration 
    class Geeks
    {

        // Main Method 
        public static void Main()
        {   

            //old method is commented out, new method should properly call the file properly regardless of your PC or user account
            //string path = @"C:\Users\Tatum Kelley\source\repos\Code Analysis Logic\Code Analysis Logic\javatestfiles\Lab01_Kelley.java";
            string path = @"../../../javatestfiles/Lab01_Kelley.java";



            string[] myInputFile = File.ReadAllLines(path);

            TextFormatter testTF = new TextFormatter("testTF", myInputFile);
            string[][] displayTest = testTF.formatFile();
            for (int i = 0; i < displayTest.Length; i++)
            {
                Console.WriteLine(String.Join(" ", displayTest[i]));
            }
            

            //stops console app from closing immediately after running
            Console.ReadKey();

        }
    }
}