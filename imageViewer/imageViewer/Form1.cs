using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (counter==1)
            {
                picBoxOne.Image = Properties.Resources.lion;
                counter--;


            }
            else if (counter==2)
            {
                picBoxOne.Image = Properties.Resources.tiger;
                counter--;

            }
            else
            {
                picBoxOne.Image = Properties.Resources.woods;
                counter = 2;
            }

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            
            if (counter==0){
                picBoxOne.Image = Properties.Resources.lion;
                counter++;
                
                
            }
            else if (counter==1){
                picBoxOne.Image = Properties.Resources.tiger;
                counter++;
                
            }
            else
            {
                picBoxOne.Image = Properties.Resources.woods;
                counter = 0;
            }

        }
    }
}
