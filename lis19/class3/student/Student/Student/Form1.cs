using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        private Student student1;
        public Form1()
        {
            InitializeComponent();
            student1 = new Student("Li", "Sen", 32, 100046470);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(student1.Enrol());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(student1.Withdraw());
        }
    }
}
