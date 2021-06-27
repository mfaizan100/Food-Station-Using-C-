using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace FOOD_ORDERING_PROJECT
{
    public partial class Confirm_Order : Form
    {
        public Confirm_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 openForm= new Form1();
            openForm.Show();
            this.Hide();
          
        }
    }
}
