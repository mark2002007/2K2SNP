namespace Admin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConsoleAdminMenu menu = new ConsoleAdminMenu("Menu", "ORDERED");
            menu.ShowMenu();
        }
    }
}