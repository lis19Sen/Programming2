using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALibraryOfBooks
{
    public class Book
    {
        private int iD;
        private string title;
        private string borrower;
        private bool issued;

        public Book(int iD, string title)
        {
            this.ID = iD;
            this.Title = title;
            
            issued = false;
            borrower = "";
        }

        

        public void Issue(int iD, string newBorrwoer)
        {
            issued = true;
            borrower = newBorrwoer;
        }

        public void Return(int iD)
        {
            issued = false;
            borrower = "";
        }

        public int ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value; }
        public string Borrower { get => borrower; set => borrower = value; }
        public bool Issued { get => issued; set => issued = value; }
    }
}
