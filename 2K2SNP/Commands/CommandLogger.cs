using System;
using System.Collections.Generic;
using System.IO;

namespace _2K2SNP.Commands
{
    public class CommandLogger
    {
        //TODO : Add in-file logging
        //1)private static ReadLogs()
        //2)private static WriteLogs()

        private static List<(ICommand, DateTime)> log = new List<(ICommand, DateTime)>();

        private static CommandLogger _instance;

        private CommandLogger()
        {
        }

        static CommandLogger() => _instance = new CommandLogger();

        public static CommandLogger GetInstance() => _instance;

        public static void LogCommand(ICommand cmd) => log.Add((cmd, DateTime.Now));

        public static string ToString()
        {
            string str = string.Empty;
            foreach (var elem in log)
                str += $"{elem.Item2.ToString("MM/dd/yyyy HH:mm:ss")} --- {elem.Item1.GetType().Name}\n";
            return str;
        }

        public static void ExecuteLastCommand() => log[log.Count - 1].Item1.Execute();
    }
}