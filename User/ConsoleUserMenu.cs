﻿using _2K2SNP.Menu;
using _2K2SNP.Repositories;
using _2K2SNP.Units;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO;
using _2K2SNP.Commands;
using _2K2SNP.Factories;

namespace User
{
    public class ConsoleUserMenu : IMenu
    {
        private string pointer { get; set; }
        public int pPos { get; set; }
        public string list_ind { get; set; }
        public string title { get; set; }

        private AddAuthorCommand addAuthorCommand;
        private AddBookCommand addBookCommand;

        private RemoveAuthorCommand removeAuthorCommand;
        private RemoveBookCommand removeBookCommand;

        private IFactory repFactory;

        private IRepository authorRepository;
        private IRepository bookRepository;

        public ConsoleUserMenu(IFactory rep_type, string title = "Menu", string list_ind = "ORDERED", string pointer = "<")
        {
            this.title = title;
            this.list_ind = list_ind;
            this.pointer = pointer;
            repFactory = rep_type;

            CreateRepositories();
            CreateCommands();
        }

        private void CreateRepositories()
        {
            authorRepository = repFactory.createAuthorRepository();
            bookRepository = repFactory.createBookRepository(authorRepository);
        }

        private void CreateCommands()
        {
            addAuthorCommand = new AddAuthorCommand(this);
            addBookCommand = new AddBookCommand(this);

            removeAuthorCommand = new RemoveAuthorCommand(this);
            removeBookCommand = new RemoveBookCommand(this);
        }

        public void AddAuthor()
        {
            Console.Clear(); Console.WriteLine("\tAdd new author");
            Console.Write("First name : "); string fName = Console.ReadLine();
            Console.Write("Middle name : "); string mName = Console.ReadLine();
            Console.Write("Last name : "); string lName = Console.ReadLine();
            Console.Write("Year of birth : "); int YOB = int.Parse(Console.ReadLine());
            Console.Write("Year of death : "); int YOD = int.Parse(Console.ReadLine());
            authorRepository.Add(new Author(fName, mName, lName, YOB, YOD));
        }

        public void AddBook()
        {
            Console.Clear(); Console.WriteLine("\tAdd new Book");
            Console.Write("Author (pos): "); Author author = (Author)authorRepository[int.Parse(Console.ReadLine()) - 1];
            Console.Write("Title : "); string title = Console.ReadLine();
            Console.Write("Publication year : "); int pub_year = int.Parse(Console.ReadLine());
            Console.Write("Pages : "); int pages = int.Parse(Console.ReadLine());
            Console.Write("ISBN : "); string ISBN = Console.ReadLine();
            bookRepository.Add(new Book(author, title, pub_year, pages, ISBN));
        }

        public void RemoveAuthor()
        {
            Console.Clear();
            Console.Write("Author to remove (number) : "); int pos = int.Parse(Console.ReadLine());
            authorRepository.Remove(pos - 1);
        }

        public void RemoveBook()
        {
            Console.Clear();
            Console.Write("Employee to remove (number) : "); int pos = int.Parse(Console.ReadLine());
            bookRepository.Remove(pos - 1);
        }

        public void ShowMenu()
        {
            bool exit = false;
            int rowN = 6, pPos = 1;
            ConsoleKey key;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\t{title}");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED") Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED") Console.Write("*");
                    switch (i + 1)
                    {
                        case 1:
                            Console.Write("{0,-10}", "Add");
                            break;

                        case 2:
                            Console.Write("{0,-10}", "Remove");
                            break;

                        case 3:
                            Console.Write("{0,-10}", "Show");
                            break;

                        case 4:
                            Console.Write("{0,-10}", "Settings");
                            break;

                        case 5:
                            Console.Write("{0,-10}", "Redo");
                            break;

                        case 6:
                            Console.Write("{0,-10}", "Exit");
                            break;
                    }

                    if (i + 1 == pPos) Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;

