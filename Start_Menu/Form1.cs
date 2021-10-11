using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Start_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            New_Test new_TestForm = new New_Test();
            new_TestForm.ShowDialog();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.ShowDialog();
            this.Close();
        }
    }
}
