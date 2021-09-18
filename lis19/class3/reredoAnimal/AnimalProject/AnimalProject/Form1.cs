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
        //object, a sort of animals that have the same 
        //characters
        private Animal dog;
        private Animal cat;
        private Animal pig;
        public Form1()
        {
            //
            InitializeComponent();
            dog = new Animal("dog", "Fido", 4);
            cat = new Animal("cat", "Fluffy", 4);
            pig = new Animal("pig", "Fido", 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dog.ListDetails());
            MessageBox.Show(cat.ListDetails());
            MessageBox.Show(pig.ListDetails());
        }
    }
}
