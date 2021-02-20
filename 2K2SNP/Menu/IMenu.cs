using System;
using System.Collections.Generic;
using System.Text;

namespace _2K2SNP.Menu
{
    public interface IMenu
    {
        void AddAuthor();
        void AddBook();
        void AddCustomer();
        void AddEmployee();

        void RemoveAuthor();
        void RemoveBook();
        void RemoveCustomer();
        void RemoveEmployee();

        void ShowMenu();
        void ShowAdd();
        void ShowRemove();
        void ShowShow();
        void ShowSettings();
        void ChangeTitle();
        void ChangeIndexation();
        void ChangePointer();
    }
}
