using System.Reflection;
using System.Runtime.InteropServices;
using System;
using TestClickApplication.UI;
using TestClickApplication.OS;
using TestClickApplication.ClickApi;

namespace TestClickApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Start a system observer object
            SystemObserver observer = new SystemObserver();
            observer.Start();
            // Create an ApiService object
            ApiService service = new ApiService();
            // Run the form
            Application.Run(new Form1(observer, service));
        }
    }
}