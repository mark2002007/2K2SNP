using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMenu menu = new UserMenu("Menu", "ORDERED");
            menu.ShowMenu();
        }
    }
}
