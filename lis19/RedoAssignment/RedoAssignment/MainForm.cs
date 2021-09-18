/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a form for player
   Description:		    Main menu
   Known Bugs:		    No
   Additional Features: More attractive
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a form to hold menu and tell the player how to play
   Description:		    Game Form
   Known Bugs:		    No
   Additional Features: More attractive
*/
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //method, to connect the two forms
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
            Application.Exit();
        }
    }
}
