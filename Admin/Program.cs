using System;
using System.Linq;
using _2K2SNP.Factories;
using Tools;

namespace ConsoleAdmin
{
    internal class Program
    {   
        private static void Main(string[] args)
        {
            ConsoleAdminMenu menu = new ConsoleAdminMenu(AppConfigurator.getFactory(), title: "AdminMenu");
            menu.CallMenu();
        }
    }
}