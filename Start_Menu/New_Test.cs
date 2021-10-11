using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Driver_Lib;

namespace Start_Menu
{
    public partial class New_Test : Form
    {
        public New_Test()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxAnswers.Items.Add(textBox4.Text);

        }
    }
}
