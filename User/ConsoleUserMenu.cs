using _2K2SNP.Factories;
using _2K2SNP.Repositories;
using _2K2SNP.Units;
using System;

namespace ConsoleUser
{
    public class ConsoleUserMenu 
    {
        private string pointer { get; set; }
        private int pPos { get; set; }
        private string list_ind { get; set; }
        private string title { get; set; }
        private bool exit { get; set; }

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
        }

        private void CreateRepositories()
        {
            authorRepository = repFactory.createAuthorRepository();
            bookRepository = repFactory.createBookRepository(authorRepository);
        }

        private string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private void AddAuthor()
        {
            Console.Clear(); Console.WriteLine("\tAdd new author");
            authorRepository.Add(
                new Author(
                    Input("First name : "),
                    Input("Middle name : "),
                    Input("Last name: "),
                    int.Parse(Input("Year of birth : ")),
                    int.Parse(Input("Year of death : "))
                    )
                );
        }


        private void AddBook()
        {
            Console.Clear(); Console.WriteLine("\tAdd new Book");
            bookRepository.Add(
                new Book(
                    (Author)authorRepository[int.Parse(Input("Author (pos) : ")) - 1],
                    Input("Title : "),
                    int.Parse(Input("Publication year : ")),
                    int.Parse(Input("Pages : ")),
                    Input("ISBN : ")
                )
            );
        }

        private void RemoveAuthor()
        {
            Console.Clear();
            Console.Write("Author to remove (number) : "); int pos = int.Parse(Console.ReadLine());
            authorRepository.Remove(pos - 1);
        }

        private void RemoveBook()
        {
            Console.Clear();
            Console.Write("Book to remove (number) : "); int pos = int.Parse(Console.ReadLine());
            bookRepository.Remove(pos - 1);
        }

        public void CallMenu()
        {
            ShowCurrentContext(
                new[]
                {
                    "Add",
                    "Remove",
                    "Show",
                    "Settings",
                    "Exit"
                },
                new Action[]
                {
                    CallAddContext,
                    CallRemoveContext,
                    CallListsContext,
                    CallSettingsContext,
                    GoToExit
                });
        }

        private void CallAddContext()
        {
            ShowCurrentContext(
                new[]
                {
                    "Author",
                    "Book",
                    "Exit",
                },
                new Action[]
                {
                    AddAuthor,
                    AddBook,
                    GoToExit
                });
        }

        private void CallRemoveContext()
        {
            ShowCurrentContext(
                new[]
                {
                    "Author",
                    "Book",
                    "Exit",
                },
                new Action[]
                {
                    RemoveAuthor,
                    RemoveBook,
                    GoToExit
                });
        }

        private void CallListsContext()
        {
            ShowCurrentContext(
                new[]
                {
                    "Author",
                    "Book",
                    "Exit",
                },
                new Action[]
                {
                    RefreshAndWriteAuthors,
                    RefreshAndWriteBooks,
                });
        }

        private void CallSettingsContext()
        {
            ShowCurrentContext(
                new[]
                {
                    "Change title" ,
                    "Change indexation",
                    "Change pointer",
                    "Exit"
                },
                new Action[]
                {
                    ChangeTitle,
                    ChangeIndexation,
                    ChangePointer,
                    GoToExit
                });
        }

        private void ShowCurrentContext(string[] options, Action[] actions)
        {
            exit = false;
            int rowN = options.Length, pPos = 1;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\t{title}");
                for (int i = 0; i < rowN; i++)
                {
                    if (list_ind == "ORDERED")
                        Console.Write($"{i + 1}. ");
                    else if (list_ind == "UNORDERED")
                        Console.Write("*");

                    Console.Write("{0,-20}", options[i]);

                    if (i + 1 == pPos)
                        Console.Write($" {pointer}");
                    Console.WriteLine();
                }

                var key = Console.ReadKey().Key;

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
                        actions[pPos - 1].Invoke();

                        break;
                }
            }
        }

        private void ChangeTitle()
        {
            Console.Clear();
            Console.Write("Enter title : ");
            title = Console.ReadLine();
        }

        private void ChangeIndexation()
        {
            Console.Clear();
            Console.Write("Enter indexation type : ");
            list_ind = Console.ReadLine();
        }

        private void ChangePointer()
        {
            Console.Clear();
            Console.Write("Enter pointer : ");
            pointer = Console.ReadLine();
        }
        private void GoToExit() => exit = true;

        private void RefreshAndWriteAuthors() => RefreshAndWrite(authorRepository);
        private void RefreshAndWriteBooks() => RefreshAndWrite(bookRepository);

        private void RefreshAndWrite(IRepository rep)
        {
            rep.Refresh();
            Console.WriteLine(rep);
        }
    }
}