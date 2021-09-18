using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALibraryOfBooks
{
    public partial class Form1 : Form
    {
        //field
        private Library library;
        private DataGridView dataGridView;
        public Form1()
        {
            InitializeComponent();
            dataGridView = dataGridView1;
            this.library = new Library(dataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            library.DisplayAllBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(textBox1.Text) - 1;
            string newBorrower = textBox2.Text;
            library.Issue(bookId, newBorrower);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(textBox1.Text) - 1;
            library.Return(bookId);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