                    case ConsoleKey.E:
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (pPos)
                        {
                            case 1:
                                ShowAdd();

                                break;

                            case 2:
                                ShowRemove();

                                break;

                            case 3:
                                ShowShow();

                                break;

                            case 4:
                                ShowSettings();

                                break;

                            case 5:
                                CommandLogger.ExecuteLastCommand();

                                break;

                            case 6:
                                exit = true;
                                break;
                        }
                        break;
                }
            }
        }

        public void ShowAdd()
        {
            bool exit = false;
            int rowN = 3, pPos = 1;
            ConsoleKey user_input;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\tAdd");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED") Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED") Console.Write("*");

                    switch (i + 1)
                    {
                        case 1:
                            Console.Write("{0,-10}", "Author");
                            break;

                        case 2:
                            Console.Write("{0,-10}", "Book");
                            break;

                        case 3:
                            Console.Write("{0,-10}", "Exit");
                            break;
                    }

                    if (i + 1 == pPos) Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                user_input = Console.ReadKey().Key;
                switch (user_input)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (pPos)
                        {
                            case 1:
                                addAuthorCommand.Execute();
                                break;

                            case 2:
                                addBookCommand.Execute();
                                break;

                            case 3:
                                exit = true;
                                break;
                        }

                        break;
                }
            }
        }

        public void ShowRemove()
        {
            bool exit = false;
            int rowN = 3, pPos = 1;
            ConsoleKey user_input;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\tRemove");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED") Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED") Console.Write("*");

                    switch (i + 1)
                    {
                        case 1:
                            Console.Write("{0,-10}", "Author");

                            break;

                        case 2:
                            Console.Write("{0,-10}", "Book");
                            break;

                        case 3:
                            Console.Write("{0,-10}", "Exit");
                            break;
                    }

                    if (i + 1 == pPos) Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                user_input = Console.ReadKey().Key;
                switch (user_input)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (pPos)
                        {
                            case 1:
                                removeAuthorCommand.Execute();

                                break;

                            case 2:
                                removeBookCommand.Execute();

                                break;

                            case 3:
                                exit = true;
                                break;
                        }

                        break;
                }
            }
        }

        public void ShowShow()
        {
            bool exit = false;
            int rowN = 4, pPos = 1;
            ConsoleKey user_input;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\tShow");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED") Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED") Console.Write("*");

                    switch (i + 1)
                    {
                        case 1:
                            Console.Write("{0,-10}", "Authors");
                            break;

                        case 2:
                            Console.Write("{0,-10}", "Books");
                            break;

                        case 3:
                            Console.Write("{0,-10}", "Log");
                            break;

                        case 4:
                            Console.Write("{0,-10}", "Exit");
                            break;
                    }

                    if (i + 1 == pPos) Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                user_input = Console.ReadKey().Key;
                switch (user_input)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (pPos)
                        {
                            case 1:
                                Console.WriteLine(authorRepository);
                                break;

                            case 2:
                                Console.WriteLine(bookRepository);
                                break;

                            case 3:
                                Console.WriteLine(CommandLogger.ToString());
                                break;

                            case 4:
                                exit = true;
                                break;
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void ShowSettings()
        {
            bool exit = false;
            int rowN = 4, pPos = 1;
            ConsoleKey user_input;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\tSettings");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED") Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED") Console.Write("*");

                    switch (i + 1)
                    {
                        case 1:
                            Console.Write("{0,-20}", "Change title");
                            break;

                        case 2:
                            Console.Write("{0,-20}", "Change indexation");
                            break;

                        case 3:
                            Console.Write("{0,-20}", "Change pointer");
                            break;

                        case 4:
                            Console.Write("{0,-20}", "Exit");
                            break;
                    }

                    if (i + 1 == pPos) Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                user_input = Console.ReadKey().Key;
                switch (user_input)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (pPos)
                        {
                            case 1:
                                ChangeTitle();

                                break;

                            case 2:
                                ChangeIndexation();

                                break;

                            case 3:
                                ChangePointer();

                                break;

                            case 4:
                                exit = true;
                                break;
                        }
                        break;
                }
            }
        }

        public void ChangeTitle()
        {
            Console.Clear();
            Console.Write("Enter title : ");
            title = Console.ReadLine();
        }

        public void ChangeIndexation()
        {
            Console.Clear();
            Console.Write("Enter indexation type : ");
            list_ind = Console.ReadLine();
        }

        public void ChangePointer()
        {
            Console.Clear();
            Console.Write("Enter pointer : ");
            pointer = Console.ReadLine();
        }
        
        public void AddCustomer()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee()
        {
            throw new NotImplementedException();
        }
    }
}