using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMarkSumariser
{
    public partial class Form1 : Form
    {
        private Random random;
        private Data data1;
        private Data data2;
        private Summariser summariser;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            data1 = new Data(random);
            data2 = new Data(random);
            summariser = new Summariser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearListboxes();
            clearTextboxes();
            createNewScores();
            filListBoxes();
            
        }
        private void clearListboxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void clearTextboxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void createNewScores()
        {
            data1.CreatSocres();
            data2.CreatSocres();
        }

        private void filListBoxes()
        {
            foreach (int score in data1.Scores)
            {
                listBox1.Items.Add(score);
            }
            foreach (int score in data2.Scores)
            {
                listBox2.Items.Add(score);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = summariser.CalculateMimimum(data1.Scores).ToString();
            textBox2.Text = summariser.CaculateMaximum(data1.Scores).ToString();
            textBox3.Text = summariser.Average(data1.Scores).ToString();
            textBox4.Text = summariser.CalculateMimimum(data2.Scores).ToString();
            textBox5.Text = summariser.CaculateMaximum(data2.Scores).ToString();
            textBox6.Text = summariser.Average(data2.Scores).ToString();
        }
        
    }
}
