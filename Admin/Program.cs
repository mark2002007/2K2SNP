using System;
using System.IO;
using System.Threading;
using _2K2SNP.Factories;
using System.Configuration;

namespace Admin
{
    public class AppConfigurator
    {
        private static IFactory factory;

        static AppConfigurator()
        {
            switch (System.Configuration.ConfigurationManager.AppSettings["factory_type"])
            {
                case "txt":
                    factory = new TxtFactory();
                    break;
                default:
                    factory = new MemoryFactory();
                    break;
            }
        }

        public static IFactory getFactory() => factory;
    }
    internal class Program
    {

        private static void Main(string[] args)
        {
            ConsoleAdminMenu menu = new ConsoleAdminMenu(AppConfigurator.getFactory());
            menu.ShowMenu();
        }
    }
}