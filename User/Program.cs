using _2K2SNP.Factories;
using System;
using System.Configuration;

namespace User
{
    class Program
    {
        public class AppConfigurator
        {
            private static IFactory factory;

            static AppConfigurator()
            {
                switch (ConfigurationManager.AppSettings["factory_type"])
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
        static void Main(string[] args)
        {
            ConsoleUserMenu menu = new ConsoleUserMenu(AppConfigurator.getFactory(), title: "UserMenu");
            menu.ShowMenu();
        }
    }
}
