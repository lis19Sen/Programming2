/* Project name:          Animal
 * Project file name:     AnimalProject
 * Author:                Sen Li
 * Date:                  31/07/2018
 * Language:              C#
 * Platform:              Microsoft Visual Studio 2017
 * Purpose:               To know the structure of a making class and making objects belong to the class
 * Description:
 * Known bugs:
 * Additional Features:
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalProject
{
    public partial class Form1 : Form
    {
        private Animal dog;                   //declearation
        private Animal cat;
        private Animal frog;
        public Form1()
        {
            InitializeComponent();
            dog = new Animal("Deerdog","Fingo ", 3);      //creat objects
            cat = new Animal("kitty cat", "Fluffy",4);
            frog = new Animal("Tadpol", "Freddie", 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dog.ListDetails());       //use the object to do sth
            MessageBox.Show(cat.ListDetails());
            MessageBox.Show(frog.ListDetails());

        }
    }
}
