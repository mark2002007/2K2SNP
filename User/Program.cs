using _2K2SNP.Factories;
using System;
using System.Configuration;
using Tools;

namespace ConsoleUser
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUserMenu menu = new ConsoleUserMenu(AppConfigurator.getFactory(), title: "UserMenu");
            menu.CallMenu();
        }
    }
}
