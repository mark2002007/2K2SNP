using System;
using System.Collections.Generic;

namespace _2K2SNP.Commands
{
    public class CommandLogger
    {
        private static List<(ICommand, DateTime)> log = new List<(ICommand, DateTime)>();

        private CommandLogger()
        {
        }

        private static CommandLogger _instance;

        public static CommandLogger GetInstance()
        {
            if (_instance == null) _instance = new CommandLogger();
            return _instance;
        }

        public static void LogCommand(ICommand cmd) => log.Add((cmd, DateTime.Now));

        public static void ShowLog()
        {
            foreach (var elem in log)
            {
                Console.WriteLine($"{elem.Item2.ToString("MM/dd/yyyy HH:mm:ss")} --- {elem.Item1.GetType().Name}");
            }
            Console.ReadKey();
        }

        public static void ExecuteLastCommand() => log[log.Count - 1].Item1.Execute();
    }
}