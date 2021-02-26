using System;
using System.Collections.Generic;
using System.Text;

namespace _2K2SNP.Menu
{
    public interface IMenu
    {
        void AddCustomer();
        void AddEmployee();
        void AddAuthor();
        void AddBook();
        void RemoveCustomer();
        void RemoveEmployee();
        void RemoveAuthor();
        void RemoveBook();
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
