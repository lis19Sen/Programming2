using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALibraryOfBooks
{
    public class Library
    {
        // constant
        private const int NUMBEROFBOOK = 10;
        private const int STRINGS = 3;

        //field
        private List<Book> books;
        private DataGridView dataGridView;

        //constructer

        public Library(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            books = new List<Book>();

            populateLibrary();
            addDataGridRows();
            DisplayAllBooks();
        }

        //methods
        private void populateLibrary()
        {
            books.Add(new Book(1, "C#"));
            books.Add(new Book(2, "Web"));
            books.Add(new Book(3, "PP1"));
            books.Add(new Book(4, "Language"));
            books.Add(new Book(5, "Programming2"));
            books.Add(new Book(6, "Big And Small"));
            books.Add(new Book(7, "In And Out"));
            books.Add(new Book(8, "Numbers in School"));
            books.Add(new Book(9, "Words"));
            books.Add(new Book(10, "Sounds"));
        }

        private void addDataGridRows()
        {
            foreach (Book book in books)
            {
                string[] newRow = new String[STRINGS];
                dataGridView.Rows.Add(newRow);
            }
        }

        public void DisplayAllBooks()
        {
            foreach (Book book in books)
            {
                displayABook(book);
            }
        }

        private void displayABook(Book book)
        {
            int index = book.ID - 1;
            dataGridView.Rows[index].Cells[0].Value = book.ID;
            dataGridView.Rows[index].Cells[1].Value = book.Title;

            if (book.Issued)
            {
                dataGridView.Rows[index].Cells[2].Value = book.Borrower;
            }
            else
            {
                dataGridView.Rows[index].Cells[2].Value = "In";
            }
        }

        public void Issue(int iDNumber, string newBorrower)
        {
            if (!books[iDNumber].Issued)
            {
                books[iDNumber].Issued = true;
                books[iDNumber].Issue(iDNumber,newBorrower);
                DisplayAllBooks();
            }
            else
            {
                MessageBox.Show(books[iDNumber].Title + " is not available");
            }
        }
        public void Return(int iDNumber)
        {
            int index = iDNumber - 1;
            if (books[iDNumber].Issued)
            {
                books[iDNumber].Issued = false;
                dataGridView.Rows[index].Cells[2].Value = "In";
                DisplayAllBooks();
            }
        }
    }
}
