using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using _2K2SNP.Factories;

namespace Tools
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
}
